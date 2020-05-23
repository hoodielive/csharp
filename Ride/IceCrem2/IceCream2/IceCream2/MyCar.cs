using System;

public class MyCar
    {
    public int topSpeed;
    public string topColor;
    public MyCar(int topSpeed, string topColor)
    {
        topSpeed = topSpeed;
        topColor = topColor;
    }

    public int GetTopSpeed()
    {
        return topSpeed;
    }

    public void PaintCar(string newColor)
    {
        color = newColor;
    }
}

MyCar toyota = new MyCar(300, "red");