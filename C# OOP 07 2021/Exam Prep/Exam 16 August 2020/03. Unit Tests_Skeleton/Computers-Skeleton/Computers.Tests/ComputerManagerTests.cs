using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Computers.Tests
{
    [TestFixture]
    public class Tests
    {
        ComputerManager myManager;
        Computer computer;

        [SetUp]
        public void Setup()
        {
            myManager = new ComputerManager();
            computer = new Computer("Apple", "Good", 20.20M);
        }

        [Test]
        public void ctor_postive()
        {
            Assert.IsNotNull(myManager.Computers);
        }

        [Test]
        public void Prop_ReturnsCollectionAsReadOnly()
        {
            Assert.IsInstanceOf<IReadOnlyCollection<Computer>>(this.myManager.Computers);
        }

        [Test]
        public void Count_postive()
        {
            myManager.AddComputer(computer);
            
            Assert.AreEqual(1, myManager.Count);
        }

        [Test]
        public void AddComputer_TE_WhenComputerExists()
        {
            myManager.AddComputer(computer);

            Assert.Throws<ArgumentException>(() => myManager.AddComputer(computer));
        }

        [Test]
        public void AddComputer_TE_WhenComputerIsNull()
        {
            computer = null;

            Assert.Throws<ArgumentNullException>(() => myManager.AddComputer(computer));
        }

        [Test]
        public void AddComputer_Positive()
        {
            myManager.AddComputer(computer);

            Assert.AreEqual(computer, myManager.Computers.FirstOrDefault());
        }

        [Test]
        public void RemoveComputer_Positive()
        {
            myManager.AddComputer(computer);
            Assert.AreEqual(1, myManager.Count);

            Computer result = myManager.RemoveComputer(computer.Manufacturer, computer.Model);
            Assert.AreEqual(0, myManager.Count);
            Assert.AreEqual(computer, result);
        }

        [Test]
        public void RemoveComputer_TE_WhenParamsAreNull()
        {
            myManager.AddComputer(computer);

            Assert.Throws<ArgumentNullException>(() => myManager.RemoveComputer(null, null));
        }

        [Test]
        public void GetComputer_TE_WhenParamsAreNull()
        {
            myManager.AddComputer(computer);
            Assert.AreEqual(1, myManager.Count);

            Assert.Throws<ArgumentNullException>(() => myManager.GetComputer(null, computer.Model));

            Assert.Throws<ArgumentNullException>(() => myManager.GetComputer(computer.Manufacturer, null));
        }

        [Test]
        public void GetComputer_TE_WhenSuchComputerDontExists()
        {
            myManager.AddComputer(computer);

            Assert.Throws<ArgumentException>(() => myManager.GetComputer("Pipi", "toto"));
        }

        [Test]
        public void GetComputer_Positive()
        {
            myManager.AddComputer(computer);
            Computer result = myManager.GetComputer(computer.Manufacturer, computer.Model);

            Assert.AreEqual(computer, result);
        }

        [Test]
        public void GetComputersByManufacturer_Positive()
        {
            myManager.AddComputer(computer);
           myManager.AddComputer(new Computer("Lenovo", "Thinkpad", 1003));

            var computers = myManager.GetComputersByManufacturer("Lenovo");

            Assert.AreEqual(computers.Count, 1);
        }

        [Test]
        public void GetComputersByManufacturer_TE_WhenManufacturerIsNull()
        {
            myManager.AddComputer(computer);

            Assert.Throws<ArgumentNullException>(() => myManager.GetComputersByManufacturer(null));
        }
    }
}