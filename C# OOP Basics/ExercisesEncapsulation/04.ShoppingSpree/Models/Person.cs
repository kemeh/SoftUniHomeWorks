using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Person
{
    private string name;
    private decimal money;
    private List<Product> bagOfProducts;

    public Person(string name, decimal money)
    {
        this.Name = name;
        this.Money = money;
        this.bagOfProducts = new List<Product>();
    }

    public string Name
    {
        get { return this.name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
            {
                throw new ArgumentException($"{nameof(Name)} cannot be empty");
            }

            this.name = value;
        }
    }

    public decimal Money
    {
        get { return this.money; }

        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }

            this.money = value;
        }
    }


    public void Buy(Product product)
    {
        if (this.money >= product.Cost)
        {
            this.bagOfProducts.Add(product);
            this.money -= product.Cost;
            Console.WriteLine($"{this.name} bought {product.Name}");
        }
        else
        {
            Console.WriteLine($"{this.name} can't afford {product.Name}");
        }
    }

    public override string ToString()
    {
        if (!this.bagOfProducts.Any())
        {
            return $"{this.name} – Nothing bought";
        }
        else
        {
            List<string> productNames = this.bagOfProducts.Select(p => p.Name).ToList();
            return $"{this.name} - {string.Join(", ", productNames)}";
        }        
    }
}