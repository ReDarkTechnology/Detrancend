using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Detranscend.Transcendence.Specification
{
    public class TConfig
    {
        public bool CapitalUnid { get; set; } = false;
        public string Name { get; set; } = "TElement";
        public List<TConfigAttribute> Attributes { get; set; } = new();
    }
}
