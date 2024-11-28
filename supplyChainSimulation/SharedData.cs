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

        // CapacityPlanning variables
        public static Dictionary<int, int> addCapacityRequirements = new Dictionary<int, int>();
        public static Dictionary<int, int> waitinglistworkstations = new Dictionary<int, int>();
        public static Dictionary<int, int> setupTimeBacklog = new Dictionary<int, int>();
        public static Dictionary<int, int> setupBacklogSum = new Dictionary<int, int>();
        public static Dictionary<int, int> totalCapacity = new Dictionary<int, int>();
        public static Dictionary<int, int> shifts = new Dictionary<int, int>();
        public static Dictionary<int, int> overtime = new Dictionary<int, int>();
        public static Dictionary<int, int> defaultSetupTime = new Dictionary<int, int>
        {
            { 1, 60 },
            { 2, 80 },
            { 3, 60 },
            { 4, 80 },
            { 6, 60 },
            { 7, 210 },
            { 8, 155 },
            { 9, 140 },
            { 10, 120 },
            { 11, 80 },
            { 12, 12 },
            { 13, 13 },
            { 14, 14 },
            { 15, 30 }
        };

        // PurchasePartDisposition variables
        public static XElement futureinwardstockmovement;
        public static Dictionary<int, (int, int, int)> futureStockList = new Dictionary<int, (int, int, int)>();

        public static List<int> incomingStocks = new List<int>() { 0, 0, 0, 0 };

        public static Dictionary<int, (double, double)> deliveryTime = new Dictionary<int, (double, double)>()
        {
            { 21, (1.8, 0.4) },
            { 22, (1.7, 0.4) },
            { 23, (1.2, 0.2) },
            { 24, (3.2, 0.3) },
            { 25, (0.9, 0.2) },
            { 27, (0.9, 0.2) },
            { 28, (1.7, 0.4) },
            { 32, (2.1, 0.5) },
            { 33, (1.9, 0.5) },
            { 34, (1.6, 0.3) },
            { 35, (2.2, 0.4) },
            { 36, (1.2, 0.1) },
            { 37, (1.5, 0.3) },
            { 38, (1.7, 0.4) },
            { 39, (1.5, 0.3) },
            { 40, (1.7, 0.2) },
            { 41, (0.9, 0.2) },
            { 42, (1.2, 0.3) },
            { 43, (2.0, 0.5) },
            { 44, (1.0, 0.2) },
            { 45, (1.7, 0.3) },
            { 46, (0.9, 0.3) },
            { 47, (1.1, 0.1) },
            { 48, (1.0, 0.2) },
            { 52, (1.6, 0.4) },
            { 53, (1.6, 0.2) },
            { 57, (1.7, 0.3) },
            { 58, (1.6, 0.5) },
            { 59, (0.7, 0.2) }
        };

        public static Dictionary<int, int> requirement0 = new Dictionary<int, int>();
        public static Dictionary<int, int> requirement1 = new Dictionary<int, int>();
        public static Dictionary<int, int> requirement2 = new Dictionary<int, int>();
        public static Dictionary<int, int> requirement3 = new Dictionary<int, int>();

        public static Dictionary<int, int> prediction0 = new Dictionary<int, int>();
        public static Dictionary<int, int> prediction1 = new Dictionary<int, int>();
        public static Dictionary<int, int> prediction2 = new Dictionary<int, int>();
        public static Dictionary<int, int> prediction3 = new Dictionary<int, int>();

        public static Dictionary<int, int> futureStock0 = new Dictionary<int, int>();
        public static Dictionary<int, int> futureStock1 = new Dictionary<int, int>();
        public static Dictionary<int, int> futureStock2 = new Dictionary<int, int>();
        public static Dictionary<int, int> futureStock3 = new Dictionary<int, int>();

        public static Dictionary<int, (int, int)> purchaseParts = new Dictionary<int, (int, int)>();

        public static Dictionary<int, int> discountQuantity = new Dictionary<int, int>
        {
            { 21, 300 },
            { 22, 300 },
            { 23, 300 },
            { 24, 6100 },
            { 25, 3600 },
            { 27, 1800 },
            { 28, 4500 },
            { 32, 2700 },
            { 33, 900 },
            { 34, 22000 },
            { 35, 3600 },
            { 36, 900 },
            { 37, 900 },
            { 38, 300 },
            { 39, 1800 },
            { 40, 900 },
            { 41, 900 },
            { 42, 1800 },
            { 43, 2700 },
            { 44, 900 },
            { 45, 900 },
            { 46, 900 },
            { 47, 900 },
            { 48, 1800 },
            { 52, 600 },
            { 53, 22000 },
            { 57, 600 },
            { 58, 22000 },
            { 59, 1800 }
        };

        public static Dictionary<int, (int, int, int)> partUsage = new Dictionary<int, (int, int, int)>
        {
            { 21, (1, 0, 0) },
            { 22, (0, 1, 0) },
            { 23, (0, 0, 1) },
            { 24, (7, 7, 7) },
            { 25, (4, 4, 4) },
            { 27, (2, 2, 2) },
            { 28, (4, 5, 6) },
            { 32, (3, 3, 3) },
            { 33, (0, 0, 2) },
            { 34, (0, 0, 72) },
            { 35, (4, 4, 4) },
            { 36, (1, 1, 1) },
            { 37, (1, 1, 1) },
            { 38, (1, 1, 1) },
            { 39, (2, 2, 2) },
            { 40, (1, 1, 1) },
            { 41, (1, 1, 1) },
            { 42, (2, 2, 2) },
            { 43, (1, 1, 1) },
            { 44, (3, 3, 3) },
            { 45, (1, 1, 1) },
            { 46, (1, 1, 1) },
            { 47, (1, 1, 1) },
            { 48, (2, 2, 2) },
            { 52, (2, 0, 0) },
            { 53, (72, 0, 0) },
            { 57, (0, 2, 0) },
            { 58, (0, 72, 0) },
            { 59, (2, 2, 2) }
        };

        public static List<int> evenRows = new List<int> { 21, 23, 25, 28, 33, 35, 37, 39, 41, 43, 45, 47, 52, 57, 59 };

        // Splitting variables
        public static List<int> splittingArticelList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 26, 29, 30, 31, 49, 50, 51, 54, 55, 56 };

        public static List<int> splittedArticels = new List<int>();

        public static List<(int, int)> modifiedArticelsfinalized = new List<(int, int)>();


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
