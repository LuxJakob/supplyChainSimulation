using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace supplyChainSimulation
{
    internal class SharedData
    {
        public static int AnotherSharedVariable { get; set; }

        public static XDocument XML_doc { get; set; }
    }
}
