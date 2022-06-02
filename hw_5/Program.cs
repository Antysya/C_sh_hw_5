using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace hw_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dairy_products[] dairy_Products =
            {
                new Dairy_products("Вологодское", 199.30, new DateTime(2022, 02, 05), Type.Масло),
                new Dairy_products("Домик в деревне", 105, new DateTime(2022, 12, 30), Type.Молоко),
                new Dairy_products("Вологодское", 199.30, new DateTime(2022, 08, 20), Type.Масло),
                new Dairy_products("Вкуснотеево. Йогурт персиковый", 85, new DateTime(2022, 11, 18), Type.Йогурты),
            };

            Chemicals[] chemicals =
            {
                new Chemicals("Золотые локоны", 415, TypeCh.Шампунь),
                new Chemicals("Сверкающая улыбка", 112, TypeCh.Зубная_Паста),
                new Chemicals("Душистое", 18, TypeCh.Мыло),
                new Chemicals("Чистота", 86, TypeCh.Стиральный_Порошок),
                new Chemicals("Душистое", 18, TypeCh.Мыло),
                new Chemicals("Сверкающая улыбка", 112, TypeCh.Зубная_Паста),
                new Chemicals("Сверкающая улыбка", 112, TypeCh.Зубная_Паста)
            };

            while (true)
            {
                WriteLine("Магазин. Вы можете посмотреть следующую информацию о товарах в магазине:\n " +
                    "1. Все товары; \n 2. Продукты питания;\n " +
                    "3. Бытовая химия;\n 4. Товары, которые необходимо списать по сроку годности;\n " +
                    "5. Стоимость продуктов питания;\n 6. Стоимость бытовой химии.\n 7. Выйти из программы. \n Какой пункт Вас интересует?");
                string posnum = ReadLine();

                switch (posnum)
                {
                    case "1":
                        {
                            WriteLine("Ассортимент магазина:\n");
                            foreach (Dairy_products item in dairy_Products)
                            {
                                WriteLine(item);
                            };
                            foreach (Chemicals item in chemicals)
                            {
                                WriteLine(item);
                            }
                            WriteLine();
                        }

                        break;

                    case "2":
                        {
                            WriteLine("Ассортимент продуктов питания:\n");
                            foreach (Dairy_products item in dairy_Products)
                            {
                                WriteLine(item);
                            }
                            WriteLine();
                        }
                        break;

                    case "3":
                        {
                            WriteLine("Ассортимент бытовой химии:\n");
                            foreach (Chemicals item in chemicals)
                            {
                                WriteLine(item);
                            }
                            WriteLine();
                        }
                        break;

                    case "4":
                        {
                            WriteLine("Необходимо списать:\n");
                            foreach (Dairy_products item in dairy_Products)
                            {
                                item.WriteDowns();
                            }
                            WriteLine();
                        }
                        break;

                    case "5":
                        return;

                    default:
                        WriteLine("Вы выбрали несуществующий пункт меню. Выберите снова.");
                        continue;
                }
            }
        }
    }
}
