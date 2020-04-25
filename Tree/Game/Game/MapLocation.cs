using System;

namespace Game
{
    public class MapLocation : Point
    {
        public MapLocation(int x, int y, Map map) : base(x, y)
        {
            if (!map.OnMap(this))
            {
               // this = current object 
               throw new OutOfBoundsException(); 
            }
        }
    }
}