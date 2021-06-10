using System;

public class Program   //DO NOT change the class name
{
    static void Main(string[] args)       //DO NOT change the 'Main' method signature
    {
        //Fill code here
        Console.WriteLine("Enter a number");
        int num=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(GetArray(num));
    }
    
    public static int[,]  GetArray(int num)
    {
        //Fill code here 
        int[,] arr=new int[num,num];
        for(int i=0;i<num;i++){
            for(int j=0;j<num;j++){
                if(i==j){
                    arr[i,j]=0;
                }
                else if(i>j){
                    arr[i,j]=-1;
                }
                else{
                    arr[i,j]=1;
                }
            }
            //return arr;
        }
        return arr;
    }
}    
    
