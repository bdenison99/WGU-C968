using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Final_Project___Bdenis3
{
    public class Inventory
    {
        // public variables
        public static BindingList<Part> AllParts = new BindingList<Part>();
        public static BindingList<Product> Products = new BindingList<Product>();

        // private variables
        private static int nextPartID;
        private static int nextProductID;

        // properties
        public static int NextPartID
        {
            get { return nextPartID++; }
            set { }
        }
        public static int NextProductID
        {
            get { return nextProductID++; }
            set { }
        }
        

        // Part related Methods
        public static void addPart(Part newPart)
        {
            AllParts.Add(newPart);
        }
        public static bool deletePart(Part removePart)
        {
            try
            {
                AllParts.Remove(removePart);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
        public static Part lookupPart(int findPartID)
        {
            foreach (Part p in AllParts)
            {
                if (p.PartID == findPartID)
                {
                    return p;
                }
            }
            return null;
        }
        public static List<Part> lookupPart(string partString)
        {
            List<Part> results = new List<Part>();
            foreach (Part part in AllParts)
            {
                // check the part name for a given string
                if (part.Name.Contains(partString))
                {
                    // The flag variable is used to indicate that we already have a matching part ID in the result set.
                    // If it is set to true, then the matching part record should be added to the result set.
                    bool flag = true;
                    foreach (Part r in results)
                    {
                        if (part.PartID == r.PartID)
                        {
                            flag = false;  // Already have this part in the result set
                        }
                    }
                    if (flag) { results.Add(part); }
                }
            }
            // returns all results from all string related searches
            return results;
        }
        public static void updatePart(int partID, Part newPart)
        {
            Part original = AllParts.Where(i => i.PartID == partID).First();
            int idx = AllParts.IndexOf(original);
            if (idx != -1)
            {
                AllParts[idx] = newPart;
            }
        }

        // Product related Methods
        public static void addProduct(Product newproduct)
        {
            Products.Add(newproduct);
        }
        public static Product lookupProduct(int findproductID)
        {
            foreach (Product prod in Products)
            {
                if (prod.ProductID == findproductID)
                {
                    return prod;
                }
            }
            return null;
        }
        public static bool removeProduct(int deleteID)
        {
            try
            {
                Products.Remove(lookupProduct(deleteID));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool updateProduct (int updateID, Product updatedInfo)
        {
            int idx = -1;
            foreach (Product prod in Products)
            {
                if (prod.ProductID == updateID)
                {
                    idx = Products.IndexOf(prod);
                }
            }
            if (idx != -1)
            {
                Products[idx] = updatedInfo;
                return true;
            }
            return false;
        }
    }
}
