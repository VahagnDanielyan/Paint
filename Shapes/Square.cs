using Paint.Colors;
using System;
using System.Text;

namespace Paint.Shapes
{
    public class Square : Shape
    {
        private int SideLength { get; init; }

        public Square(int sideLength, IColorable color)
        {
            color.SetColor();
            SideLength = sideLength;
        }

        public override void Draw()
        {
            StringBuilder sb = new();

            for (int i = 0; i < SideLength; i++)
            {
                if (i == 0 || i == SideLength - 1)
                {
                    sb.Append('*', SideLength).AppendLine();
                }
                else
                {
                    sb.Append('*').Append(' ', SideLength - 2).Append('*').AppendLine();
                }
            }

            Console.WriteLine(sb);
        }
    }
}
