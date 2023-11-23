using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OccurrencesOfGivenDay
{
    class Program
    {
        static void Main(string[] args)
        {
            var startDt = new DateTime(2023, 10, 20);
            var endDt = new DateTime(2023, 11, 5); ;
            var restofdt = startDt;
            var result = 0;

            for (int i = startDt.DayOfYear; i < endDt.DayOfYear; i++)
            {

                if (restofdt.DayOfWeek == DayOfWeek.Monday)
                    result++;

                if (restofdt.DayOfWeek == DayOfWeek.Tuesday)
                    result++;
                if (restofdt.DayOfWeek == DayOfWeek.Saturday)
                    result++;

                restofdt = restofdt.AddDays(1);

            }
            Console.Write(result);
            Console.ReadLine();

        }
    }
}
