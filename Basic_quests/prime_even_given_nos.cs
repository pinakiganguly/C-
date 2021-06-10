using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgFundamentals8               //DO NOT CHANGE the name of namespace
{
    public class Program                  //DO NOT CHANGE the name of class 'Program'
    { 
        public static void Main(string[] args)      //DO NOT CHANGE 'Main' Signature
        {
           
           // Fill the code here
           int fno;
           int count=0;
           //n=fno+10;
           Console.Write("Enter starting number : ");
           fno=Convert.ToInt32(Console.ReadLine());
           //n=fno+20;
           for(int i=fno+1;count<10;i++){
              if(i%2==0){
                   Console.Write(i+" ");
                    count++;
              }
           }
        }
    }
}
