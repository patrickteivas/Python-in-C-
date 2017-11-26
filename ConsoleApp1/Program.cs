using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ülesanne 1

            //Console.WriteLine("Sisestage 2 arvu");
            //int FirstInput = int.Parse(Console.ReadLine());
            //int SecondInput = int.Parse(Console.ReadLine());

            //while (FirstInput < SecondInput)
            //{
            //    if (FirstInput % 2 == 0)
            //    {
            //        Console.WriteLine(FirstInput);
            //    }
            //    FirstInput++;
            //}


            //Ülesanne 2

            string filepath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName, "kttekst.txt"); ;

            string failText = File.ReadAllText(filepath); //Text from file to string
            string[] words = failText.Split(' '); //Words to word array
            Console.WriteLine("Sõnu failis: " + words.Length);

            int i = 0;
            foreach (var word in words)
            {
                if (word.Length < 5)
                {
                    i++;
                }
            }
            Console.WriteLine("Väiksemad kui 5 tähte sõnu failis: " + i);

        }
    }
}

