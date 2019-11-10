namespace Game
{
    class Map
    {
        public readonly int Width;
        public readonly int Height;

        public Map(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public bool OnMap(Point point)
        {
            // FIXME: We want to make sure that all 4 conditions are true, however, this is ugly.
            
            bool inBounds = point.X >= 0 && point.X < Width && point.Y >= 0 && point.Y < Height;
            
            return inBounds;
        }
    }
}