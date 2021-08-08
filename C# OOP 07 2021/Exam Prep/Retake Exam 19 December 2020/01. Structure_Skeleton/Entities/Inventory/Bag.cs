using System.Collections.Generic;
using WarCroft.Entities.Items;
using System.Linq;
using System;

namespace WarCroft.Entities.Inventory
{
    public abstract class Bag : IBag
    {
        private List<Item> items;

        protected Bag(int capacity) // Possible problem default Capacity 100
        {
            Capacity = capacity;
            items = new List<Item>();
        }

        public int Capacity { get; set; } = 100;

        public int Load { get => Items.Sum(i => i.Weight); }

        public IReadOnlyCollection<Item> Items { get => items.AsReadOnly(); }

        public void AddItem(Item item)
        {
            if (Load + item.Weight > Capacity)
            {
                throw new InvalidOperationException("Bag is full!");
            }

            items.Add(item);
        }

        public Item GetItem(string name)
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Bag is empty!");
            }

            var item = items.FirstOrDefault(x => x.GetType().Name == name);

            if (item is null)
            {
                throw new ArgumentException($"No item with name {name} in bag!");
            }

            items.Remove(item);

            return item;
        }
    }
}
