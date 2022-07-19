using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {

        List<string> names = new List<string>();
            names.Add("Billal");
            names.Add("Zaman");
            names.Add("Sarowar");
            names.Add("Kayes");
            names.Add("Atik");
            names.Add("Armel");
            names.Add("Akter");
            names.Add("Kayes");
            names.Add("Bashiur");
            names.Add("Mitu");

            Console.WriteLine(names[1]);

            Console.WriteLine(String.Join(", ", names));


        }
    }
}
