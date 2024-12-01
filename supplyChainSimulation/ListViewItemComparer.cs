using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supplyChainSimulation
{
    public class ListViewItemComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            ListViewItem itemX = x as ListViewItem;
            ListViewItem itemY = y as ListViewItem;

            if (itemX != null && itemY != null)
            {
                // Extrahiere die Zahl am Ende des Strings
                int numX = ExtractNumberFromString(itemX.Text);
                int numY = ExtractNumberFromString(itemY.Text);

                // Vergleiche die Zahlen
                return numX.CompareTo(numY);
            }

            return 0;
        }

        // Extrahiert die Zahl am Ende des Strings
        private int ExtractNumberFromString(string str)
        {
            // Hier wird angenommen, dass der String mit Buchstaben beginnt und dann eine Zahl folgt.
            string numberPart = new string(str.SkipWhile(c => !char.IsDigit(c)).ToArray());
            return int.TryParse(numberPart, out int result) ? result : 0;
        }
    }
}
