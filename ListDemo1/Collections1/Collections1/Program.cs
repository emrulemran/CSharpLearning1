using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections1
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, there!");   // WriteLine is a function (method), for a function () is a must,  Consele is a Class
            string name = "boston";
            Console.WriteLine(name.Length);     // Length is a Property and doesn't have a pair of parentheses ()
            MyClass mc = new MyClass();
            Console.WriteLine(mc.number);
            Dog dog = new Dog();     // Dog is the class name, dog is the object name, = assignment operator
                                     // Dog() is the class constructor - NOT a funtion (or method)
        }
    }


    public class MyClass
    {
        public string desc = "I am a string variable inside MyClass";

       public int number = 100;
    }

    class Dog
    {
        public string puppy = "labrador";
    }

}
