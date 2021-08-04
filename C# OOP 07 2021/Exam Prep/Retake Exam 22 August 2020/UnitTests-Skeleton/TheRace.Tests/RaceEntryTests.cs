using NUnit.Framework;
// using TheRace;
using System;

namespace TheRace.Tests
{
    public class RaceEntryTests
    {
        private RaceEntry raceEntry;

        [SetUp]
        public void Setup()
        {
            raceEntry = new RaceEntry();
        }

        [Test]
        public void Counter_IsZeroAtStart()
        {
            Assert.That(raceEntry.Counter, Is.Zero);
        }

        [Test]
        public void Counter_IncreasesAfterAddingDriver()
        {
            raceEntry.AddDriver(new UnitDriver("Jul", new UnitCar("Tesla", 250, 3500)));
            
            Assert.That(raceEntry.Counter, Is.EqualTo(1));
        }

        [Test]
        public void AddDriver_ThrowsExceptionWhenDriverIsNull()
        {
            Assert.Throws<InvalidOperationException>(() => raceEntry.AddDriver(null));
        }

        [Test]
        public void AddDriver_ThrowsException_WhenThereIsDriverWithSameName()
        {
            raceEntry.AddDriver(new UnitDriver("Jul", new UnitCar("Tesla", 250, 3500)));

            Assert.Throws<InvalidOperationException>(() => raceEntry.AddDriver(new UnitDriver("Jul", new UnitCar("Tesla S", 350, 3000))));
        }

        [Test]
        public void AddDriver_Positive()
        {
            var actual = raceEntry.AddDriver(new UnitDriver("Jul", new UnitCar("Tesla", 250, 3500)));
            var expected = "Driver Jul added in race.";

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void CalculateAverageHorsePower_ThrowsException_WhenParticipantsAreLessThanRequired()
        {
            Assert.Throws<InvalidOperationException>(() => raceEntry.CalculateAverageHorsePower());

            raceEntry.AddDriver(new UnitDriver("Jul", new UnitCar("Tesla", 250, 3500)));

            Assert.Throws<InvalidOperationException>(() => raceEntry.CalculateAverageHorsePower());
        }

        [Test]
        public void CalculateAverageHorsePower_Positive()
        {
            int n = 10;
            double expected = 0;
            
            for (int i = 0; i < n; i++)
            {
                int hp = 450 + i;
                expected += hp;

                raceEntry.AddDriver(new UnitDriver($"Name-{i}", new UnitCar("Tesla", hp, 3500)));
            }

            expected /= n;

            Assert.That(raceEntry.CalculateAverageHorsePower(), Is.EqualTo(expected));
        }
    }
}