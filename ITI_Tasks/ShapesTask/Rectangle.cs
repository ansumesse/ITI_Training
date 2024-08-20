using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesTask
{
    public class Rectangle :GeoShapes
    {
        public Rectangle(float width, float hight)
        {
            Width = width;
            Hight = hight;
        }

        public float Width { get { return Dim1; } set { Dim1 = value; } }
        public float Hight{ get { return Dim2; } set { Dim2 = value; } }

        public override float CalcArea()
        {
            return Width * Hight;
        }
    }
}
