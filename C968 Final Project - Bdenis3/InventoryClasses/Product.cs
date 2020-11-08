using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Final_Project___Bdenis3
{
    public class Product
    {
        // private variables
        private int productId;
        private string name;
        private decimal price;
        private int inStock;
        private int min;
        private int max;

        // List of component parts
        public BindingList<Part> associatedParts = new BindingList<Part>();

        // Properties
        public int ProductID
        {
            get { return productId; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Product ID must be a non-negative integer");
                }
                this.productId = value;
            }
        }
        public string Name
        {
            get { return name;  }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The product name must be a non-null, non-empty string");
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
                    throw new ArgumentOutOfRangeException("Price must be a positive, non-zero value");
                }
                this.price = value;
            }
        }
        public int InStock
        {
            get { return inStock; }
            set {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The quantity on hand must be a non-negative value");
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
                    throw new ArgumentOutOfRangeException("Minimum product quantity must be non-negative, and less than the Maximum quantity");
                }
                min = value;
            }
        }
        public int Max
        {
            get { return max; }
            set
            {
                if ((value < 0))
                {
                    throw new ArgumentOutOfRangeException("Maximum product quantity must be non-negative, and greater than the Maximum quantity");
                }
                max = value;
            }
        }


        // Constructors
        public Product() { } // A default empty constructor

        public Product(string name, decimal price, int inStock, int min, int max, BindingList<Part> associatedParts)
        {
            // This is the constructor for a fully populated product (except the ID)
            this.productId = Inventory.NextProductID;
            this.Name = name;
            this.Price = price;
            this.InStock = inStock;
            this.Min = min;
            this.max = max;
            this.associatedParts = associatedParts;
        }

        public Product(int productID, string name, decimal price, int inStock, int min, int max, BindingList<Part> associatedParts)
        {
            // This is the constructor for a fully populated product (except the ID)
            this.productId = productID;
            this.Name = name;
            this.Price = price;
            this.InStock = inStock;
            this.Min = min;
            this.max = max;
            this.associatedParts = associatedParts;
        }
        public Product(string name, decimal price, int inStock, int min, int max)
        {
            // This is the constructor for a product with no associated parts
            this.productId = Inventory.NextProductID;
            this.Name = name;
            this.Price = price;
            this.InStock = inStock;
            this.Min = min;
            this.max = max;
            this.associatedParts = new BindingList<Part>();
        }
        public void AddAssociatedParts(Part newAssocPart)
        {
            this.associatedParts.Add(newAssocPart);
        }
        public Part LookupAssociatedPart(int lookupPartID)
        {
            foreach (Part part in associatedParts)
            {
                if (part.PartID == lookupPartID) { return part; }
            }
            return null;
        }
        public bool RemoveAssociatedPart(int removeID)
        {
            try
            {
                associatedParts.Remove(LookupAssociatedPart(removeID));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
