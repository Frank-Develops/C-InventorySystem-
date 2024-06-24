using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem_Frank_Bishop
{
    internal class Inhouse : Part
    {

        public int MachineID { get; set; }

        public Inhouse() { }
        public Inhouse(int partID, string name, decimal price, int inStock, int min, int max, int MachineID) : base(partID, name, price, inStock, min, max)

        {
            this.MachineID = MachineID;
        }
    }
}
