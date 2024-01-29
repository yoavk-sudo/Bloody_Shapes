using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloody_Shapes
{
    internal abstract class Shape
    {
        protected float PositionX {  get; set; }
        protected float PositionY {  get; set; }
        protected float Width {  get; set; }
        protected virtual float Height {  get; set; }

        protected abstract float Perimeter();

        public abstract int NumberOfVertices();

        public Shape(float positionX, float positionY, float width, float height)
        {
            PositionX = positionX;
            PositionY = positionY;
            Width = width;
            Height = height;
        }

        protected virtual float Area()
        {
            return Math.Abs(Width * Height);
        }
        
        public void Draw()
        {
            Console.WriteLine($"This shape is a {this}. It has {NumberOfVertices} vertices");
        }


        public override int GetHashCode()
        {
            return HashCode.Combine(PositionX, PositionY, Width, Height);
        }
    }
}
