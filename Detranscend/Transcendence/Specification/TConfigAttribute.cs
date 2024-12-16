using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Detranscend.Transcendence.Specification
{
    public class TConfigAttribute
    {
        public string Name { get; set; } = "attribute";
        public string Type { get; set; } = "string";
        public string? EditorTag { get; set; }
    }
}
