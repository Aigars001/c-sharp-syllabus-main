using System;

namespace Exercise1
{
    internal class Product
    {
        private string _name;
        private double _priceAtStart;
        private int _amountAtStart;

        public Product(string name, double priceAtStart, int amountAtStart)
        {
            _name = name;
            _priceAtStart = priceAtStart;
            _amountAtStart = amountAtStart;
        }

        public void PrintProduct()
        {
            Console.WriteLine($"{_name} price: {_priceAtStart} EUR, amount: {_amountAtStart} units");
        }

        public int ChangeQuantity(int newAmount)
        {
            return _amountAtStart = newAmount;
        }

        public double ChangePrice(double newPrice)
        {
            return _priceAtStart = newPrice;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product("Logitech mouse", 70.00, 14);
            Product p2 = new Product("iPhone 5s", 999.99, 3 );
            Product p3 = new Product("Epson EB-U05", 440.46, 1);
           
            Console.WriteLine("Original \n");
            p1.PrintProduct();
            p2.PrintProduct();
            p3.PrintProduct();

            p1.ChangeQuantity(1);
            p2.ChangePrice(500.99);

            Console.WriteLine("\nChanged \n");
            p1.PrintProduct();
            p2.PrintProduct();
            p3.PrintProduct();

            Console.ReadKey();
        }
    }
}