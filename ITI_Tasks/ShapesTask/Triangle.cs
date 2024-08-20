using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesTask
{
    public class Triangle : GeoShapes
    {
        public float Base { get { return Dim1; } set { Dim1 = value; } }
        public float Hight { get { return Dim2; } set { Dim2 = value; } }
        public Triangle(float bas, float hight) 
        {
            Base = bas;
            Hight = hight;
        }
        public override float CalcArea()
        {
            return 0.5f * Base * Hight;
        }

    }
}
