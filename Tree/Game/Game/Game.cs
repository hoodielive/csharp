using System;

namespace Game
{
    class Game
    {
        public static void Main()
        {
            Map map = new Map(8, 5);
            
            MapLocation point = new MapLocation(4, 2, map);
            bool isOnMap = map.OnMap(point);
            Console.WriteLine(isOnMap);
            
            point.DistanceTo(5, 5);
            
            Console.WriteLine(point.DistanceTo(5,5));
            Console.WriteLine(point is MapLocation);

            try
            {
                MapLocation noneMapLocation = new MapLocation(20, 20, map);
            }
            catch(Exception)
            {
               Console.WriteLine("Sorry, That map location is not on the map."); 
            }
        }
    }
}