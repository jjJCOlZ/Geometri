






using System;

namespace FIRKANT
{
    //Trapeze inheritance from Shape
    internal class Trapeze : Shape
    {
        //properties
        public int LengthB { get; set; }
        public int LengthC { get; set; }
        public int LengthD { get; set; }

        public Trapeze(string name, int numberOfSides, int Length, int LengthB, int LengthC, int LengthD) : base(name, numberOfSides, Length)
        {
            LengthB = LengthB;
            LengthC = LengthC;
            LengthD = LengthD;
        }

        public override double GetArea()
        {
            double h = Math.Sqrt(Math.Pow(Length - LengthB + LengthC + LengthD, 2) - 4 * (Length - LengthB) * (Length - LengthC) * (Length - LengthD)) / 2;
            return (Length + LengthB) * h / 2.0;
        }

        public override double GetPerimeter()
        {
            return Length + LengthB + LengthC + LengthD;
        }
    }
}