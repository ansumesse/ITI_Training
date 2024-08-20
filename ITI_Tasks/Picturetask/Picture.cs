using ShapesTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picturetask
{
    public class Picture
    {
        GeoShapes[] shapes = new GeoShapes[3];
        public Picture(Circle circle, Triangle triangle, Rectangle rectangle)
        {
            shapes[0] = circle;
            shapes[1] = triangle;
            shapes[2] = rectangle;
        }
        public GeoShapes[] Shapes { get { return shapes; } set { shapes = value; } }
        public float TotalAreas()
        {
            return shapes[0].CalcArea() + shapes[1].CalcArea() + shapes[2].CalcArea();
        }

    }
}
