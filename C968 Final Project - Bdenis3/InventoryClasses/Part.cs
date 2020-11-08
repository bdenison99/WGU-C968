using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace C968_Final_Project___Bdenis3
{
    public abstract class Part
    {
        // private variable
        private int partID;
        private string name;
        private decimal price;
        private int inStock;
        private int min;
        private int max;

        // Properties
        public int PartID
        {
            get { return partID; }
            set {
                if (value < 0)
                {
                    throw new IndexOutOfRangeException("Part ID must be non-negative integer");
                }
                this.partID = value;
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Part name must be provided - no empty or null strings");
                }
                this.name = value;
            }
        }
        public decimal Price
        {
            get { return price; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Part price must be greater than zero");
                }
                this.price = value;
            }
        }
        public int InStock
        {
            get { return inStock; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Part quantity in stock must be greater than or equal to zero");
                }
                this.inStock = value;
            }
        }
        public int Min
        {
            get { return min; }
            set
            {
                if ((value < 0))
                {
                    throw new ArgumentOutOfRangeException("Part minimum on hand must be greater than or equal to zero, and less than the maximum quantity on hand");
                }
                min = value;
            }
        }
        public int Max
        {
            get { return max; }
            set
            {
                if ((value < 0) || (value < this.Min))
                {
                    throw new ArgumentOutOfRangeException("Part maximum on hand must be greater than or equal to zero, and greater than the minimum on hand");
                }
                max = value;
            }
        }

        // Constructors
        public Part() { }  // An empty constructor

        /*
         * This constructor accepts values for most properties.
         * The part ID value will come from the inventory class since that value
         * is auto-assigned by the inventory system and not user selectable.
         * The machine ID or Company Name will be assigned in a derived class,
         * based on whether the part in sourced in-house or from another company
        */
        public Part(string name, decimal price, int inStock, int min, int max)
        {
            this.PartID = Inventory.NextPartID;
            this.Name = name;
            this.Price = price;
            this.InStock = inStock;
            this.Min = min;
            this.Max = max;
        }
        public Part(int partID, string name, decimal price, int inStock, int min, int max)
        {
            this.PartID = partID;
            this.Name = name;
            this.Price = price;
            this.InStock = inStock;
            this.Min = min;
            this.Max = max;
        }

    }
}
