using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SimCim.Generator
{
    public class ModelBuildingOptions
    {
        public string OutputDir { get; set; }
        public string CSharpNamespace { get; set; }
        public TextWriter Error { get; internal set; }
        public TextWriter Out { get; internal set; }
        public string CimNamespace { get; internal set; }
    }
}
