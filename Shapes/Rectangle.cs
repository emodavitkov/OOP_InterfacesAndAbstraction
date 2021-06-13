using System;

namespace Shapes
{
    public class Rectangle : IDrawable
    {

        private int height;
        private int width;

        public Rectangle(int height, int width)
        {
            Height = height;
            Width = width;

        }
        public int Height
        {
            get => height;
            set => height = value;
        }

        

        public int Width
        {
            get => width;
            set => width = value;
        }


        public void Draw()
        {
            DrawLine(this.Width, '*', '*');
            for (int i = 1; i < this.Height - 1; ++i)
                DrawLine(this.Width, '*', ' ');
            DrawLine(this.Width, '*', '*');
        }
        private void DrawLine(int width, char end, char mid)
        {
            Console.Write(end);
            for (int i = 1; i < width - 1; ++i)
                Console.Write(mid);
            Console.WriteLine(end);
        }
    }
}