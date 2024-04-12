using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougueLike
{
    internal class Map
    {
        private char[,] map;
        public int Width { get; private set; }
        public int Height { get; private set; }
        public Map(int width, int height)
        {
            this.Width = width;
            this.Height = height;
            map = new char[width, height];
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    map[x, y] = (x > 0 && x < width - 1 && y > 0 && y < height - 1) ? '.' : '#';
                }
            }
        }
        public bool IsWall(int x, int y) => map[x, y] is not '.';
    }
}
