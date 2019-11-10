using System;

namespace Game
{
    public class Point
    {
        public readonly int X;
        public readonly int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y; 
        }

        public int DistanceTo(int x, int y)
        {
            // How far 2 points are from each other - needs cartesian distance formula.
            // The distance between AB between 2 points with Cartesian coordiantes is really Pythagorean Theorem in disguise.
            // http://hotmath.com/hotmath_help/topics/distance-formula.html
            
            int xDiff = X - x;
            int yDiff = Y - y;
            
            int xDiffSquared = xDiff * xDiff;
            int yDiffSquared = yDiff * yDiff;

            return (int)Math.Sqrt(xDiffSquared + yDiffSquared);

            // Can be Refactored to below: 
            // return (int) Math.Sqrt(Math.Pow(X - x, 2) + Math.Pow(Y - y, 2));
        }
    }
    
}