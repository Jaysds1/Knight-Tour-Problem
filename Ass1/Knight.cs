using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightTour
{
    class Knight:Chess
    {
        private int[][] move = { new int[]{2,1}, new int[]{1,2} }; // {Horizontal, Vertical}
        /*
         * X, Y
         * x+2,y+1 - Left Up L Horizontal
         * 2-x,y+1 - Right Up L Horizontal
         * x+2,1-y - Left Down L Horizontal
         * 2-x,1-y - Right Down L Horizontal
         * x+1,y+2 - Left Up Vertical
         * 1-x,y+2 - Right Up L Vertical
         * x+1,2-y - Left Down Vertical
         * 1-x,2-y - Right Down Vertical
         */
        public int[][] getOptions()
        {
            //Is it in a corner?
            int[] pos = Position; //[x,y]
            int x=pos[0],y=pos[1];
            int[][] availMoves = {
                                     new int[]{x+move[0][0],Math.Abs(move[0][0]-x), x+move[1][0], Math.Abs(move[1][0]-x)},
                                     new int[]{y+move[0][1],Math.Abs(move[0][1]-y), y+move[1][1], Math.Abs(move[1][1]-y)}
                                 };
            int[][] r = {new int[]{},new int[]{}}; //Returning Variable with the options
            //Moves allowed to make (Max:8)
            //Horizontal
            for (int yy = 0; yy < 2; yy++)
            {
                for (int xx = 0; xx < 2; xx++)
                {
                    if (!Bound(availMoves[0][xx], availMoves[1][yy]))
                        continue;
                    if (board[availMoves[0][xx]][availMoves[1][yy]] == 0)
                    {
                        r[r.Length][0] = availMoves[0][xx];
                        r[r.Length][1] = availMoves[1][yy];
                    }
                }
            }
            //Vertical
            for (int yy = 2; yy < 4; yy++)
            {
                for (int xx = 2; xx < 4; xx++)
                {
                    if(!Bound(availMoves[0][xx],availMoves[1][yy]))
                        continue;
                    if (board[availMoves[0][xx]][availMoves[1][yy]] == 0)
                    {
                        r[r.Length][0] = availMoves[0][xx];
                        r[r.Length][1] = availMoves[1][yy];
                    }
                }
            }
            return r;
        }
        private bool Bound(int x, int y)
        {
            if (x > 0 && x < board.Length)
                if (x > 0 && x < board[x].Length)
                    return true;
            return false;
        }
        public void Move(int x, int y)
        {
            if(x>0 && y>0)
                Position = new int[]{x,y};
        }
    }
}
