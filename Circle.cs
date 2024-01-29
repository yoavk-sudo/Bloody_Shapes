using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloody_Shapes
{
    internal class Circle : Shape
    {
        private float _radius;

        float Radius
        {
            get
            {
                return Math.Abs(_radius);
            }
            set
            {
                if(value < 0) _radius = Math.Abs(value);
                if (value == 0) _radius = float.MinValue;
            } 
        }

        private Circle(float positionX, float positionY, float width, float height) : base(positionX, positionY, width, height)
        {
        }

        public Circle(float radius, float positionX, float positionY, float width, float height) : this(positionX, positionY, width, height)
        {
            Radius = radius;
        }

        protected override float Perimeter()
        {
            return Math.Abs((float)(Radius * 2 * Math.PI));
        }
        protected override float Area()
        {
            return Perimeter() / 2 * Radius;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            Circle other = (Circle)obj;
            return PositionX == other.PositionX && PositionY == other.PositionY && Radius == other.Radius;
        }

        public override string ToString()
        {
            return "Circle";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(PositionX, PositionY, Radius);
        }

        public override int NumberOfVertices()
        {
            return 0;
        }
    }
}
