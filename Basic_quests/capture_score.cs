using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Score            //DO NOT CHANGE the name of namespace
{
    public class Program                //DO NOT CHANGE the name of class 'Program'
    {
        public static void Main(string[] args)   //DO NOT CHANGE 'Main' Signature
        {
            //Implement code here
            
            string[] arr=new string[6];
            for(int i=0;i<arr.Length;i++){
                Console.Write("Player Name:");
                arr[i]=Console.ReadLine();
            }
            int Score1=0,Score2=0,Score3=0;
            for(int i=0;i<arr.Length;i++){
                if(arr[i]=="Daisy"){
                    if(i!=arr.Length-1 && arr[i+1]=="Daisy"){
                        Score1+=3;
                        i++;
                    }
                    else{
                        Score1+=1;
                    }
                }
                else if(arr[i]=="Bill"){
                    if(i!=arr.Length-1 && arr[i+1]=="Bill"){
                        Score2+=3;
                        i++;
                    }
                    else{
                        Score2+=1;
                    }
                }
                else if(arr[i]=="Tommy"){
                    if(i!=arr.Length-1 && arr[i+1]=="Tommy"){
                        Score3+=3;
                        i++;
                    }
                    else{
                        Score3+=1;
                    }
                }
                else
                    continue;
            }
            Console.WriteLine("Bill Score:"+Score2);
            Console.WriteLine("Tommy Score:"+Score3);
            Console.WriteLine("Daisy Score:"+Score1);
        }
    }
}
