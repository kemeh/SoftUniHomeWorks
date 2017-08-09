using System;

public abstract class Vehicle
{
    private double fuelQuantity;
    private double fuelConsumption;
    private double tankCapacity;

    public Vehicle(double quantity, double consumption, double tankCapacity)
    {
        this.FuelQuantity = quantity;
        this.FuelConsumption = consumption;
        this.tankCapacity = tankCapacity;
    }

    public double TankCapacity
    {
        get { return this.tankCapacity; }
        set { this.tankCapacity = value; }
    }

    public double FuelConsumption
    {
        get { return fuelConsumption; }
        set { fuelConsumption = value; }
    }

    public virtual double FuelQuantity
    {
        get { return fuelQuantity; }
        set { this.fuelQuantity = value; }
    }

    public virtual void Drive(double distance)
    {
        double allowedDistance = this.FuelQuantity / this.FuelConsumption;

        if (distance < allowedDistance)
        {
            this.FuelQuantity -= distance * this.fuelConsumption;

            Console.WriteLine($"{GetType().Name} travelled {distance} km");
        }
        else
        {
            Console.WriteLine($"{GetType().Name} needs refueling");
        }
    }

    public abstract void Refill(double quantity);

    public override string ToString()
    {
        return $"{GetType().Name}: {this.fuelQuantity:f2}"; 
    }
}

