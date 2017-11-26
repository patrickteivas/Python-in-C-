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
            Console.WriteLine(filepath);

            

            StreamReader streamReader = new StreamReader(filepath); //get the file
            string stringWithMultipleSpaces = streamReader.ReadToEnd(); //load file to string
            streamReader.Close();

            Regex r = new Regex(" +"); //specify delimiter (spaces)
            string[] words = r.Split(stringWithMultipleSpaces); //(convert string to array of words)



            foreach (String W in words)
            {
                List<int> PalunTapkeMind = new List<int>();
                PalunTapkeMind.Add(1);
                
                //...
                
                Console.WriteLine(PalunTapkeMind);
            }



        }
    }
}
