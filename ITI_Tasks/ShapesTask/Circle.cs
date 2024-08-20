using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesTask
{
    public class Circle : GeoShapes
    {
        public float Radius { get { return Dim1; } set { Dim1 = Dim2 = value; } }
        public Circle(float radius)
        {
            Radius = radius;
        }
        public override float CalcArea()
        {
            return 3.14f * Radius * Radius;
        }
    }
}
