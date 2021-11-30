using System;

namespace Paint.Shapes
{
    internal abstract class Shape : IDrawable
    {
        public ConsoleColor Color { get; protected set; }

        public abstract void Draw();
    }
}