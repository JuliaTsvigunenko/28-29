using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Tour
    {

        public string Country { get; set; }
        public int Price { get; set; }
        public int Days { get; set; }



        public int TourCalc()
        {
            Console.WriteLine("Минское море, бесплатно");
            return 0;
        }


        public int TourCalc(string country)
        {
            Console.WriteLine($"Поездка в {country}, 1 день, стоимость поездки: 50 рублей");
            return 50;
        }


        public int TourCalc(string country, int days)
        {
            int price = 50 * days;
            Console.WriteLine($"Поездка в {country} на {days} дней, стоимость поездки составляет: {price} рублей");
            return price;
        }


    }
}
