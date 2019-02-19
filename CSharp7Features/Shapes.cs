namespace Tests
{
    internal class Rectangle : Shape
    {
        public int Width { get; }
        public int Height { get; }

        public Rectangle(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

    }

    internal class Circle : Shape {
        public int Radius { get; }

        public Circle (int radius) {
            this.Radius = radius;
        }
    }

    internal class Shape {}
}