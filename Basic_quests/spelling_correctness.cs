using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgFundamentals3             //DO NOT CHANGE the name of namespace
{
    public class Program                 //DO NOT CHANGE the name of class 'Program'
    {
        public static void Main(string[] args)       //DO NOT CHANGE 'Main' Signature
        {
           
           //Fill the code here
           string[] arr=new string[10];
           string[] arr1=new string[] {"c","a","s","a","b","l","a","n","c","a"};
           for(int i=0;i<10;i++){
               Console.WriteLine("Enter letter {0}:",i+1);
               arr[i]=Console.ReadLine();
           }
           for(int i=0;i<10;i++){
               Console.WriteLine("Enter letter {0}:{1}",i+1,arr[i]);
               if(arr[i]!=arr1[i]){
                   Console.WriteLine("The spelling is wrong");
               }
           }
        }
    }
}
