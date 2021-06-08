using System;

namespace MyApplication
{
class Program{
    static void Main(string[] args){
        Console.WriteLine("Enter your first name");
        string name=Console.ReadLine();
        Console.WriteLine("Enter your last name");
        string lname=Console.ReadLine();
        Console.WriteLine("Your full name is "+name+" "+lname);
    }
}
}
