using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Final_Project___Bdenis3
{
    class Outsourced : Part
    {


            private string companyName = null;
            public string CompanyName
            {
                get { return companyName; }
                set
                {
                    if (String.IsNullOrEmpty(value))
                    {
                        throw new ArgumentNullException("The outsource company name must be a non-null / non-empty value");
                    }
                    this.companyName = value;
                }
            }

            public Outsourced() { }
            public Outsourced(string name, decimal price, int inStock, int min, int max, string companyName)
                : base(name, price, inStock, min, max)
            {
                this.CompanyName = companyName;
            }
            public Outsourced(int partID, string name, decimal price, int inStock, int min, int max, string companyName)
                : base(partID, name, price, inStock, min, max)
            {
                this.CompanyName = companyName;
            }
    }
}
