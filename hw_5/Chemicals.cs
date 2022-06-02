using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace hw_5
{
    enum TypeCh
    {
        Шампунь,
        Мыло,
        Стиральный_Порошок,
        Зубная_Паста
    }
    class Chemicals : TOVAR
    {
        TypeCh typeCh;

        public Chemicals(string _name, double _price, TypeCh _typeCh)
            : base(_name, _price)
        {
            typeCh = _typeCh;
        }

        public override string ToString()
        {
            return $"{typeCh} {base.ToString()} ";
        }

        public override void WriteDowns() {}

    }
}
