using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgFundamentals7                 //DO NOT CHANGE the name of namespace
{
    public class Program                    //DO NOT CHANGE the name of class 'Program'
    {
        public static void Main(string[] args)      //DO NOT CHANGE 'Main' Signature
        {
            //Implement your code here
            Console.WriteLine("Enter the name of the product:");
            string product=Console.ReadLine();
            Console.WriteLine("Enter the price of the product:");
            double price=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Is the product on SALE(yes/no):");
            string sale=Console.ReadLine();
            Console.WriteLine("Enter number of product sold in day 1");
            int day1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of product sold in day 2");
            int day2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of product sold in day 3");
            int day3=Convert.ToInt32(Console.ReadLine());
            
            // int day1Total=price-(price*0.07);
            // int day2Total=day1Total-(day1Total*0.07);
            // int day3Total=day2Total-(day2Total*0.07);
            if(sale=="yes"){
                double day1Total=price-(price*0.07);
                double day2Total=day1Total-(day1Total*0.07);
                double day3Total=day2Total-(day2Total*0.07);
                Console.WriteLine(product);
                Console.WriteLine("Day 1 sales total:"+(day1Total*day1));
                Console.WriteLine("Day 2 sales total:"+(day2Total*day2));
                Console.WriteLine("Day 3 sales total:"+(day3Total*day3));
                
            }
            else{
                double day1Total=price;
                double day2Total=day1Total;
                double day3Total=day2Total;
                Console.WriteLine(product);
                Console.WriteLine("Day 1 sales total:"+(day1Total*day1));
                Console.WriteLine("Day 2 sales total:"+(day2Total*day2));
                Console.WriteLine("Day 3 sales total:"+(day3Total*day3));
            }
        }
    }
}
