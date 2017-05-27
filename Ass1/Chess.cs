using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightTour
{
    abstract class Chess
    {
        public int[,] board = new int[8,8]; //64 = 8*8
        public int[] Position { get; set; }
        //public abstract int[][] getOptions();
    }
}
