using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgFundamentals4              //DO NOT CHANGE the name of namespace
{
    public class Program                 //DO NOT CHANGE the name of class 'Program'
    {
        public static void Main(string[] args)   //DO NOT CHANGE 'Main' Signature
        {
            string alpha;
            int repeats,rows,space,k=0;
            Console.WriteLine("Enter any alphabet : ");
            //Get the value
            alpha=Console.ReadLine();
            Console.WriteLine("Enter number of repeats : ");
            //Get the value
            repeats=Int32.Parse(Console.ReadLine());
            //Implement your code here
            if(repeats%2!=0){
                rows=(repeats+1)/2;
                for(int i=1;i<=rows;++i,k=0){
                    for(space=1;space<=rows-i;++space){
                        Console.Write(" ");
                    }
                    while(k!=2*i-1){
                        Console.Write(alpha);
                        ++k;
                    }
                    Console.Write("\n");
                }
            }

        }
    }
}
