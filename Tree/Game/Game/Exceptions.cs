using System;

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
    
    public string OutofBoundsException(string message)
    {
        return "howdy";
    }
}
