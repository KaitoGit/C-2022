using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class Fridge : Products
    {
        public string capacity;
        public string electricity;
        public string noise;
        //devlaring values
        public Fridge(string capacity, string electricity, string noise)
        {
            this.capacity = capacity;
            this.electricity = electricity;
            this.noise = noise;
            //assigning them
        }


        public string printFridgeInfo()
        {
            return $"{brand}_{model}_{id}_{capacity}_{electricity}_{noise}_{price}_{type}";
            //and finally returnung values
        }
    }
}
