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

            Console.WriteLine();
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

            //Ülesanne 3

            Console.WriteLine("\nKolmas ülesanne \n ");

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
            float esimeneListArv = esimeneList.Count();
            float esimeneListSum = esimeneList.Sum();
            float esimeneListKeskmine = esimeneListSum / esimeneListArv;


            Console.Write("#4.1 \n");
            Console.WriteLine("Esimese listi keskmine on: " + esimeneListKeskmine);

            // Teine
            float teineListArv = teineList.Count();
            float teineListSum = teineList.Sum();
            float teineListKeskmine = teineListSum / teineListArv;

            Console.Write("#4.2 \n");
            Console.WriteLine("Teise listi keskmine on: " + teineListKeskmine);

            // Kolmas
            float kolmasListArv = kolmasList.Count();
            float kolmasListSum = kolmasList.Sum();
            float kolmasListKeskmine = kolmasListSum / kolmasListArv;

            Console.WriteLine("#5");
            Console.WriteLine("Mõlema listi keskmine on: " + kolmasListKeskmine);

            Console.ReadKey();
        }
    }
}

