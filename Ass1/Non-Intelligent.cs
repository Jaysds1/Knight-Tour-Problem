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
        const string fn = "JaiquonNonIntelligentMethod.txt";
        private static Knight k = new Knight();
        public int trials, squares; //Trials = Game runs, Squares = movements,
        public double avg, standDev;// Standard Deviation = 
        

        public Non_Intelligent(int trials, int x, int y)
        {
            int[] sqs = new int[trials];
            this.trials = trials; //Set Trials
            k.Position = new int[]{x,y}; //Initialize default position
            for (int t = 0; t < trials; t++)
            {
                Start();
                OutputTrial(t + 1);
                if (trials > 1)
                    sqs[t] = squares;
            }
            if (trials == 1) return;
            for (int s=0; s < sqs.Length; s++)
                avg += sqs[s];
            avg /= trials;
            for (int s=0; s < sqs.Length; s++)
                standDev += Math.Pow(sqs[s] - avg,2);
            standDev *= 1 / 5.0;
            standDev = Math.Sqrt(standDev);
        }
        private void Start() {
            int[,] moves = k.getOptions(); //Get first options
            Random r = new Random();
            int bc=0; //Board Counter
            board[k.Position[0],k.Position[1]] = bc++;
            while (moves.Length > 0)
            {
                int oc = 0; //Option Counter (If no moves are left)
                while (board[k.Position[0], k.Position[1]] > 0)//Find untouched square based on options
                {
                    int i = r.Next(8); //Get random move
                    //Check if the random move is not set
                    while (moves[i, 0] == 0 && moves[i, 1] == 0)
                        i = r.Next(8); //Set new move
                    //Set Knight to position
                    k.Position[0] = moves[i, 0];
                    k.Position[1] = moves[i, 1];
                    oc++;
                    if (oc >= 18) break; //If options are already out
                }
                if (oc >= 18) break; //End of game
                board[k.Position[0],k.Position[1]] = bc++;//Update the board movement
                moves = k.getOptions(); //Get new options
                squares++;
            }
            OutputBoard();
        }
        private void OutputBoard()
        {
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    if(y<7)
                        Write(board[x, y] + "\t");
                    else
                        Write(board[x,y]+"");
                }
                Write("\n");
            }
        }
        private void OutputTrial(int trial)
        {
            Write("Trial " + trial + ": The knight was able to successfully touch " + squares + " squares.\n");
        }

        public void Write(String s)
        {
            using (StreamWriter sw = new StreamWriter(Path.Combine(Directory.GetCurrentDirectory(),fn),true))
            {
                sw.Write(s);
            }
        }
    }
}
