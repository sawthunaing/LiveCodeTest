using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var originalText = "Welcome to Codigo";
            char[] originalTextArr = originalText.ToCharArray();

            for (int i = 1; i <= originalTextArr.Length; i++)
            {
                Console.Write(originalTextArr[originalTextArr.Length - i]);
               
            }
            Console.ReadLine();
        }
    }
}
