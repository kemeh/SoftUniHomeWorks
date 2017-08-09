using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Car
{
    public string model;
    public Engine engine;
    public Cargo cargo;
    public List<Tire> tires;

    public Car(string model)
    {
        this.model = model;
        this.engine = new Engine();
        this.cargo = new Cargo();
        this.tires = new List<Tire>();
    }
}
