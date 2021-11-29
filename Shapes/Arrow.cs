using Paint.Colors;
using System;
using System.Text;

namespace Paint.Shapes
{
    public class Arrow : Shape
    {
        private int Length { get; init; }

        public Arrow(int length, IColorable color)
        {
            color.SetColor();
            Length = length;
        }

        public override void Draw()
        {
            StringBuilder sb = new();

            sb.Append(' ', Length - 3).Append('*').AppendLine();
            sb.Append(' ', Length - 2).Append('*').AppendLine();
            sb.Append('*', Length).AppendLine();
            sb.Append(' ', Length - 2).Append('*').AppendLine();
            sb.Append(' ', Length - 3).Append('*').AppendLine();

            Console.WriteLine($"\u001b[35m{sb}\u001b[0m");
        }
    }
}
