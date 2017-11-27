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

            Console.WriteLine("\nEsimene Ülesanne \n");

            Console.WriteLine("Sisestage 2 arvu");
            int FirstInput = int.Parse(Console.ReadLine());
            int SecondInput = int.Parse(Console.ReadLine());

            if(FirstInput > SecondInput)
            {
                int temp = SecondInput;
                SecondInput = FirstInput;
                FirstInput = temp;
            }

            Console.WriteLine("Nende kahe arvu vahele jäävad paarisarvud:");
            while (FirstInput < SecondInput)
            {
                if (FirstInput % 2 == 0)
                {
                    Console.WriteLine(FirstInput);
                }
                FirstInput++;
            }

            Console.WriteLine("\nPress any key to continue!");
            Console.ReadKey();

            //Ülesanne 2

            Console.WriteLine("\n\nTeine Ülesanne \n");

            string filepath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName, "kttekst.txt"); ;

            string failText = File.ReadAllText(filepath); //Text from file to string
            string[] words = failText.Split(' '); //Words to word array

            Console.WriteLine("#1");
            Console.WriteLine("Sõnu failis: " + words.Length);

            int i = 0;
            foreach (var word in words)
            {
                if (word.Length < 5)
                {
                    i++;
                }
            }

            Console.WriteLine("#2");
            Console.WriteLine("Väiksemad kui 5 tähte sõnu failis: " + i);

            Console.WriteLine("\nPress any key to continue!");
            Console.ReadKey();

            //Ülesanne 3

            Console.WriteLine("\n\nKolmas Ülesanne \n ");

            List<float> esimeneList = new List<float>() { 11, 15, 6, 13, 13, 25, 32, 11, 20, 5, 31, 16, 32, 29, 11, 13, 3, 29, 28, 24 };
            List<float> teineList = new List<float>() { 5, 19, 16, 4, 12, 7, 2, 28, 34, 29, 29, 36, 6, 8, 24, 18, 31, 7, 1, 70 };

            Console.WriteLine("#1");
            Console.Write("Sarnased elemendid on: ");

            foreach (int b in esimeneList.Intersect(teineList))
            {
                Console.Write(b + ", ");
            }

            var kolmasList = esimeneList.Concat(teineList); // esimeneList + teineList = kolmasList

            Console.WriteLine(); // Selleks, et #2 oleks jargmisel real
            Console.WriteLine("#2");
            float kolmasMax = kolmasList.Max();
            Console.WriteLine("Kahe listi suurim arv on: " + kolmasMax);

            Console.WriteLine("#3");
            float kolmasMin = kolmasList.Min();
            Console.WriteLine("Kahe listi väikseim on: " + kolmasMin);

            // Esimene
            float esimeneListKeskmine = esimeneList.Sum() / esimeneList.Count();


            Console.Write("#4.1 \n");
            Console.WriteLine("Esimese listi keskmine on: " + esimeneListKeskmine);

            // Teine
            float teineListKeskmine = teineList.Sum() / teineList.Count();

            Console.Write("#4.2 \n");
            Console.WriteLine("Teise listi keskmine on: " + teineListKeskmine);

            // Kolmas
            float kolmasListKeskmine = kolmasList.Sum() / kolmasList.Count();

            Console.WriteLine("#5");
            Console.WriteLine("Mõlema listi keskmine on: " + kolmasListKeskmine);

            Console.ReadKey();
        }
    }
}

