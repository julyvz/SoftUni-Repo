using System;
using System.Linq;
using System.Collections.Generic;
using WarCroft.Entities.Characters;
using WarCroft.Entities.Characters.Contracts;
using WarCroft.Entities.Items;
using System.Text;

namespace WarCroft.Core
{
	public class WarController
	{
		private List<Character> party;
		private Stack<Item> pool;
		
		public WarController()
		{
			party = new List<Character>();
			pool = new Stack<Item>();
		}

		public string JoinParty(string[] args)
		{
            switch (args[0])
            {
				case "Warrior":
					party.Add(new Warrior(args[1]));
					break;

				case "Priest":
					party.Add(new Priest(args[1]));
					break;

				default:
					throw new ArgumentException($"Invalid character type \"{args[0]}\"!");
            }

			return $"{args[1]} joined the party!";
		}

		public string AddItemToPool(string[] args)
		{
			switch (args[0])
			{
				case "HealthPotion":
					pool.Push(new HealthPotion());
					break;
				case "FirePotion":
					pool.Push(new FirePotion());
					break;

				default:
					throw new ArgumentException($"Invalid item \"{args[0]}\"!");
			}

			return $"{args[0]} added to pool.";
		}

		public string PickUpItem(string[] args)
		{
			var character = party.FirstOrDefault(x => x.Name == args[0]);

            if (character is null)
            {
				throw new ArgumentException($"Character {args[0]} not found!");
			}

            if (pool.Count == 0)
            {
				throw new InvalidOperationException("No items left in pool!");
			}

			character.Bag.AddItem(pool.Pop());

			return $"{args[0]} picked up {character.Bag.Items.Last().GetType().Name}!";
		}

		public string UseItem(string[] args)
		{
			var character = party.FirstOrDefault(x => x.Name == args[0]);

			if (character is null)
			{
				throw new ArgumentException($"Character {args[0]} not found!");
			}

			var item = character.Bag.GetItem(args[1]);

			character.UseItem(item);

			return $"{args[0]} used {args[1]}.";
		}

		public string GetStats()
		{
			StringBuilder sb = new StringBuilder();

			foreach (var character in party.OrderByDescending(x => x.IsAlive).ThenByDescending(x => x.Health))
            {
				string status = character.IsAlive ? "Alive" : "Dead";
				sb.AppendLine($"{character.Name} - HP: {character.Health}/{character.BaseHealth}, AP: {character.Armor}/{character.BaseArmor}, Status: {status}");
            }

			return sb.ToString().TrimEnd();
		}

		public string Attack(string[] args)
		{
			var attacker = party.FirstOrDefault(x => x.Name == args[0]);
			var receiver = party.FirstOrDefault(x => x.Name == args[1]);

			if (attacker is null)
			{
				throw new ArgumentException($"Character {args[0]} not found!");
			}

			if (receiver is null)
			{
				throw new ArgumentException($"Character {args[1]} not found!");
			}

            if (attacker.GetType().Name != "Warrior")
            {
				throw new ArgumentException($"{args[0]} cannot attack!");
			}

			Warrior warrior = attacker as Warrior;
			warrior.Attack(receiver);

			string result = $"{warrior.Name} attacks {receiver.Name} for {warrior.AbilityPoints} hit points! {receiver.Name} has {receiver.Health}/{receiver.BaseHealth} HP and {receiver.Armor}/{receiver.BaseArmor} AP left!";

            if (!receiver.IsAlive)
            {
				result += $"{Environment.NewLine}{receiver.Name} is dead!";

			}

			return result;
		}

		public string Heal(string[] args)
		{
			var healer = party.FirstOrDefault(x => x.Name == args[0]);
			var receiver = party.FirstOrDefault(x => x.Name == args[1]);

			if (healer is null)
			{
				throw new ArgumentException($"Character {args[0]} not found!");
			}

			if (receiver is null)
			{
				throw new ArgumentException($"Character {args[1]} not found!");
			}

            if (healer.GetType().Name != "Priest")
            {
				throw new ArgumentException($"{args[0]} cannot heal!");
			}

			receiver.Health += healer.AbilityPoints;

			return $"{healer.Name} heals {receiver.Name} for {healer.AbilityPoints}! {receiver.Name} has {receiver.Health} health now!";
		}
	}
}
