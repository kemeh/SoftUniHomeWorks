using System;

public class Bus : Vehicle
{
    public Bus(double quantity, double consumption, double tankCapacity)
    : base(quantity, consumption, tankCapacity)
    {
        base.FuelConsumption = consumption + 1.4;
    }

    public void DriveEmpty(double distance)
    {
        double allowedDistance = this.FuelQuantity / (this.FuelConsumption - 1.4);

        if (distance < allowedDistance)
        {
            this.FuelQuantity -= distance * (this.FuelConsumption - 1.4);

            Console.WriteLine($"{GetType().Name} travelled {distance} km");
        }
        else
        {
            Console.WriteLine($"{GetType().Name} needs refueling");
        }
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