using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgFundamentals5              //DO NOT CHANGE the name of namespace
{
    public class Program                //DO NOT CHANGE the name of class 'Program'
    {
        static void grade(int mark,string sub){
            if(mark>=80 && mark<=100){
                Console.WriteLine(sub+" Grade : A+");
            }
            else if(mark>=60 && mark<80){
                Console.WriteLine(sub+" Grade : A");
            }
            else if(mark>=40 && mark<60){
                Console.WriteLine(sub+" Grade : B");
            }
            else if(mark<40){
                Console.WriteLine(sub+" Grade : FAIL");
            }
        }
        public static void Main(string[] args)        //DO NOT CHANGE 'Main' Signature
        {
            //Implement your code here
            int marks1,marks2,marks3;
            Console.WriteLine("Enter English marks:");
            marks1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Math marks:");
            marks2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Language marks:");
            marks3=Convert.ToInt32(Console.ReadLine());
            if(marks1<0 || marks2<0 || marks3<0){
                Console.WriteLine("Mark cannot be less than 0");
            }
            else{
                grade(marks1,"English");
                grade(marks2,"Math");
                grade(marks3,"Language");
            }
        }
    }
}
