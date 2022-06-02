using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace hw_5
{
    enum Type
    {
        Молоко,
        Йогурты,
        Масло
    }
    class Dairy_products : Foods
    {
        Type type;

        public Dairy_products(string _name, double _price, DateTime _expirationDate, Type _type)
            : base(_name, _price, _expirationDate)
        { 
            type = _type; 
        }

        public override string ToString()
        {
            return $"{type} {base.ToString()} ";
        }
    }
}
