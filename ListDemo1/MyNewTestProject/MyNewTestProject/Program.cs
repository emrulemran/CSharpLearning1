using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewTestProject
{


class OurClass
    {
        public static void Main(String[] args)
        {

        string city = "new york";
        string cityName = city.ToString();
        Console.WriteLine(cityName);
        Console.WriteLine(cityName.GetType());

            char[] characterArray = { 'O', 'N', 'A', 'M', 'I', 'C', 'A' };
            string word = new string(characterArray);
            Console.WriteLine(word);

        }
    }

}



