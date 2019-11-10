using System;

namespace Game
{
    public class GameExceptions : Exception
    {
        public GameExceptions()
        {
        }
        public GameExceptions(string message) : base(message)
        {
        }
    }

    public class OutOfBoundsException : GameExceptions
    {
        public OutOfBoundsException()
        {
        }
        
        public OutofBoundsException(string message) : base(message)
        {
        }
    }
}