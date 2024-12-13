#nullable enable
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using classes;
namespace test2
{   public interface IShape
    {
        public int Area { get; }
        public void Draw();
    }
    public class Rectangle : IShape
    {
        //int Area { get; }

        int IShape.Area { get; }

        void Draw()
        {
           
        }

        void IShape.Draw()
        {
            throw new NotImplementedException();
        }
    }
    public class Parent
    {
        public int x; public int y;
        public Parent(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        public virtual void Product()
        {
            Console.WriteLine(x + " " + y + " " );
        }
        public override string ToString()
        {
            return $"x = {x} y= {y} ";
        }
    }
    public class child:Parent
    {
        public int z;
        public child(int x,int y,int z):base(x,y)
        {
            this.z = z;
        }
        //public new void Product()
        //{
        //    Console.WriteLine(x + " " + y+" "+z);
        //}
        public override void Product()
        {
            Console.WriteLine(x + " " + y + " " + z); 
        }
        public override string ToString()
        {
            return $"x = {x} y= {y} z= {z}";
        }
    }
    
    public class Calculator
    {
        public void Sum(int x, int y) { }
        public void Sum(int x,int y,int z) { }
        public void Sum(double x,double y) { }

    }
    public class Car
    {
       public int Id;
        public string Brand;
        public double Price;
        public Car()
        {
            
        }
        public Car(int _id)
        {
            Id = _id;
            Brand = "bmw";
            Price = 525435;

        }
        public Car(int id , string brand)
        {
           Id = id;
            Brand = brand;
            Price = 445242;
        }
        public Car(int id, string brand,double price)
        {
            Id = id;
            Brand = brand;
            Price = price;
        }
    }
    internal class Program
    {
       
        static void Main(string[] args)
        {
       

        }
    }
   
}