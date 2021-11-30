using Paint.Colors;

namespace Paint.Shapes
{
    internal class Square : Rectangle
    {
        public Square(IColorable _color)
          : base(_color)
        { }

        private int _sizeX;
        public sealed override int SizeX
        {
            get => _sizeX;
            set
            {
                _sizeX = value;
                _sizeY = value;
            }
        }

        private int _sizeY;
        public sealed override int SizeY
        {
            get => _sizeY;
            set
            {
                _sizeX = value;
                _sizeY = value;
            }
        }
    }
}
