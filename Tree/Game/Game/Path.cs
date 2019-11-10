using System;

namespace Game
{
    public class Path
    {
        private readonly MapLocation[] _path; 

        public Path(MapLocation[] path)
        {
            _path = path; 
        }

        public GetLocationAt(int pathStep)
        {
          if (pathStep >= 0 && _path.Length > pathStep) return _path[pathStep];
        }
    }
}