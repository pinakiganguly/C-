using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgFundamentals9             //DO NOT CHANGE the name of namespace
{
    public class Program                //DO NOT CHANGE the name of class 'Program'
    {
        public static void Main(string[] args)      //DO NOT CHANGE 'Main' Signature
        {
           
           // Fill the code here
           Console.WriteLine("Enter Name:");
           string name1=Console.ReadLine();
           Console.WriteLine("Enter Place:");
           string place1=Console.ReadLine();
           Console.WriteLine("Enter marital status(y/n):");
           char married1=Console.ReadLine()[0];
           Console.WriteLine("Do you wish to continue(y/n):");
           char continue1=Console.ReadLine()[0];
           
           if(continue1== 'y'){
               Console.WriteLine("Enter Name:");
               string name2=Console.ReadLine();
               Console.WriteLine("Enter Place:");
               string place2=Console.ReadLine();
               Console.WriteLine("Enter marital status(y/n):");
               char married2=Console.ReadLine()[0];
               Console.WriteLine("Do you wish to continue(y/n):");
               char continue2=Console.ReadLine()[0];
               
               
               Console.WriteLine("Confirming Information\n"+name1+"\n"+place1+"\n"+"Married:"+married1);
               
               Console.WriteLine("Confirming Information\n"+name2+"\n"+place2+"\n"+"Married:"+married2);
           }
           else{
               Console.WriteLine("Confirming Information\n"+name1+"\n"+place1+"\n"+"Married:"+married1);
           }
        }
    }
}
