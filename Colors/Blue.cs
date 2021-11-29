using System;

namespace Paint.Colors
{
    internal class Blue : IColorable
    {
        public void SetColor()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
    }
}
