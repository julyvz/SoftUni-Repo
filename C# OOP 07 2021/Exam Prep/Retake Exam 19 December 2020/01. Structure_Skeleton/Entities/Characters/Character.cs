using System;

using WarCroft.Constants;
using WarCroft.Entities.Inventory;
using WarCroft.Entities.Items;

namespace WarCroft.Entities.Characters.Contracts
{
    public abstract class Character
    {
        // TODO: Implement the rest of the class.
        private string name;
        private double armor;
        private double health;

        public Character(string name, double health, double armor, double abilityPoints, IBag bag)
        {
            Name = name;
            BaseHealth = health;
            Health = health;
            BaseArmor = armor;
            Armor = armor;
            AbilityPoints = abilityPoints;
            Bag = bag;
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.CharacterNameInvalid);
                }

                name = value;
            }
        }

        public double BaseHealth { get; }

        public double Health
        {
            get => health;
            set
            {
                if (value > BaseHealth)
                {
                    health = BaseHealth;
                }
                else if (value < 0)
                {
                    health = 0;
                }
                else
                {
                    health = value;
                }
            }
        }

        public double BaseArmor { get; }

        public double Armor
        {
            get => armor;
            private set
            {
                if (value < 0)
                {
                    armor = 0;
                }

                armor = value;
            }
        }

        public double AbilityPoints { get; }

        public IBag Bag { get; }

        public bool IsAlive { get; set; } = true;

        protected void EnsureAlive()
        {
            if (!this.IsAlive)
            {
                throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
            }
        }

        public void TakeDamage(double hitPoints)
        {
            this.EnsureAlive();
            if (Armor >= hitPoints)
            {
                Armor -= hitPoints;
            }
            else
            {
                double diff = Armor - hitPoints;
                Armor = 0;
                if (Health + diff > 0)
                {
                    Health += diff;
                }
                else
                {
                    Health = 0;
                    IsAlive = false;
                }
            }
        }

        public void UseItem(Item item)
        {
            EnsureAlive();
            item.AffectCharacter(this);
        }
    }
}