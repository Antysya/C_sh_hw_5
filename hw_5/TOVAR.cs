using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace hw_5
{
    public abstract class TOVAR
    {
        string name { get; set; }
        double price { get; set; }
     
        public double Price { get; set; }

        //public TOVAR() { }
        public TOVAR (string _name, double _price)
        {
            name = _name;
            price = _price;
        }

        public override string ToString()
        {
            return $"{name} {price}";
        }

        public abstract void WriteDowns();

    }
}
