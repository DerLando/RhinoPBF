using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RhinoPBF.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Point
    {
        public double x;
        public double y;
    }
}
