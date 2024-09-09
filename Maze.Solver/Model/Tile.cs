using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze.Solver.Model
{
    public class Tile
    {
        public int row;
        public int column;
        public bool is_junction;
        public int adjacent_open_tiles;
        public bool is_start;
        public bool is_end;
        public bool is_open;
    }
}
