using System;
public class CalculatorProgram{
    public int Addition(int a,int b){
        return  a+b;
    }
    public int Subtraction(int a,int b){
        return a-b;
    }
    public int Multiplication(int a ,int b){
        return a*b;
    }
    public double Division(int  a,int  b,out double remainder){
       remainder=a%b;
       return a/b;
    }
}
public class Program{
    public static void Main(string []args){
        CalculatorProgram ob=new CalculatorProgram();
        char ch;
        Console.WriteLine("Enter the operator");
        ch=Console.ReadKey().KeyChar;
        int a,b;
        Console.WriteLine("Enter the operands");
        a=Convert.ToInt32(Console.ReadLine());
        b=Convert.ToInt32(Console.ReadLine());
        
        if(ch=='+'){
            Console.WriteLine("Result of "+a+" + "+b+" is "+ob.Addition(a,b));
        }
        else if(ch=='*'){
            Console.WriteLine("Result of "+a+" * "+b+" is "+ob.Multiplication(a,b));
        }
        else if(ch=='-'){
            Console.WriteLine("Result of "+a+" - "+b+" is "+ob.Subtraction(a,b));
        }
        else if(ch=='/'){
             double r=0.0;
             double d=ob.Division(a,b,out r);
              Console.WriteLine("Result of "+a+" / "+b+" is "+d);
              Console.WriteLine("Remainder : {0}",r);
        }
        else{
            Console.WriteLine("Invalid operator");
        }
    }
}
