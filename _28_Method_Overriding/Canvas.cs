using System.Collections.Generic;

namespace _28_Method_Overriding
{
    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.DrawFromProperty();
                shape.Draw();
            }
        }
    }
}
