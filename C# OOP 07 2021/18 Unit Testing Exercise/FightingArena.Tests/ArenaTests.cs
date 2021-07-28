using NUnit.Framework;
using System;
using System.Collections.Generic;
using FightingArena;

namespace Tests
{
    [TestFixture]
    public class ArenaTests
    {
        private Arena arena;

        [SetUp]
        public void Setup()
        {
            arena = new Arena();            
        }

        [Test]
        public void Ctor_Positive()
        {
            Assert.IsNotNull(arena.Warriors);
        }

        [Test]
        public void Count_Positive()
        {
            arena.Enroll(new Warrior("Pesho", 50, 100));
            Assert.AreEqual(1, arena.Count);
        }

        [Test]
        // •	Already enrolled Warriors should not be able to enroll again
        public void Enroll_ThrowsExceptionWhenEnrollAlreadyEnrolledWarriors()
        {
            arena.Enroll(new Warrior("Pesho", 50, 100));
            
            Assert.Throws<InvalidOperationException>(() => arena.Enroll(new Warrior("Pesho", 100, 100)));
        }

        [Test]
        //•	There cannot be fight if one of the Warriors is not enrolled for the fights.
        public void Fight_ThrowsExceptionWhenAttackerOrDefenderIsNull()
        {
            var attacker = new Warrior("Pesho", 50, 100);

            arena.Enroll(attacker);

            Assert.Throws<InvalidOperationException>(() => arena.Fight(attacker.Name, "Gosho"));
            Assert.Throws<InvalidOperationException>(() => arena.Fight("Gosho", attacker.Name));
        }

        [Test]
        public void Fight_WorksProperly()
        {
            Warrior attacker = new Warrior("Pesho", 50, 100);
            Warrior defender = new Warrior("Gosho", 50, 100);

            arena.Enroll(attacker);
            arena.Enroll(defender);

            var attackerExpectedHp = attacker.HP - defender.Damage;
            var defenderExpectedHp = defender.HP - attacker.Damage;

            arena.Fight("Pesho", "Gosho");

            Assert.AreEqual(attackerExpectedHp, attacker.HP);
            Assert.AreEqual(defenderExpectedHp, defender.HP);
        }
    }
}
