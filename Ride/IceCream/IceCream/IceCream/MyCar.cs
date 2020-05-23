namespace IceCream
{
    public class MyCar
    {
        private string color;
        private readonly int topSpeed;

        public MyCar(int passedTopSpeed, string passedColor)
        {
            topSpeed = passedTopSpeed;
            color = passedColor;
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
}

MyCar toyota = new MyCar('160', 'red');

Console.WriteLine(toyota.topSpeed);