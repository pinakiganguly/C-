using System;

namespace MyApplication{
    class correct{
        static void Main(string[] args){
            int x,y;
            string x1,y1;
            bool result=true;
            //bool f=false;
            Console.WriteLine("Enter the value for x");
            x1=Console.ReadLine();
            x=Convert.ToInt32(x1);
            Console.WriteLine("Enter the value for y");
            y1=Console.ReadLine();
            y=Convert.ToInt32(y1);
            if(x<y){
                Console.WriteLine("x is less than y is "+result);
            }
           /* else{
                Console.WriteLine("y is less than x is")
            }*/
        }
    }
}
