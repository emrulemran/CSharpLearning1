using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesDemo
{
   


    public class BritishAge: MedievalAge
    {
        public static int number1 = 10;
        public static string british = "during medieval times, people used guns as weapons";

    }
    public class MedievalAge: AncientAge
    {
        public static string medieval = "during medieval times, people used archbows and sword as weapons";

    }
    public class AncientAge
    {
        public static string ancient = "during ancient times, people used stone as weapons"; 
    }


    public class Program : BritishAge {

        Program pg = new Program();
        pg.

}

}
