namespace Vehicles
{
    public class Truck : Vehicle
    {
        private const double airConConsum = 1.6;

        public Truck(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption + airConConsum)
        {
        }

        public override void Refuel(double liters)
        {
            base.Refuel(liters * 0.95);
        }
    }
}
