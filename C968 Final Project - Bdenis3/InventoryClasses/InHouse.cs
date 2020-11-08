using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Final_Project___Bdenis3
{
    class InHouse : Part
    {
        private int machineID=-1;
        public int MachineID
        {
            get { return machineID; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The in-house machine ID must be non-negative");
                }
                this.machineID = value;
            }
        }

        public InHouse() { }
        public InHouse(Part partObj, int machine_ID)
        {
            InHouse obj = new InHouse
            {
                PartID = partObj.PartID,
                Name = partObj.Name,
                Price = partObj.Price,
                InStock = partObj.InStock,
                Min = partObj.Min,
                Max = partObj.Max
            };
            obj.MachineID = machineID;

        }
        public InHouse(string name, decimal price, int inStock, int min, int max, int machineID)
            : base(name, price, inStock, min, max)
        {
            this.MachineID = machineID;
        }
        public InHouse(int partID, string name, decimal price, int inStock, int min, int max, int machineID)
            : base(partID, name, price, inStock, min, max)
        {
            this.MachineID = machineID;
        }
        public InHouse(string name, decimal price, int inStock, int min, int max)
            : base(name, price, inStock, min, max)
        {
            this.MachineID = ++machineID;
        }


    }
}
