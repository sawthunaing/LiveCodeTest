using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateFibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var intitalInt = 0;
            var secondInt = 1;
            var lstInt = new List<int>();
            lstInt.Add(0);
            lstInt.Add(1);
            for (int i = 0; i < 20; i++)
            {
                var result = lstInt[i] + lstInt[i+1];
                lstInt.Add(result);
            }
            Console.Write(lstInt[20]);
            Console.ReadLine();
        }
    }
}
