//Implement code here
using System;
public class Account{
    private int id;
    private string accountType;
    private double balance;
    public Account(){}
    public Account(int i,string type, double bal){
        Id=i;
        AccountType=type;
        Balance=bal;
    }
    public int Id{
        set{
            id=value;
        }
        get{
        return id;}
    }
    public string AccountType{
        set{
            accountType=value;
        }
        get{
            return accountType;
        }
    }
    public double Balance{
        set{
            if(value>0)
            balance=value;
            else
            balance=0;
        }
        get{
            return balance;
        }
        
    }
    public bool WithDraw(double amount){
        if(amount<=Balance){
            Balance=Balance-amount;
            return true;
        }
        return false;
    }
    public string GetDetails(){
        return this.accountType;
    }
}
public class Program{
    public static void Main(string [] args){
       int x;string t;
       double bl;
       Console.WriteLine("Enter account id");
       x=Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Enter account type");
       t=Console.ReadLine();
       Console.WriteLine("Enter account balance");
       bl=Convert.ToDouble(Console.ReadLine());
       Account ob=new Account(x,t,bl);
       Console.WriteLine("Account Id: "+ob.Id);
        Console.WriteLine("Account Type: "+ob.GetDetails());
        Console.WriteLine("Balance: "+ob.Balance);
    }
}
