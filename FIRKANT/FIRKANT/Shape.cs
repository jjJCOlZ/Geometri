


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRKANT
{
    internal abstract class Shape
    {
        public string Name { get; set; }
        public int NumberOfSides { get; set; }
        public int Length { get; set; }

        public Shape(string name, int numberOfSides, int Length)
        {
            Name = name;
            NumberOfSides = numberOfSides;
            Length = Length;
        }

        public abstract double GetArea();

        public abstract double GetPerimeter();
    }
}
