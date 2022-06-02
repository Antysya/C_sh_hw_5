using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace hw_5
{
    class Foods : TOVAR
    {
        DateTime expirationDate;

        public Foods(string _name, double _price, DateTime _expirationDate)
            : base(_name, _price)
        {
            expirationDate = _expirationDate;
        }

        public override string ToString()
        {
            return $"{base.ToString()} {expirationDate.ToShortDateString()} ";
        }

        public override void WriteDowns() //списание товара
        {
            if (expirationDate < DateTime.Today)
            WriteLine($"{ToString()}");

        }
    }
}
