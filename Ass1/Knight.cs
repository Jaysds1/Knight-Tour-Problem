using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightTour
{
    class Knight:Chess
    {
        private int[][] move = { new int[]{2,1}, new int[]{1,2} }; // Allowed moves {Horizontal, Vertical}
        
        public int[,] getOptions()
        {
            int[] pos = Position; //[x,y]
            int x=pos[0],y=pos[1];
            int[][] availMoves = new int[][]{
                                     new int[4]{x+move[0][0],x-move[0][0], x+move[1][0], x-move[1][0]},
                                     new int[4]{y+move[0][1],y-move[0][1], y+move[1][1], y-move[1][1]}
                                 };
            int[,] r = new int[8,2]; //Returning Variable with the options

            /*
             * Moves allowed to make (Max:8)
         * X, Y
         * x+2,y+1 - Left Up L Horizontal
         * x-2,y+1 - Right Up L Horizontal
         * x+2,y-1 - Left Down L Horizontal
         * x-2,y-1 - Right Down L Horizontal
         * x+1,y+2 - Left Up Vertical
         * x-1,y+2 - Right Up L Vertical
         * x+1,y-2 - Left Down Vertical
         * x-1,y-2 - Right Down Vertical
         */
            for (int i = 0; i < 8; i++)
            {
                if (i < 4)
                {
                    if (!Bound(availMoves[0][i], availMoves[1][i]))
                    {
                        r[i, 0] = 0;
                        r[i, 1] = 0;
                        continue;
                    }
                    r[i, 0] = availMoves[0][i];
                    r[i, 1] = availMoves[1][i];
                }
                else
                {
                    if (!Bound(availMoves[0][i - 4], availMoves[1][i - 4]))
                    {
                        r[i, 0] = 0;
                        r[i, 1] = 0;
                        continue;
                    }
                    r[i, 0] = availMoves[0][i-4];
                    r[i, 1] = availMoves[1][i-4];
                }
            }
            return r;
        }
        private bool Bound(int x, int y) //Check if values are off the board
        {
            if (x > 0 && x < 8)
                if (y > 0 && y < 8)
                    return true;
            return false;
        }
        public void Move(int x, int y) //Move the knight
        {
            if(x>0 && y>0)
                Position = new int[]{x,y};
        }
    }
}
