using System;

namespace Paint.Colors
{
    internal class Red : IColorable
    {
        public void SetColor()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }
}
