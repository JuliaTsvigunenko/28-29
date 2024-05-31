using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Tovar
    {

        private string name;
        private int price;
        private int kvo;

        public string Name { get { return name; } set { name = value; } }

        public int Price
        {
            get { return price; }
            set
            {
                if (value >= 1 && value <= 20)
                    price = value;
                else
                    Console.WriteLine("Ошибка: Цена должна быть от 1 до 20");
            }
        }

        public int Kvo
        {
            get { return kvo; }
            set
            {
                if (value >= 0 && value <= 10)
                    kvo = value;
                else
                    Console.WriteLine("Ошибка: Количество должно быть от 0 до 10");
            }
        }


        public int CalculateTotalCost()
        {
            return price * kvo;
        }


        /// <summary>
        /// Без параметров конструктор
        /// </summary>
        public Tovar() { }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="name">название</param>
        /// <param name="price">цена</param>
        /// <param name="kvo">кол-во</param>
        public Tovar(string name, int price, int kvo)
        {
            this.Name = name;
            this.Price = price;
            this.Kvo = kvo;
        }

        








    }
}
