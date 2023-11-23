using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindEndDate
{
    class Program
    {
        static void Main(string[] args)
        {
            var startDt = new DateTime(2023, 11, 1);
            var count = 5;
            var restofdt = startDt;
            var totalDay = (count/2) * 7;

            for (int i = 0; i < totalDay; i++)
            {
                if (restofdt.DayOfWeek == DayOfWeek.Friday)
                    count = count - 1;

                if (restofdt.DayOfWeek == DayOfWeek.Sunday)
                    count = count - 1;

               
                restofdt = restofdt.AddDays(1);

                break;
                

            }
            Console.Write(restofdt);
            Console.ReadLine();

        }
    }
}
