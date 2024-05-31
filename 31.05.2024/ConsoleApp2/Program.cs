using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {


            Tovar tovar1 = new Tovar();
            tovar1.Name = "Бананы";
            tovar1.Price = 15;
            tovar1.Kvo = 2;


            Tovar tovar2 = new Tovar();
            tovar2.Name = "Дыня";
            tovar2.Price = 15;
            tovar2.Kvo = 2;


            int Cost = tovar1 + tovar2;
            Console.WriteLine($"Общая стоимость заказа: {Cost} руб.");













        }
    }
}
