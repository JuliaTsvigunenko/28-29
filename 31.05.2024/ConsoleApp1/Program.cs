using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Tour tour = new Tour();
            int price = tour.TourCalc();
            int price2 = tour.TourCalc("Албания");
            int price3 = tour.TourCalc("Германия", 5);

            Console.ReadKey();
        }
    }
}
