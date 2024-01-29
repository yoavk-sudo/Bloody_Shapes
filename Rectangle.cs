using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloody_Shapes
{
    internal class Rectangle : Shape
    {
        public Rectangle(float positionX, float positionY, float width, float height) : base(positionX, positionY, width, height)
        {
        }

        protected override float Perimeter()
        {
            return Math.Abs(Width) * 2 + Math.Abs(Height * 2);
        }
        public override string ToString()
        {
            return "Rectangle";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj is not Rectangle other) return false;
            return PositionX == other.PositionX &&
                PositionY == other.PositionY &&
                Width == other.Width &&
                Height == other.Height;
        }

        public override int NumberOfVertices()
        {
            return 4;
        }
    }
}
