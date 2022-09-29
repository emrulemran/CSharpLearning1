using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{    class ClassTwo
    {

        
        public static string output = "";
        public static void Main(String[] args)
        {

            ClassTwo ct = new ClassTwo();

            List<string> names = new List<string>() {"rosalita", "ann", "rosa", "marie","juan", "jose"};
           

            Console.WriteLine(ct.sortNamesReversely(names));

        }
   
        string[] sortNamesReversely(List<string> input)
        {
        input.Reverse();
        string [] outputNames = input.ToArray<string>();
        return outputNames;
        }

      
    }
}

