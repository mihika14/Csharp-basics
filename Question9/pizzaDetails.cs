using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question9
{
    internal class pizzaDetails
    {
        private string size;
        private int CheeseToppings;
        private int PepproniToppings;
        private int HamToppings;

        public pizzaDetails(string size, int CheeseToppings, int PepproniToppings, int HamToppings)
        {
            this.size = size;
            this.CheeseToppings = CheeseToppings;
            this.PepproniToppings = PepproniToppings;
            this.HamToppings = HamToppings;
        }

        public string Size
        {
            get { return size; }
            set { size = value; }
        }

        public int cheeseToppings
        {
            get { return CheeseToppings; }
            set { CheeseToppings = value; }
        }

        public int pepproniToppings
        {
            get { return PepproniToppings; }
            set { PepproniToppings = value; }
        }

        public int hamToppings
        {
            get { return HamToppings; }
            set { HamToppings = value; }
        }

 
        public double calcCost() 
        {
            double baseprice;
            switch (size.ToLower())
            {
                case "small":
                    baseprice = 10.0;
                    break;
                case "medium":
                    baseprice = 12.0;
                    break;
                case "large":
                    baseprice = 14.0;
                    break;
                default:
                    throw new ArgumentException("Invalid pizza size");
            }

            int TotalToppings = cheeseToppings + hamToppings + pepproniToppings;
            return baseprice + (2 * TotalToppings);
        }

        public string GetDescription()
        {
            return $"Size: {size}, Cheese Toppings: {cheeseToppings}, Pepperoni Toppings: {pepproniToppings} HM oppings: {hamToppings}";
        }
    }
}
