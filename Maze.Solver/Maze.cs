
using Maze.Solver.Model;

namespace Maze.Solver
{
    public class Maze
    {
        public string current_maze;
        public List<string> history = new();
        public Tuple<int, int> starting_point;
        public Tuple<int, int> ending_point;
        public Tuple<int, int> position;
        public List<List<Tile>> maze_data = new();
        public List<List<Tile>> journey = new();

        public bool parse(string maze)
        {
            current_maze = maze.Trim();
            history.Add(current_maze);
            if (current_maze.Length > 420) { return false; }
            if (!load_tiles()) { return false; }
            return true;
        }

        private bool load_tiles()
        {
            var rows = current_maze.Split('\n');
            if (rows.Length > 20) { return false; }
            foreach (var row in rows)
            {
                List<Tile> tile_list = new List<Tile>();
                foreach (var tile in row)
                {
                    int tile_index = row.IndexOf(tile);
                    if (tile_index > 19) { return false; }
                    switch (tile) 
                    {
                        case 'S':
                            tile_list.Add(new() { is_start = true, is_end = false, column = tile_index, is_open = true });
                            break;
                        case 'X':
                            tile_list.Add(new() { is_start = false, is_end = false, column = tile_index, is_open = false });
                            break;
                        case '_':
                            tile_list.Add(new() { is_start = false, is_end = false, column = tile_index, is_open = true });
                            break;
                        case 'G':
                            tile_list.Add(new() { is_start = false, is_end = true, column = tile_index, is_open = true });
                            break;
                        default: 
                            return false;
                    }
                }
                maze_data.Add(tile_list);
            }
            return true;
        }

        public bool move_next()
        {
            /* 
             * 1. If Im not on a journey initialize the journey at starting point
             * 2. Look for ajacent open blocks (explored = false and open = true)
             * 3. If there are multiple open blocks I'm a junction
             * 4. Move to the first clockwise open tile (obviously not outside boundries)
             * 5. If it is the goal, this is the end
             * 6. If there are no open blocks this is a dead end, move back to the last junction and decrement the ajacent_open_tiles by 1 and remove the list of the journey up to the junction then back to 2.
             * 7. If the junction has no more unexplored branches (ajacent open tiles) remove the junction status from the journey and move back another junction.
             * 7. If I am out of open blocks and haven't found the goal, this maze is unsolvable.
             */

            return true;
        }
    }
}
