using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RougueLike
{
    internal class Player
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Player(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void GoLeft(Map map) => X = map.IsWall(X - 1, Y) ? X : X - 1;
        public void GoRight(Map map) => X = map.IsWall(X + 1, Y) ? X : X + 1;
        public void GoUp(Map map) => Y = map.IsWall(X, Y - 1) ? Y : Y - 1;
        public void GoDown(Map map) => Y = map.IsWall(X, Y + 1) ? Y : Y + 1;
    }
}
