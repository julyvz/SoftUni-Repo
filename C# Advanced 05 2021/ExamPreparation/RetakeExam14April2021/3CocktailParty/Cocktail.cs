using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CocktailParty
{
    public class Cocktail
    {
        private List<Ingredient> Ingredients;
        public Cocktail(string name, int capacity, int maxAlcoholLevel)
        {
            Name = name;
            Capacity = capacity;
            MaxAlcoholLevel = maxAlcoholLevel;
            Ingredients = new List<Ingredient>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int MaxAlcoholLevel { get; set; }
        public int CurrentAlcoholLevel => Ingredients.Sum(x => x.Alcohol);

        public void Add(Ingredient ingredient)
        {
            Ingredient ingredientInCocktail = this.Ingredients.FirstOrDefault(x => x.Name == ingredient.Name);
            if (ingredientInCocktail == null && this.Ingredients.Count < this.Capacity && CurrentAlcoholLevel + ingredient.Alcohol <= this.MaxAlcoholLevel)
            {
                this.Ingredients.Add(ingredient);
            }
        }

        public bool Remove(string name)
        {
            bool result = false;
            Ingredient toBeRemoved = null;
            foreach (var ingredient in Ingredients)
            {
                if (ingredient.Name == name)
                {
                    result = true;
                    toBeRemoved = ingredient;
                    break;
                }
            }
            if (result)
            {
                Ingredients.Remove(toBeRemoved);
            }
            return result;
        }

        public Ingredient FindIngredient(string name)
        {
            Ingredient toBeReturned = null;
            foreach (var ingredient in Ingredients)
            {
                if (ingredient.Name == name)
                {
                    toBeReturned = ingredient;
                    break;
                }
            }
            return toBeReturned;
        }

        public Ingredient GetMostAlcoholicIngredient()
        {
            Ingredient toBeReturned = Ingredients.OrderByDescending(x => x.Alcohol).FirstOrDefault();
            return toBeReturned;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cocktail: {Name} - Current Alcohol Level: {CurrentAlcoholLevel}");
            foreach (var ingr in Ingredients)
            {
                sb.AppendLine($"{ingr}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
