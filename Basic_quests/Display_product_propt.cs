using System;
public class Program{
         public static void Main(string[] args){
            Product p=new Product();
            Console.WriteLine("Enter product id");
            p.ProductId=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter product name");
            p.ProductName=Console.ReadLine();
            Console.WriteLine("Enter product price");
            p.Price=Convert.ToDouble(Console.ReadLine());
            p.Display();

        }
    }
 public class Product{
        private int productId;
        private string productName;
        private double price;
        public int ProductId{
            get{
                return productId;
            }
            set{
                productId=value;
            }
        }
        public string ProductName{
            get{
                return productName;
            }
            set{
                productName=value;
            }
        }
        public double Price{
            get{
                return price;
            }
            set{
                if(value>0){
                price=value;}
                else
                price=0;
            }
        }
        public void Display(){
            Console.WriteLine("Product ID: "+ProductId);
            Console.WriteLine("Product Name: "+ProductName);
            Console.WriteLine("Product Price:"+Price);
        }
       
    }
