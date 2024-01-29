using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloody_Shapes
{
    internal sealed class Square : Rectangle
    {
        protected override float Height { get => Width; set => Width = value; }
        public Square(float positionX, float positionY, float width, float height) : base(positionX, positionY, width, height)
        {
            // Users can make a square with different values for width and height
            // My method that makes Height = Width might obfuscate the properties a bit too much
        }

        public override string ToString()
        {
            return "Square";
        }
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
    }
}
