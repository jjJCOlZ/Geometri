using System;

namespace FIRKANT
{
    internal class Triangle : Shape
    {
        //Adding new variables: sideA, sideB and hypotenuse
        private double sideA;
        private double sideB;
        private double hypotenuse;

        //name, 3 and hypotenuse is from the base
        public Triangle(string name, double sideA, double sideB, double hypotenuse) : base(name, 3, (int)hypotenuse)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.hypotenuse = hypotenuse;
        }

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

        public double Hypotenuse
        {
            get { return hypotenuse; }
            set { hypotenuse = value; }
        }

        public override double GetPerimeter()
        {
            return SideA + SideB + Hypotenuse;
        }

        public override double GetArea()
        {
            return 0.5 * SideA * SideB;
        }
    }
}