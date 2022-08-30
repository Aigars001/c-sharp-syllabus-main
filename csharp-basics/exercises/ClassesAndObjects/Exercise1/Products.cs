using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}