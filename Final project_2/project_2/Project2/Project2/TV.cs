using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class TV : Products
    {
        public string size;
        public int respond_time;
        public Boolean smart;
        //declaring varicables
        public TV(string size, int respond_time, Boolean smart)
        {
            this.size = size;
            this.respond_time = respond_time;
            this.smart = smart;

            //adding data
        }

        public string printTvInfo()
        {
            return $"{brand}_{model}_{id}_{size}_{smart}_{respond_time}_{price}_{type}";
            //returning them
        }
    }
}
