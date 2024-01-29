using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloody_Shapes
{
    internal class Triangle : Shape
    {

        protected virtual float SideA { get { return Width; } set { Width = value; } }
        protected virtual float SideB { get; set; }
        protected virtual float SideC { get; set; }

        private Triangle(float positionX, float positionY, float width, float height) : base(positionX, positionY, width, height)
        {
        }

        public Triangle(float sideB, float sideC, float positionX, float positionY, float width, float height) : this(positionX, positionY, width, height)
        {
            Width = width;
            Height = height;
            PositionX = positionX;
            PositionY = positionY;
            SideA = Width;
            SideB = sideB;
            SideC = sideC;

        }

        protected override float Area()
        {
            return base.Area() / 2;
        }

        protected override float Perimeter()
        {
            return Math.Abs(SideA) + Math.Abs(SideB) + Math.Abs(SideC);
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj is not Triangle other) return false;
            return PositionX == other.PositionX &&
                PositionY == other.PositionY &&
                SideA == other.SideA &&
                SideB == other.SideB &&
                SideC == other.SideC;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), SideB, SideC);
        }

        public override string ToString()
        {
            return "Triangle";
        }

        public override int NumberOfVertices()
        {
            return 3;
        }
    }
}
