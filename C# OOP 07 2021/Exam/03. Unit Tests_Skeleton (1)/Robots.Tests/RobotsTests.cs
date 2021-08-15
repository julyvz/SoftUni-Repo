namespace Robots.Tests
{
    using NUnit.Framework;
    using System;

    public class RobotsTests
    {
        RobotManager robotManager;
        Robot robot;

        [SetUp]
        public void SetUp()
        {
            robotManager = new RobotManager(5);
            robot = new Robot("Cop", 10);
        }

        [Test]
        public void Ctor_Positive()
        {
            Assert.AreEqual(0, robotManager.Count);
        }

        [Test]
        public void Capacity_Positive()
        {
            Assert.AreEqual(5, robotManager.Capacity);
        }

        [Test]
        public void Capacity_TE_WhenNegative()
        {            
            Assert.Throws<ArgumentException>(() => new RobotManager(-5));
        }

        [Test]
        public void Add_Positive()
        {
            robotManager.Add(robot);
            Assert.AreEqual(1, robotManager.Count);
        }

        [Test]
        public void Add_TE_WhenSameName()
        {
            robotManager.Add(robot);

            Assert.Throws<InvalidOperationException>(() => robotManager.Add(robot));
        }

        [Test]
        public void Add_TE_WhenOverCapacity()
        {
            robotManager = new RobotManager(2);
            robotManager.Add(robot);
            robotManager.Add(new Robot("Test", 7));

            Assert.Throws<InvalidOperationException>(() => robotManager.Add(new Robot("Test1", 8)));
        }

        [Test]
        public void Remove_Positive()
        {
            robotManager.Add(robot);

            robotManager.Remove("Cop");
            Assert.AreEqual(0, robotManager.Count);
        }

        [Test]
        public void Remove_TE_WhenNoSuchName()
        {
            robotManager.Add(robot);            

            Assert.Throws<InvalidOperationException>(() => robotManager.Remove("Cop2"));
        }

        [Test]
        public void Work_Positive()
        {
            robotManager.Add(robot);
            robotManager.Work("Cop", "Turbo", 1);            

            Assert.AreEqual(9, robot.Battery);
        }

        [Test]
        public void Work_TE_WhenNoSuchName()
        {
            robotManager.Add(robot);            

            Assert.Throws<InvalidOperationException>(() => robotManager.Work("Cop2", "Turbo", 1));
        }

        [Test]
        public void Work_TE_WhenBigBatteryUsage()
        {
            robotManager.Add(robot);

            Assert.Throws<InvalidOperationException>(() => robotManager.Work("Cop", "Turbo", 15));
        }

        [Test]
        public void Charge_Positive()
        {
            robotManager.Add(robot);
            robotManager.Work("Cop", "Turbo", 1);
            robotManager.Charge("Cop");

            Assert.AreEqual(robot.Battery, robot.MaximumBattery);
        }

        [Test]
        public void Charge_TE_WhenNoSuchName()
        {
            robotManager.Add(robot);

            Assert.Throws<InvalidOperationException>(() => robotManager.Charge("Cop2"));
        }
    }
}
