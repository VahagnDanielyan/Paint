using Paint.Colors;
using System;
using System.Text;

namespace Paint.Shapes
{
    internal class Arrow : Line
    {
        public Arrow(IColorable _color)
          : base(_color)
        { }

        public sealed override int Length { get; set; }

        public override void Draw()
        {
            StringBuilder sb = new();

            sb.Append(' ', Length - 3).Append('*').AppendLine();
            sb.Append(' ', Length - 2).Append('*').AppendLine();
            sb.Append('*', Length).AppendLine();
            sb.Append(' ', Length - 2).Append('*').AppendLine();
            sb.Append(' ', Length - 3).Append('*').AppendLine();

            Console.WriteLine(sb);
        }
    }
}
