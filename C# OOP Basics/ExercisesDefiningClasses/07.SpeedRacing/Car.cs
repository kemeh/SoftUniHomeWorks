using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Car
    {
        public string model;
        public double fuelAmount;
        public double fuelConsumptionPerKm;
        public int travelledDistance = 0;


        public Car(string model, double fuelAmount, double cons)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelConsumptionPerKm = cons;
        }

        public void Drive(int kilometers)
        {
            double totalConsumptionPerDrive = kilometers * this.fuelConsumptionPerKm;
            if (totalConsumptionPerDrive <= fuelAmount)
            {
                this.fuelAmount -= totalConsumptionPerDrive;
                this.travelledDistance += kilometers;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }