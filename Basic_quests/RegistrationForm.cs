using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgFundamentals1             //DO NOT CHANGE the name of namespace
{
    public class Program                //DO NOT CHANGE the name of class 'Program'
    { 
        public static void Main(string[] args)        //DO NOT CHANGE 'Main' Signature
        {
            //Fill the code here
            string name,country;
            int age;
            Console.WriteLine("Enter your name: ");
            name=Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            age=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter your country: ");
            country=Console.ReadLine();
            Console.WriteLine("Welcome "+name+". Your age is "+age+" and you are from "+country);
        }
    }
}
