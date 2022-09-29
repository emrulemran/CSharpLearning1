using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevel
{    
    public class GreatGrandFather
    {
        public static string rank = "king";
    }

    public class GrandFather: GreatGrandFather // // parent class, super class, base class (source)
    {
        public static string Title = "chowdhury";
        public static double networth = 34544656.99;
    }

    public class Father : GrandFather    // child class, sub class, dervide class (destination)
    {
    public static void Main(String[] args)
        {
            Console.WriteLine(Father.networth);
            Console.WriteLine(Father.Title);
            Console.WriteLine(Father.rank);
        }
    }
}
