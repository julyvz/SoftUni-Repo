using System;
using System.Collections.Generic;
using System.Text;

namespace _3ShoppingSpree
{
   public class Person
    {

        private string name;
        private int money;
        private List<string> bagOfProducts;

        public Person(string name, int money)
        {
            Name = name;
            Money = money;
            bagOfProducts = new List<string>();
        }

        public List<string> BagOfProducts
        {
            get { return bagOfProducts; }
        }

        public string Name
        {
            get { return name; }
            set 
            {
                if (string.IsNullOrWhiteSpace(value)) // В условието всъщност не пише, че не може да е "whiteSpace". Даже си пише с дебели букви, че не трябва да е "empty string". Така че проверката ми за IsNullorEmpty изгърмя, а IsNullorWhiteSpace мина.

                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value; 
            }
        }

        public int Money
        {
            get { return money; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value;
            }
        }

        public void AddToBag(string prodName)
        {
            bagOfProducts.Add(prodName);
        }
    }
}
