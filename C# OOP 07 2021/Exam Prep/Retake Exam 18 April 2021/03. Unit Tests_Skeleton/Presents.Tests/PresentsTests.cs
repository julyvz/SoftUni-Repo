namespace Presents.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class PresentsTests
    {
        Bag bag;
        Present present;

        [SetUp]
        public void SetUp()
        {
            bag = new Bag();
            present = new Present("Test", 5.0);
        }

        [Test]
        public void Ctor_Positive() //1
        {
            Assert.IsNotNull(bag.GetPresents());
        }

        [Test]
        public void Create_Positive() //4
        {            
            Assert.AreEqual($"Successfully added present {"Test"}.", bag.Create(present));
            Assert.AreEqual(1, bag.GetPresents().Count);
        }

        [Test]
        public void Create_TE_WhenPresenrIsNull() //2
        {
            Present test = null;
            Assert.Throws<ArgumentNullException>(() => bag.Create(test));
        }

        [Test]
        public void Create_TE_WhenPresenrExists() //3
        {
            bag.Create(present);
            Assert.Throws<InvalidOperationException>(() => bag.Create(present));
        }

        [Test]
        public void Remove_Positive() //5
        {
            bag.Create(present);
            Assert.AreEqual(true, bag.Remove(present));
        }

        [Test]
        public void GetPresentWithLeastMagic_Positive() //6
        {
            bag.Create(present);
            bag.Create(new Present("Shop", 6.0));

            Assert.AreEqual(present, bag.GetPresentWithLeastMagic());
        }

        [Test]
        public void GetPresent_Positive() //7
        {
            bag.Create(present);
            bag.Create(new Present("Shop", 6.0));

            Assert.AreEqual(present, bag.GetPresent("Test"));
        }
    }
}
