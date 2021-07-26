namespace Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            FuelConsumption += 1.6;
        }

        public override bool Refuel(double liters)
        {
            if(base.Refuel(liters))
            FuelQuantity -= 0.05 * liters;
            return true;
        }
    }
}
