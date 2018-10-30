using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Classes
{
    class Sushi
    {

        internal string name { get; set; }

        double price { get; set; }

        double weight { get; set; }

        string ingredients { get; set; }

        public Sushi()
        {
            ingredients =string.Empty;
            price =double.NaN;
            name = string.Empty;
            weight = double.NaN;
        }

        public Sushi(string nm, double pr,double wght, string ing)
        {
            ingredients = ing;
            price = pr;
            name = nm;
            weight = wght;

        }

        protected internal bool isGood()
        {
            if(this.name!=string.Empty&&this.price!=double.NaN&&this.weight!=double.NaN&&this.ingredients!=string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return name + " " + price + "$ " + weight + "g " + ingredients;
        }

        public string ToWrite()
        {
            return name + " " + price + " " + weight + " " + ingredients;
        }

    }
}
