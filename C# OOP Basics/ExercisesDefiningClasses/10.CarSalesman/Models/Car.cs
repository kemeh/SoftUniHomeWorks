using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Car
{
    public string model;
    public Engine engine;
    public string weight = "n/a";
    public string color = "n/a";

    public Car(string model, Engine engine)
    {
        this.model = model;
        this.engine = engine;
    }

    public override string ToString()
    {
        return $"{this.model}:\n" +
               $"  {this.engine.model}:\n" +
               $"    Power: {this.engine.power}\n" +
               $"    Displacement: {this.engine.displacement}\n" +
               $"    Efficiency: {this.engine.efficiency}\n" +
               $"  Weight: {this.weight}\n" +
               $"  Color: {this.color}";
    }
}