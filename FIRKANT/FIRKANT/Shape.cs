


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRKANT
{
    //creating the superclass Shape. 
    internal abstract class Shape
    {
        //properties
        public string Name { get; set; }
        public int NumberOfSides { get; set; }
        public int Length { get; set; }

        //all the classes (having shape as a superclass) is having these: Name, NumberOfSides and Length
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
