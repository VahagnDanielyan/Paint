using Paint.Colors;
using System;
using System.Text;

namespace Paint.Shapes
{
    public class Rectangle : Shape
    {
        private int Length { get; init; }
        private int Height { get; init; }
        public Rectangle(int length, int height, IColorable color)
        {
            color.SetColor();
            Length = length;
            Height = height;
        }
        public override void Draw()
        {
            StringBuilder sb = new();

            for (int i = 0; i < Height; i++)
            {
                if (i == 0 || i == Height - 1)
                {
                    sb.Append('*', Length).AppendLine();
                }
                else
                {
                    sb.Append('*').Append(' ', Length - 2).Append('*').AppendLine();
                }
            }

            Console.WriteLine(sb);
        }
    }
}
