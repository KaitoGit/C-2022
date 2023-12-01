using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class Stove : Products
    {
        public string number;
        public Boolean oven;
        public Boolean gas;
        //declaring variables
        public Stove(string number, Boolean oven, Boolean gas)
        {
            this.number = number;
            this.oven = oven;
            this.gas = gas;
            //assigning values to variables
        }

        public string printStoveInfo()
        {
            return $"{brand}_{model}_{id}_{number}_{oven}_{gas}_{price}_{type}";
            //and finally returning them
        }
    }
}
