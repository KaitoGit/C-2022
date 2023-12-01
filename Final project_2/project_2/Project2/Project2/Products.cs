using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class Products
    {
        public string type;
        public string id;
        public string model;
        public string brand;
        public string price;

        public Products() { }  // Empty Constructor
        //in here we will do value assigning
        public Products(string type, string id, string model, string brand, string price)
        {
            this.type = type;
            this.id = id;
            this.model = model;
            this.brand = brand;
            this.price = price;
        }

        public string Type
        {
            //in here we are assigning values of the selected item as you can see theese are the values which exists in all type of products
            get { return type; }
            set {
                if (value.Contains("_"))
                {
                    type = value.Replace("_", "-");  //////////  <---- This setter replaces the underscore with - so that the program does not append it as a 2 value
                }
                else
                {
                    type = value;
                }
            }
        }

        public string Id
        {
            get { return id; }
            set { if (value.Contains("_")) {
                    id = value.Replace("_", "-");   //////////  <---- This setter replaces the underscore with - so that the program does not append it as a 2 value
                }
                else
                {
                    id = value;
                }
            }
        }

        public string Model
        {
            get { return model; }
            set {
                if (value.Contains("_"))
                {
                    model = value.Replace("_", "-");    //////////  <---- This setter replaces the underscore with - so that the program does not append it as a 2 value
                }
                else
                {
                    model = value;
                }
            }
        }

        public string Brand
        {
            get { return brand; }
            set {
                if (value.Contains("_"))
                {
                    brand = value.Replace("_", "-");    //////////  <---- This setter replaces the underscore with - so that the program does not append it as a 2 value
                }
                else
                {
                    brand = value;
                }
            }
        }

        public string Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
