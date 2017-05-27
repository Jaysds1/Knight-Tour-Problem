using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KnightTour
{
    class Non_Intelligent:Chess
    {
        /*
         * Randomly select Knight's move until there's no more choices/options
         */
        const string fn = @"c:\JaiquonNonIntelligentMethod.txt";
        private static Knight k = new Knight();
        int trials, squares, standDev;

        public Non_Intelligent(int trials, int x, int y)
        {
            this.trials = trials;
            k.Position = new int[]{x,y};
            k.getOptions();
            for (int t = 0; t < trials; t++)
            {
                Start();
                OutputTrial(t + 1);
            }
        } 
        private void Start() {
            int[][] moves = k.getOptions(); //Get first options
            Random r = new Random();
            int c=0; //Counter
            while (moves.Length > 0)
            {
                k.Position = moves[r.Next(moves.Length)]; //Set Knight to position
                board[k.Position[0]][k.Position[1]] = c++;//Update the board movement
                moves = k.getOptions(); //Get new options
                squares++;
            }
            OutputBoard();
        }
        private void OutputBoard()
        {
            for (int x = 0; x < board.Length; x++)
            {
                for (int y = 0; y < board[x].Length; y++)
                {
                    Write(board[x][y]+"");
                }
            }
        }
        private void OutputTrial(int trial)
        {
            Write("Trial " + trial + ": The knight was able to successfully touch " + squares + " squares.");
        }

        public void Write(String s)
        {
            StreamWriter sw;
            if(File.Exists(fn))
                sw = File.AppendText(fn);
            else
                sw = File.CreateText(fn);
            using (sw)
            {
                sw.WriteLine(s);
            }
        }
    }
}
