using Paint.Colors;
using System;
using System.Text;

namespace Paint.Shapes
{
    internal class Rectangle : Shape
    {
        public Rectangle(IColorable _color)
        {
            Console.ForegroundColor = _color.Color;
            SizeX = 5;
            SizeY = 10;
        }

        public virtual int SizeX { get; set; }
        public virtual int SizeY { get; set; }
        public sealed override void Draw()
        {
            StringBuilder sb = new();

            for (int i = 0; i < SizeX; i++)
            {
                if (i == 0 || i == SizeX - 1)
                {
                    sb.Append('*', SizeY).AppendLine();
                }
                else
                {
                    sb.Append('*').Append(' ', SizeY - 2).Append('*').AppendLine();
                }
            }

            Console.WriteLine(sb);
        }
    }
}
