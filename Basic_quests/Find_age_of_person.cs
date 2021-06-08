using System;
using System.IO;
using System.Globalization;
public class Person
{
    //Fill code here
    private string firstName;
    private string lastName;
    private DateTime dob;
 
    public string FirstName{
        get{
            return firstName;
        }
        set{
            firstName=value;
        }
    }
    public string LastName{
        get{
            return lastName;
        }
        set{
            lastName=value;
        }
    }
    public DateTime Dob{
        set{
            dob=value;
        }
        get{
            return dob;
        }
    }
    public string Adult{
        
        get{
          
            if(GetAge(Dob)>=18){
                return "Adult";
            }
            else
                return "Child";
        
        }
        set{}
    }
    public void DisplayDetails(){
        Console.WriteLine("First Name: "+FirstName+"\nLast Name: "+LastName+"\nAge: "+GetAge(Dob)+"\n"+Adult);
    }
    public int GetAge(DateTime dob){
            int age=DateTime.Now.Year-dob.Year;
            if(DateTime.Now.DayOfYear<dob.DayOfYear){
                age--;}  
        return age;
    }
   
}

public class Progarm
{
    public static void Main(string[] args)
    {
        //Fill code here
        Console.WriteLine("Enter first name");
        string FirstName=Console.ReadLine();
        Console.WriteLine("Enter last name");
        string LastName=Console.ReadLine();
        Console.WriteLine("Enter date of birth in yyyy/mm/dd format");
        DateTime dob=DateTime.Parse(Console.ReadLine());
        Person p1=new Person();
        p1.FirstName=FirstName;
        p1.LastName=LastName;
        p1.Dob=dob;
        p1.DisplayDetails();
    }
}
