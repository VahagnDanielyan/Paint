using System;

namespace Paint.Colors
{
    internal class Green : IColorable
    {
        public void SetColor()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}
