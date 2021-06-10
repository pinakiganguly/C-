using System;
namespace MyAppl{
    class program{
        public static void Main(string[] args){
            string lname,fname;
            Console.WriteLine("Enter first name");
            fname=Console.ReadLine();
            Console.WriteLine("Enter last name");
            lname=Console.ReadLine();
            Console.WriteLine("Full name: "+fname+" "+lname);
        }
    }
}
