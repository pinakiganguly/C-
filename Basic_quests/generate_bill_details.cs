using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgFundamentals2           //DO NOT Change namespace name
{
    public class Program              //DO NOT Change class 'Program' name
    {
        public static void Main(string[] args)    //DO NOT Change 'Main' method Signature
        {
            //Implement your code here
            int nopizzas,nopuffs,nopepsis;
            int cpizzas,cpuffs,cpepsis,total;
            float GST,CESS;
            Console.Write("ENter the number of pizzas bought : ");
            nopizzas=Convert.ToInt32(Console.ReadLine());
            Console.Write("ENter the number of puffs bought : ");
            nopuffs=Convert.ToInt32(Console.ReadLine());
            Console.Write("ENter the number of pepsi bought : ");
            nopepsis=Int32.Parse(Console.ReadLine());
            //if(nopizzas>0 || nopepsis>0 || nopuffs>0){
                cpizzas=200*nopizzas;
                cpepsis=120*nopepsis;
                cpuffs=40*nopuffs;
                total=cpizzas+cpepsis+cpuffs;
                GST=0.12f*total;
                CESS=0.05f*total;
                Console.WriteLine("Bill Details"+"\n");
                Console.WriteLine("Cost of pizzas :"+cpizzas);
                Console.WriteLine("Cost of Puffs :"+cpuffs);
                Console.WriteLine("Cost of Pepsis :"+cpepsis);
                Console.WriteLine("GST 12% :"+GST);
                Console.WriteLine("CESS 5% :"+CESS);
                Console.WriteLine("Total Price :"+total);
            //}
            //else{
                //Console.WriteLine("User Inputs is NOT correct");
            //}
        }
    }
}
