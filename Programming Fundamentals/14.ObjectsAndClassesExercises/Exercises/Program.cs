using System;
using System.Collections.Generic;
using System.Linq;

class Customer
{
    public string Name { get; set; }

    public Dictionary<string, int> ShopList { get; set; }

    public decimal Bill { get; set; }

    public Customer(string name, Dictionary<string, int> shopList)
    {
        this.Name = name;
        this.ShopList = shopList;
    }
}

class Program
{
    static void Main()
    {
        int amount = int.Parse(Console.ReadLine());    
        var productsPrices = new Dictionary<string, decimal>();

        GetProductAndPrices(amount, productsPrices);

        List<Customer> customers = new List<Customer>();

        string client = Console.ReadLine();
        while (!client.Equals("end of clients"))
        {
            string[] clientArgs = client.Split(new char[] { ',', '-' }).ToArray();
            string productName = clientArgs[1];
            int quantity = int.Parse(clientArgs[2]);

            var customer = new Customer(clientArgs[0], new Dictionary<string, int>());
            customer.ShopList.Add(productName, quantity);

            if (customers.Any(c => c.Name == clientArgs[0]))
            {
                var existingCustomer = customers.First(c => c.Name == clientArgs[0]);
                if (existingCustomer.ShopList.ContainsKey(productName))
                {
                    existingCustomer.ShopList[productName] += quantity;
                }
                else
                {
                    existingCustomer.ShopList[productName] = quantity;
                }
            }
            else
            {
                if (productsPrices.ContainsKey(productName))
                {
                    customers.Add(customer);
                }
            }

            client = Console.ReadLine();
        }
    }

    private static void GetProductAndPrices(int amount, Dictionary<string, decimal> productsPrices)
    {
        for (int i = 0; i < amount; i++)
        {
            string[] productArgs = Console.ReadLine().Split('-').ToArray();
            string productName = productArgs[0];
            decimal productPrice = decimal.Parse(productArgs[1]);

            if (!productsPrices.ContainsKey(productName))
            {
                productsPrices.Add(productName, productPrice);
            }
            else
            {
                productsPrices[productName] = productPrice;
            }
        }
    }
}

