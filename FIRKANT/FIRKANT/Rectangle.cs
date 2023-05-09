
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRKANT
{   //Rectangle inheritance from Shape
    internal class Rectangle : Shape
    {
        //properties
        public int LengthB { get; set; }

        //getting name, numberOfSides and Length from Shape
        public Rectangle(string name, int numberOfSides, int Length, int LengthB) : base(name, numberOfSides, Length)
        {
            LengthB = LengthB;
        }

        public override double GetArea()
        {
            return Length * LengthB;
        }

        public override double GetPerimeter()
        {
            return 2 * (Length + LengthB);
        }
    }
}