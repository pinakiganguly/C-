using System;
namespace MyAppl{
    class program{
        public static void Main(string[] args){
            string s;
            //string[] str1=new string[20];
            Console.WriteLine("Enter a string");
            s=Console.ReadLine();
            string[] str=s.Split(' ');
            string rev=String.Empty;
            for(int i=str.Length-1;i>=0;i--){
                rev+=str[i];
                rev+=" ";
            }
            Console.Write(rev);
        }
    }
}
