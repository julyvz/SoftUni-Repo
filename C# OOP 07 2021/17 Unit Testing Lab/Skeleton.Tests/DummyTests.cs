using NUnit.Framework;

[TestFixture]
public class DummyTests
{
    [Test]
    public void DummyLosesHealthIfAttacked()
    {
        // Arrange
        Axe axe = new Axe(10, 5);
        Dummy dummy = new Dummy(5, 10);
        // Act
        axe.Attack(dummy);
        // Assert
        Assert.That(dummy.Health, Is.EqualTo(5-10));
    }

    [Test]
    public void DeadDummyThrowsExceptionIfAttacked()
    {
        // Arrange
        Axe axe = new Axe(10, 5);
        Dummy dummy = new Dummy(5, 10);
        // Act
        axe.Attack(dummy);
        // Assert
        Assert.That(() => axe.Attack(dummy),
    Throws.InvalidOperationException
      .With.Message.EqualTo("Dummy is dead."));
    }

    [Test]
    public void DeadDummyCanGiveXP()
    {
        // Arrange
        Axe axe = new Axe(10, 5);
        Dummy dummy = new Dummy(5, 10);
        // Act
        axe.Attack(dummy);
        // Assert
        Assert.That(dummy.GiveExperience(), Is.EqualTo(10));
    }

    [Test]
    public void AliveDummyCantGiveXP()
    {
        // Arrange
        Axe axe = new Axe(10, 5);
        Dummy dummy = new Dummy(5, 10);
        // Act
        
        // Assert
        Assert.That(() => dummy.GiveExperience(),
    Throws.InvalidOperationException
      .With.Message.EqualTo("Target is not dead."));
    }
}
