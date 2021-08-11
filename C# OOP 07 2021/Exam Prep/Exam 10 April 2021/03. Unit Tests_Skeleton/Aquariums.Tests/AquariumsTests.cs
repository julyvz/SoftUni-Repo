namespace Aquariums.Tests
{
    using NUnit.Framework;
    using System;
    using System.Linq;

    [TestFixture]
    public class AquariumsTests
    {
        Aquarium aquarium;
        Fish myfish;

        [SetUp]
        public void SetUp()
        {
            aquarium = new Aquarium("My", 10);
            myfish = new Fish("Nemo");
        }

        [Test]
        public void Ctor_Positive()
        {
            Assert.That(aquarium.Name == "My");
            Assert.That(aquarium.Capacity == 10);
        }

        [Test]
        public void NameIsNull_TE()
        {
            Assert.Throws<ArgumentNullException>(() => new Aquarium(null, 10));
        }

        [Test]
        public void CapacityIsNegative_TE()
        {
            Assert.Throws<ArgumentException>(() => new Aquarium("My", -10));
        }

        [Test]
        public void Count_Positive()
        {
            Assert.That(aquarium.Count == 0);
        }

        [Test]
        public void Add_TE_WhenIsFull()
        {
            aquarium = new Aquarium("My", 1);
            aquarium.Add(myfish);
            Assert.Throws<InvalidOperationException>(() => aquarium.Add(myfish));
        }

        [Test]
        public void Add_Positive()
        {
            Assert.That(aquarium.Count == 0);
            aquarium.Add(myfish);
            Assert.That(aquarium.Count == 1);
        }

        [Test]
        public void RemoveFish_TE_WhenIsNull()
        {
            aquarium.Add(myfish);
            Assert.Throws<InvalidOperationException>(() => aquarium.RemoveFish("Pipi"));
        }

        [Test]
        public void RemoveFish_Positive()
        {
            aquarium.Add(myfish);
            Assert.That(aquarium.Count == 1);
            aquarium.RemoveFish("Nemo");
            Assert.That(aquarium.Count == 0);
        }

        [Test]
        public void SellFish_TE_WhenIsNull()
        {
            aquarium.Add(myfish);
            Assert.Throws<InvalidOperationException>(() => aquarium.SellFish("Not Available"));
        }

        [Test]
        public void SellFish_Positive()
        {
            aquarium.Add(myfish);
            aquarium.SellFish("Nemo");
            Assert.That(myfish.Available == false);
        }

        [Test]
        public void SellFishReturnsFish()
        {
            aquarium.Add(myfish);

            Fish returnedFish = aquarium.SellFish(myfish.Name);

            Assert.AreEqual(returnedFish, myfish);
        }

        [Test]
        public void Report_Positive()
        {
            aquarium.Add(myfish);
            aquarium.Add(new Fish("Pipi"));
            Assert.That(aquarium.Report(), Is.EqualTo($"Fish available at My: Nemo, Pipi"));
        }        
    }
}
