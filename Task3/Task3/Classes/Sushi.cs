using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Classes
{
    public class Sushi
    {

        public string name { get; set; }

        public double price { get; set; }

        public double weight { get; set; }

        public string ingredients { get; set; }

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
            return name + " " + price + " uah " + weight + " g " + ingredients;
        }

        public string ToWrite()
        {
            return name + " " + price + " uah " + weight + " g " + ingredients;
        }

        public string ForList
        {
            get
            {
                return $"{name} {price} uah";
            }
        }
    }
}
