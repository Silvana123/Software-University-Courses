using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var car = 0;
            var microbus = 0;
            var bus = 0;
            var bigBus = 0;
            var train = 0;
            var totalPeople = 0;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num<=5)
                {
                    car += num;
                    totalPeople += num;
                }
                else if (num>=6 && num <=12)
                {
                    microbus += num;
                    totalPeople += num;
                }
                else if (num>=13 && num <=25)
                {
                    bus += num;
                    totalPeople += num;
                }
                else if (num>=26 && num<=40)
                {
                    bigBus += num;
                    totalPeople += num;
                }
                else if (num>=41)
                {
                    train += num;
                    totalPeople += num;
                }
            }

            var carPercent = (car  * 100.00) / totalPeople;
            var microbusPercent = (microbus * 100.00) / totalPeople;
            var busPercent = (bus * 100.00) / totalPeople;
            var bigBusPercent = (bigBus * 100.00) / totalPeople;
            var trainPercent = (train * 100.00) / totalPeople;



            Console.WriteLine($"{carPercent:f2}%");
            Console.WriteLine($"{microbusPercent:f2}%");
            Console.WriteLine($"{busPercent:f2}%");
            Console.WriteLine($"{bigBusPercent:f2}%");
            Console.WriteLine($"{trainPercent:f2}%");

        }
    }
}
