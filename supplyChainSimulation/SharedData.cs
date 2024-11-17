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
        public static XDocument XML_doc { get; set; }
        public static XElement rootElement;
        
        public static XElement forecast;

        public static XElement warehousestock;
        public static XElement waitinglistworkstations;
        public static XElement ordersinwork;

        // Upload variables

        public static int current_period;

        // SalesProduction variables
        public static List<int> forecast0 = new List<int>() { 0, 0, 0, 0 };
        public static List<int> forecast1 = new List<int>() { 0, 0, 0, 0 };
        public static List<int> forecast2 = new List<int>() { 0, 0, 0, 0 };
        public static List<int> forecast3 = new List<int>() { 0, 0, 0, 0 };

        public static List<int> production0 = new List<int>() { 0, 0, 0, 0 };
        public static List<int> production1 = new List<int>() { 0, 0, 0, 0 };
        public static List<int> production2 = new List<int>() { 0, 0, 0, 0 };
        public static List<int> production3 = new List<int>() { 0, 0, 0, 0 };

        public static List<int> directSale0 = new List<int>() { 0, 0, 0, 0 };
        public static List<int> directSale1 = new List<int>() { 0, 0, 0, 0 };
        public static List<int> directSale2 = new List<int>() { 0, 0, 0, 0 };
        public static List<int> directSale3 = new List<int>() { 0, 0, 0, 0 };

        // MaterialPlanning variables

    }
}
