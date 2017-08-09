using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Person> allPeople = new List<Person>();
        List<Product> allProducts = new List<Product>();

        var personTokens = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries );
        try
        {
            for (int i = 0; i < personTokens.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(personTokens[i]))
                {
                    break;
                }

                var tokens = personTokens[i].Split(new [] { '=' }, StringSplitOptions.RemoveEmptyEntries );
                var name = tokens[0];
                var money = decimal.Parse(tokens[1]);

                Person currentPerson = new Person(name, money);

                allPeople.Add(currentPerson);
            }

            var productTokens = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < productTokens.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(productTokens[i]))
                {
                    break;
                }
                var tokens = productTokens[i].Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                var name = tokens[0];
                var cost = decimal.Parse(tokens[1]);

                Product currentProduct = new Product(name, cost);

                allProducts.Add(currentProduct);
            }

            var buy = Console.ReadLine();
            while (buy.ToLower() != "end")
            {
                var tokens = buy.Split();
                var buyer = tokens[0];
                var product = tokens[1];

                allPeople.Where(p => p.Name == buyer).FirstOrDefault()
                    .Buy(allProducts.Where(pr => pr.Name == product).FirstOrDefault());

                buy = Console.ReadLine();
            }

            foreach (var person in allPeople)
            {
                Console.WriteLine(person.ToString());
            }
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}