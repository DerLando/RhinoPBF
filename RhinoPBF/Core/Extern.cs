using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RhinoPBF.Core
{
    public static class Extern
    {
        [DllImport("pbf_reader.dll")]
        private static extern Point get_test_point();

        public static Point GetTestPoint()
        {
            return get_test_point();
        }

        [DllImport("pbf_reader.dll")]
        private static extern uint read_pbf(string path);

        public static uint ReadPBF(string path)
        {
            return read_pbf(path);
        }
    }
}
