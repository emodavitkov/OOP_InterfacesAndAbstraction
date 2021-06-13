using System;
using System.Collections.Generic;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {

            var radius = int.Parse(Console.ReadLine());
            IDrawable circle = new Circle(radius);

            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());
            IDrawable rect = new Rectangle(width, height);

            circle.Draw();
            rect.Draw();


            //IDrawable rectangle = new Rectangle(4, 6);

            //rectangle.Draw();


            //IDrawable circle = new Circle(5);


            //List<IDrawable> drawObject = new List<IDrawable>();


            //circle.Draw();

            //drawObject.Add(new Rectangle(5, 6));
            //drawObject.Add(new Circle(5));

            //foreach (var item in drawObject)
            //{
            //    item.Draw();
            //}

        }
    }
}
