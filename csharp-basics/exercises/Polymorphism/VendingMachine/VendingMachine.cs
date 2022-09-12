using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class VendingMachine : IVendingMachine
    {
        public string Manufacturer { get; }
        public bool HasProducts => Array.Exists(Products, product => product.Available > 0);
        public Money Amount { get; set; }
        public Product[] Products { get; set; }
        public string[] AcceptedCoins = { "£0.10", "£0.20", "£0.50", "£1.00", "£2.00" };

        public VendingMachine(string manufacturer,  Product[] products)
        {
            Manufacturer = manufacturer;
            Products = products;
        }

        public VendingMachine(string manufacturer)
        {
            Manufacturer = manufacturer;
        }

        public Money InsertCoin(Money amount)
        {
            if (AcceptedCoins.Contains(amount.ToString()))
            {
                Amount = Amount.Add(amount);
                return amount;
            }
            else
            {
                Console.WriteLine($"Accepted Coins: {string.Join("||", AcceptedCoins)}");
                return Amount;
            }
        }
        
        public Money ReturnMoney()
        {
            var product = new Product();
            var returnAmount = Amount.Subtract(product.Price);

            Console.WriteLine($"{returnAmount} returned");
            return returnAmount;
        }


        public bool AddProduct(string name, Money price, int count)
        {
            bool hasemptySlots = false;
            int index = 0;

            for (int i = 0; i < Products.Length; i++)
            {
                if (String.IsNullOrEmpty(Products[i].Name))
                {
                    hasemptySlots = true;
                    index = i;
                }
            }

            if (hasemptySlots)
            {
                Products[index] = new Product(name, price, count);
                return true;
            }
            else
            {
                Console.WriteLine("No empty slots");
                return false;
            }
        }

        public bool UpdateProduct(int productNumber, string name, Money? price, int amount)
        {
            var product = new Product();
            if (price.HasValue)
            {
                product.Price = price.Value;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool BuyProduct(int index)
        {
            var product = Products[index -1];
            var price = Products[index -1].Price.NumericValue();
            var balance = Amount.NumericValue();

            if (product.Available < 1)
            {
                Console.WriteLine("Product not available");
                return false;
            }

            if (price > balance)
            {
                Console.WriteLine("Not enough balance");
                return false;
            }
            else
            {
                product.Available -= 1;
                Amount = Amount.Subtract(product.Price);
                Console.WriteLine($"Thanks for purchasing {product.Name}");
                ReturnMoney();
                return true;
            }
        }

        public string ReturnAvailableProducts()
        {
            if (!HasProducts)
            {
                return "No products available";
            }

            var list = new List<string>();

            for (int i = 0; i < Products.Length; i++)
            {
                list.Add($"{i+1}.{Products[i]}");
            }

            return String.Join("\n", list);
        }
    }
}
