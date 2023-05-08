using System;

namespace FIRKANT
{
    internal class Square : Shape
    {
        public Square(string name, int numberOfSides, int Length) : base(name, numberOfSides, Length)
        {
        }

        public override double GetArea()
        {
            return base.Length * base.Length;
        }

        public override double GetPerimeter()
        {
            return base.NumberOfSides * base.Length;
        }
    }
}