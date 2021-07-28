using NUnit.Framework;
// using CarManager;
using System;

namespace Tests
{
    public class CarTests
    {
        [SetUp]
        public void Setup()
        {
            Car myCar = new Car("Audi", "TT", 5, 60);
        }

        [Test]
        [TestCase("", "Model", 5, 60)]
        [TestCase(null, "Model", 5, 60)]
        [TestCase("Ada", "", 5, 60)]
        [TestCase("Ada", null, 5, 60)]
        [TestCase("Ada", "Make", 0, 60)]
        [TestCase("Ada", "Make", -5, 60)]
        [TestCase("Ada", "Make", 5, 0)]
        [TestCase("Ada", "Make", 5, -10)]

        public void Ctor_ThrowsExceptionWhenDataIsInvalid(string make, string model, double fuelConsumption, double fuelCapacity)
        {
            Assert.Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, fuelCapacity));
        }

        [Test]
        public void Ctor_Positive()
        {
            Car myCar = new Car("Audi", "TT", 5, 60);

            string make = "Audi";
            string model = "TT";
            double fuelConsumption = 5;
            double fuelCapacity = 60;
            Assert.That(myCar.Make, Is.EqualTo(make));
            Assert.That(myCar.Model, Is.EqualTo(model));
            Assert.That(myCar.FuelConsumption, Is.EqualTo(fuelConsumption));
            Assert.That(myCar.FuelCapacity, Is.EqualTo(fuelCapacity));
        }

        [Test]
        [TestCase(0)]
        [TestCase(-10)]
        public void Refuel_ThrowsExceptionWhenFuelIsZeroOrNegstive(double fuel)
        {
            Car myCar = new Car("Audi", "TT", 5, 60);
            Assert.Throws<ArgumentException>(() => myCar.Refuel(fuel));
        }

        [Test]
        public void Refuel_Positive()
        {
            Car myCar = new Car("Audi", "TT", 5, 60);

            double refuelAmount = myCar.FuelCapacity / 2;
            myCar.Refuel(refuelAmount);
            Assert.That(myCar.FuelAmount, Is.EqualTo(refuelAmount));
        }

        [Test]
        public void Refuel_SetFuelAmountToCapacity()
        {
            Car myCar = new Car("Audi", "TT", 5, 60);

            myCar.Refuel(myCar.FuelCapacity * 1.2);
            Assert.That(myCar.FuelAmount, Is.EqualTo(myCar.FuelCapacity));
        }

        [Test]
        public void Drive_ThrowsExceptionWhenFuelIsZero()
        {
            Car myCar = new Car("Audi", "TT", 5, 60);

            Assert.Throws<InvalidOperationException>(() =>  myCar.Drive(200));
        }

        [Test]
        public void Drive_Positive()
        {
            Car myCar = new Car("Audi", "TT", 5, 60);

            myCar.Refuel(myCar.FuelCapacity);
            myCar.Drive(500);
            Assert.That(myCar.FuelAmount, Is.EqualTo((myCar.FuelCapacity - (500 / 100) * myCar.FuelConsumption)));
        }

        [Test]
        public void Drive_FuelToZero()
        {
            Car myCar = new Car("Audi", "TT", 5, 60);

            myCar.Refuel(5);
            Assert.Throws<InvalidOperationException>(() => myCar.Drive(200));
        }
    }
}