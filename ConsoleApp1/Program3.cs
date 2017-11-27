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

            Console.WriteLine("\nKolmas ülesanne \n ");
            
            List<float> esimeneList = new List<float>() { 11, 15, 6, 13, 13, 25, 32, 11, 20, 5, 31, 16, 32, 29, 11, 13, 3, 29, 28, 24 };
            List<float> teineList = new List<float>() { 5, 19, 16, 4, 12, 7, 2, 28, 34, 29, 29, 36, 6, 8, 24, 18, 31, 7, 1, 70 };

            Console.WriteLine("#1");
            Console.Write("Sarnased elemendid on: ");

            foreach(int i in esimeneList.Intersect(teineList))
            {
                Console.Write(i + ", ");
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
