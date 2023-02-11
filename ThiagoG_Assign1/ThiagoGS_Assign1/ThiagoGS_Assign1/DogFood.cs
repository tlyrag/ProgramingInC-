using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiagoGS_Assign1
{
    internal class DogFood
    {
        /// Creating Read Only Auto Properties. Public was added to allow other classes to access the property.
        public string BrandName { 
            get;
        }
        public double CanUnitPrice { 
            get;
        }
        // Creating read-write Autoproperty
        public int NumCans { 
            get; 
            set; 
        }
        // Creating Read-only computed property
        public double BrandTotal
        {
            get { 
                return NumCans*CanUnitPrice; 
            }
        }
        // creating constructor and assigning the parameters to the class properties
        public DogFood(string brandName, double canUnitPrice) {
            this.BrandName = brandName;
            this.CanUnitPrice = canUnitPrice;
        }
        /* creating the override ToString method using the string format
         * adding Currency format to both Can Unit Price and Brand Tota
         * the /n escape character was added to create a new line for the item
         * a space was given in the begining of the string format argument, 
         * so each line could also have a space for a better code redability
         */ 
        public override string ToString()
        {
            string dogFood = String.Format(" Brand Name:{0}\n Can Unit Pirce:{1:C}\n Number of Cans:{2}\n Brand Total: {3:C}",BrandName,CanUnitPrice,NumCans,BrandTotal);

            return dogFood;
        }
    }
}
