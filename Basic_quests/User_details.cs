using System;

namespace MyAppl{
    class perinfo{
        static void Main(string[] args){
            string name,city;
            char gender;
            string mob_no,pin;
            float age;
            Console.WriteLine("Enter name");
            name=Console.ReadLine();
            Console.WriteLine("Enter age(completed years and months)");
           // m=Console.ReadLine();
            age=float.Parse(Console.ReadLine());
            Console.WriteLine("Enter gender('M' for Male and 'F' for Female)");
            gender=Console.ReadLine()[0];
            Console.WriteLine("Enter city");
            city=Console.ReadLine();
            Console.WriteLine("Enter mobile number");
            //m=Console.ReadLine();
            mob_no=Console.ReadLine();
            Console.WriteLine("Enter pincode");
            //m=Console.ReadLine();
            pin=Console.ReadLine();
            Console.WriteLine("Name:"+" "+name);
            Console.WriteLine("Age:"+" "+age);
            Console.WriteLine("Gender:"+" "+gender);
            Console.WriteLine("City:"+" "+city);
            Console.WriteLine("Mobile:"+" "+" "+mob_no);
            Console.WriteLine("Pincode:"+" "+pin);
        }
    }
}
