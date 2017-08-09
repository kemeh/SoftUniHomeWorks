using System;

public class Truck : Vehicle
{
    public Truck(double quantity, double consumption, double tankCapacity) 
        : base(quantity, consumption, tankCapacity)
    {
        base.FuelConsumption = consumption + 1.6;
    }

    public override void Refill(double quantity)
    {
        if (quantity <= 0)
        {
            throw new ArgumentException("Fuel must be a positive number");
        }

        this.FuelQuantity += quantity * 0.95;
    }
}