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

        public static XElement warehousestockX;
        public static XElement waitinglistworkstationsX;
        public static XElement ordersinworkX;
        public static IEnumerable<XElement> waitinglistProductsX;

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
        public static Dictionary<int, int> warehousestock = new Dictionary<int, int>();
        public static Dictionary<int, int> ordersinwork = new Dictionary<int, int>();
        public static Dictionary<int, int> waitinglistProducts = new Dictionary<int, int>();
        public static Dictionary<int, int> productionOrders = new Dictionary<int, int>();

        public static int inventoryE261Value;
        public static int inventoryE161Value;
        public static int inventoryE171Value;
        public static int inventoryE262Value;
        public static int inventoryE162Value;
        public static int inventoryE172Value;
        public static int inventoryE263Value;
        public static int inventoryE163Value;
        public static int inventoryE173Value;

        public static int orderqueue261;
        public static int orderqueue161;
        public static int orderqueue171;
        public static int orderqueue262;
        public static int orderqueue162;
        public static int orderqueue172;
        public static int orderqueue263;
        public static int orderqueue163;
        public static int orderqueue173;

        public static int ordersinwork261;
        public static int ordersinwork161;
        public static int ordersinwork171;
        public static int ordersinwork262;
        public static int ordersinwork162;
        public static int ordersinwork172;
        public static int ordersinwork263;
        public static int ordersinwork163;
        public static int ordersinwork173;

        public static int initialInitMaterial = 0;

        // variables
        public static Dictionary<int, int> waitinglistworkstations = new Dictionary<int, int>();

        // public methods
        public static void AssignValue(Label label, Dictionary<int, int> dictionary, int key)
        {
            if (!dictionary.TryGetValue(key, out int value))
            {
                dictionary[key] = 0;
                value = 0;
            }
            label.Text = value.ToString();
        }

        public static int AssignSharedValue(Label label, Dictionary<int, int> dictionary, int key)
        {
            if (!dictionary.TryGetValue(key, out int value))
            {
                dictionary[key] = 0;
                value = 0;
            }
            value = (int)Math.Round((decimal)(value / 3));
            label.Text = value.ToString();
            return (int)value;
        }

        public static void UpdateLabelValue(Label label, int value)
        {
            if (value < 0)
            {
                value = 0;
                label.BackColor = Color.LightPink;
            }
            else
            {
                label.BackColor = SystemColors.Control;
            }

            label.Text = value.ToString();
        }
    }
}
