using System;

public class Car : Vehicle
{
    public Car(double quantity, double consumption, double tankCapacity) 
        : base(quantity, consumption, tankCapacity)
    {
        base.FuelConsumption = consumption + 0.9;
    }

    public override void Refill(double quantity)
    {
        if (this.FuelQuantity + quantity > this.TankCapacity)
        {
            throw new ArgumentException("Cannot fit fuel in tank");
        }
        if (quantity <= 0)
        {
            throw new ArgumentException("Fuel must be a positive number");
        }

        this.FuelQuantity += quantity;
    }
}