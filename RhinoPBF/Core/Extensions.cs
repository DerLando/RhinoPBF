using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rhino.Geometry;

namespace RhinoPBF.Core
{
    public static class Extensions
    {
        public static Point3d ToPoint3d(this Point pt)
        {
            return new Point3d(pt.x, pt.y, 0);
        }
    }
}
