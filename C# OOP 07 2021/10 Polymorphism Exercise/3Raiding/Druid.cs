﻿namespace _3Raiding
{
    public class Druid : BaseHero
    {
        public Druid(string name, int power) : base(name, power)
        {
        }

        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {Name} healed for {Power}";
        }
    }
}
