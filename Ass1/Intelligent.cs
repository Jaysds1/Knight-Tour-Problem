/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightTour
{
    class Intelligent : Chess
    {

        int[,] hBoard = new int[8, 8]{ //Heuristic board.
                    {2,3,4,4,4,4,3,2},
                    {3,4,6,6,6,6,4,3},
                    {4,6,8,8,8,8,6,4},
                    {4,6,8,8,8,8,6,4},
                    {4,6,8,8,8,8,6,4},
                    {4,6,8,8,8,8,6,4},
                    {3,4,6,6,6,6,4,3},
                    {2,3,4,4,4,4,3,2}
                };
        int[] horizontal = new int[8] { 2, 1, -1, -2, -2, -1, 1, 2 };
        int[] vertical = new int[8] { -1, -2, -2, -1, 1, 2, 2, 1 };
        int currentRow, currentCol,startRow = 0,startCol = 0;
        int squares, avg, standDev; //Trials = Game runs, Squares = movements, Standard Deviation = 

        public Intelligent(int x, int y)
        {
            //Initialize default position
            startRow = x;
            startCol = y;

            currentCol = startCol;
            currentRow = startRow;

            //initilizing the board with first move
            board[currentCol, currentRow] = 1;
        }

        public void options(int[] vert, int[] horiz, int[,] hboard, bool[] legal)
        {
            int move = 0;
            int tempRow = currentRow + vert[move];
            int tempCol = currentCol + horiz[move];
            //int temp = board[currentRow+move, currentCol+move];

            if (hboard[tempRow, tempCol] == 0)
            {
                legal[move] = true;
            }
            else
            {
                legal[move] = false;
            }
            ++move;
        }

        public int moves(int cRow, int cCol, int[] vert, int[] horiz, int[,] hboard, bool[] legal)
        {
            int minAccess = 8;
            int bestMove = 0;

            for (int options = 0; options < 8; options++)
            {
                if (legal[options] == false)
                {
                    continue;
                }
                int tempR = cRow + vert[options];
                int tempC = cCol + horiz[options];

                if (hboard[tempR, tempC] < options)
                {
                    options = hboard[tempR, tempC];
                    bestMove = options;
                }

            }
            return bestMove;
        }


    }
}
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KnightTour
{
    class Intelligent
    {

        public void hauristicBoard()
        {
            int[,] board = new int[8, 8];
            int[] horizontal = new int[8] { 2, 1, -1, -2, -2, -1, 1, 2 };
            int[] vertical = new int[8] { -1, -2, -2, -1, 1, 2, 2, 1 };
            bool[] legal = new bool[] { false };
            int startRow = 0;   //will be user defined
            int startCol = 0;   //will be user defined
            int currentRow, currentCol;

            //to count the number of blocks so that it equals 64 
            for (int block = 1; block <= 64; block++)
            {

                int[,] hBoard = new int[8, 8]{ //Heuristic board.
                    {2,3,4,4,4,4,3,2},
                    {3,4,6,6,6,6,4,3},
                    {4,6,8,8,8,8,6,4},
                    {4,6,8,8,8,8,6,4},
                    {4,6,8,8,8,8,6,4},
                    {4,6,8,8,8,8,6,4},
                    {3,4,6,6,6,6,4,3},
                    {2,3,4,4,4,4,3,2}
                };

                //moves = moves(currentRow, currentCol, vertical, horizontal, hBoard, legal);
            }//end of for

            currentCol = startCol;
            currentRow = startRow;

            //populating the board with 0s 
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    board[i, j] = 0;
                }
            }

            //occupied tile
            board[currentCol, currentRow] = 1;

        }

        public void options(int cRow, int cCol, int[] vert, int[] horiz, int[,] hboard, bool[] legal)
        {// finds the moves available
            int move = 0;
            int tempRow = cRow + vert[move];
            int tempCol = cCol + horiz[move];

            if (hboard[tempRow, tempCol] == 0)
            {
                legal[move] = true;
            }
            else
            {
                legal[move] = false;
            }
            ++move;
        }

        public int moves(int cRow, int cCol, int[] vert, int[] horiz, int[,] hboard, bool[] legal)
        {// finds the best possible moves 
            int minAccess = 2;
            int bestMove = 0;

            for (int options = 0; options < 8; options++)
            {
                if (legal[options] == false)
                {
                    continue;
                }
                //store current legal move in temp var
                int tempR = cRow + vert[options];
                int tempC = cCol + horiz[options];

                //choose the lowest number avaible and make that the best move.
                if (hboard[tempR, tempC] < minAccess)
                {
                    minAccess = hboard[tempR, tempC];
                    bestMove = options;
                    break;
                }




            }
            return bestMove;
        }

        public void Write(String s)
        {//writing to the text file

            using (StreamWriter sw = new StreamWriter(Path.Combine(Directory.GetCurrentDirectory(), "AsherHauristicMethod.txt"), true))
            {
                sw.Write(s);
            }
        }


    }
}