﻿namespace Game
{
    class Game
    {
        public static void Main()
        {
            Map map = new Map(8, 5);
            
            int area = map.Width * map.Height;
            
            // remember in compilation - game gets Game.exe to change this in mono do the following:
            // mcs -out:GameDefense.exe *.cs
        }
    }
}