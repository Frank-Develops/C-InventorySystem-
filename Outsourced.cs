using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem_Frank_Bishop
{
    internal class Outsourced : Part
    {
        public String CompanyName { get; set; }

        public Outsourced() { }
        public Outsourced(int partID, string name, decimal price, int inStock, int min, int max, string companyName) : base(partID, name, price, inStock, min, max)

        {
            this.CompanyName = companyName;
        }
    }
}
