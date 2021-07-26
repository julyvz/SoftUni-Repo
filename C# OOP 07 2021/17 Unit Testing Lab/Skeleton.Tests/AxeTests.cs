using NUnit.Framework;

[TestFixture]
public class AxeTests
{
    [Test]
    public void AxeLosesDurabilyAfterAttack()
    {
        // Arrange
        Axe axe = new Axe(10, 5);
        Dummy dummy = new Dummy(10, 10);
        // Act
        axe.Attack(dummy);
        // Assert
        Assert.That(axe.DurabilityPoints, Is.EqualTo(4));
    }

    [Test]
    public void BrokenAxeCantAttack()
    {
        // Arrange
        Axe axe = new Axe(1, 1);
        Dummy dummy = new Dummy(10, 10);
        // Act
        axe.Attack(dummy);
        // Assert
        Assert.That(() => axe.Attack(dummy), Throws.InvalidOperationException.With.Message.EqualTo("Axe is broken."));
    }
}