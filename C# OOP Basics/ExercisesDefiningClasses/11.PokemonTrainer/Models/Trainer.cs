using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

class Trainer
{
    public string name;
    public int badgesCount;
    public List<Pokemon> pokemons;

    public Trainer(string name)
    {
        this.name = name;
        this.badgesCount = 0;
        this.pokemons = new List<Pokemon>();
    }

    public override string ToString()
    {
        return $"{this.name} {this.badgesCount} {this.pokemons.Count}";
    }

    public void ContainsElement(string element)
    {
        if (pokemons.Exists(p => p.element == element))
        {
            this.badgesCount++;
        }
        else
        {
            for (int i = 0; i < pokemons.Count; i++)
            {
                pokemons[i].health -= 10;

                if (pokemons[i].health <= 0)
                {
                    pokemons.Remove(pokemons[i]);
                    i--;
                }
            }
        }
    }
}
