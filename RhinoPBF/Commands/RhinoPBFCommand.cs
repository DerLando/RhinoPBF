using System;
using System.Collections.Generic;
using System.Diagnostics;
using Rhino;
using Rhino.Commands;
using Rhino.Geometry;
using Rhino.Input;
using Rhino.Input.Custom;
using RhinoPBF.Core;

namespace RhinoPBF.Commands
{
    public class RhinoPBFCommand : Command
    {
        public RhinoPBFCommand()
        {
            // Rhino only creates one instance of each command class defined in a
            // plug-in, so it is safe to store a refence in a static property.
            Instance = this;
        }

        ///<summary>The only instance of this command.</summary>
        public static RhinoPBFCommand Instance
        {
            get; private set;
        }

        ///<returns>The command name as it appears on the Rhino command line.</returns>
        public override string EnglishName
        {
            get { return "RhinoPBFCommand"; }
        }

        protected override Result RunCommand(RhinoDoc doc, RunMode mode)
        {
            RhinoApp.WriteLine("The {0} command is under construction.", EnglishName);

            var point = Core.Extern.GetTestPoint().ToPoint3d();
            doc.Objects.AddPoint(point);

            doc.Views.Redraw();

            var path = "D:\\Downloads\\bremen-latest.osm.pbf";
            var count = Extern.ReadPBF(path);

            return Result.Success;
        }
    }
}
