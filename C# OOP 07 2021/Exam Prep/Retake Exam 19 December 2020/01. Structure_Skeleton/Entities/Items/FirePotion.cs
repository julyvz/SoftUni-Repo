﻿using WarCroft.Entities.Characters.Contracts;


namespace WarCroft.Entities.Items
{
    public class FirePotion : Item
    {
        public FirePotion() : base(5)
        {
        }

        public override void AffectCharacter(Character character)
        {
            base.AffectCharacter(character);
            
            if (character.Health - 20 <= 0)
            {
                character.IsAlive = false;
            }

            character.Health -= 20;
        }
    }
}
