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
            Console.WriteLine("Sisestage 2 arvu");
            int FirstInput = int.Parse(Console.ReadLine());
            int SecondInput = int.Parse(Console.ReadLine());
            
            while (FirstInput < SecondInput)
            {
                if (FirstInput % 2 == 0)
                {
                    Console.WriteLine(FirstInput);
                }
                FirstInput++;
            }
        }
    }
}
