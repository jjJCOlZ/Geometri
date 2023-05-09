
namespace FIRKANT
{
    //Parallelomgram inheritance from Shape
    internal class Parallelogram : Shape
    {
        private double sideA;
        private double sideB;
        private double angleInRadians;

        //name, 4 and Length is from Shape. In this class we create SideA, SideB and AngleInRadians
        public Parallelogram(string name, double Length, double sideB, double angleInDegrees) : base(name, 4, (int)Length)
        {
            SideA = Length;
            SideB = sideB;
            AngleInRadians = angleInDegrees * Math.PI / 180.0;
        }

        //properties
        public double SideA
        {
            get { return sideA; }
            set { sideA = value; }
        }

        public double SideB
        {
            get { return sideB; }
            set { sideB = value; }
        }

        public double AngleInRadians
        {
            get { return angleInRadians; }
            set { angleInRadians = value; }
        }

        public override double GetPerimeter()
        {
            return 2 * (SideA + SideB);
        }

        public override double GetArea()
        {
            return SideA * SideB * Math.Sin(AngleInRadians);
        }
    }
}