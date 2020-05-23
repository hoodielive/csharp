namespace IceCream
{
    public class MyCar
    {
        private int topSpeed;
        private string color;

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