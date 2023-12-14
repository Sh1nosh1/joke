using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T13_1
{
    class Phone
    {
        /// <summary>
        /// Phone's manufacturer
        /// </summary>
        public string manufacturer;
        /// <summary>
        /// Phone's model
        /// </summary>
        public string model;
        /// <summary>
        /// Phone's price
        /// </summary>
        public double price;
        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public Phone () { }
        /// <summary>
        /// Constructor with two parameters
        /// </summary>
        /// <param name="manufacturer"></param>
        /// <param name="model"></param>
        public Phone (string manufacturer, string model)
        {
            this.manufacturer = manufacturer; this.model = model;
        }
        /// <summary>
        /// Constructor +1 parameter
        /// </summary>
        /// <param name="manufacturer"></param>
        /// <param name="model"></param>
        /// <param name="price"></param>
        public Phone (string manufacturer, string model, double price) : this(manufacturer, model)
        {
            this.price = price;
        }
        /// <summary>
        /// Output
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Manufacturer: {manufacturer}\nModel: {model}\nPrice: {price} $\n";
        }
    }
}
