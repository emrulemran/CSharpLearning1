using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsRevise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Method or Function: a verb - to do something. e.g. Print a name
            // a Method or a Function has a name: WriteLine()
            // a Method or a Function must have a pair parentheses at the end
            // Methods or functions that are already present: library functions or built-in functions
            // Main() is a must to run a C# app or program
            // a UDF or a custom function can't be created inside an exisiting function


            Console.WriteLine("california");


            HashSet<string> set = new HashSet<string>();
            set.Add("salmon");
            set.Clear();

            Console.WriteLine(set.Count);



            Program mypg = new Program();

            Console.WriteLine(mypg.MyFullName("Margaret", "H", "thetcher"));




        }


        string MyFullName(string firstName, string mName, string lName)
        {
            return firstName + " " + mName + " " + lName;
        }



    }
}
