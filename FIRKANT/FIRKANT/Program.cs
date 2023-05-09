using System;
using System.Collections.Generic;

namespace FIRKANT
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a list with objects from Shape (Triangle, Trapeze, Square, Rectangle & Parallelogram)
            List<Shape> shapes = new List<Shape>();

            //Square
            Square squareOne = new Square("SquareOne", 9, 5);
            shapes.Add(squareOne);

            //Sqyare
            Square squareTwo = new Square("SquareTwo", 4, 7);
            shapes.Add(squareTwo);

            //Rectangle
            Rectangle rectangleOne = new Rectangle("RectangleOne", 8, 4, 3);
            shapes.Add(rectangleOne);

            //Parallleogram
            Parallelogram parallelogram1 = new Parallelogram("Parallelogram1", 4, 1, 6);
            shapes.Add(parallelogram1);

            //Trapaze
            Trapeze trapezeOne = new Trapeze("TrapezeOne", 4, 1, 3, 6, 9);
            shapes.Add(trapezeOne);

            
            //Trapaze
            Triangle triangleOne = new Triangle("TriangleOne", 3, 4, 5);
            shapes.Add(triangleOne);

            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"{shape.Name} har en omkreds på {shape.GetPerimeter()} og et areal på {shape.GetArea()}");
            }


        }
    }
}