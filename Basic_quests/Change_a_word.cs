using System;
namespace MyAppl{
    class program{
        public static void Main(string[] args){
            string str;
            Console.WriteLine("Enter a string");
            str=Console.ReadLine();
            if(str.Contains("the")!=true){
                Console.WriteLine("Word 'the' not found");
            }
            else{
                str=str.Replace("the","that");
                Console.WriteLine(str);
            }
            
        }
    }
}
