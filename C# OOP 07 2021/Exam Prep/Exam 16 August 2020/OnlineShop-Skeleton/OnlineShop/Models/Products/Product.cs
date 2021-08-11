using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Models.Products
{
    public abstract class Product : IProduct
    {
        private int id;
        private decimal price;
        private double overallPerformance;


        public Product(int id, string manufacturer, string model, decimal price, double overallPerformance)
        {
            if (string.IsNullOrWhiteSpace(manufacturer))
            {
                throw new ArgumentException("Manufacturer can not be empty.");
            }

            if (string.IsNullOrWhiteSpace(model))
            {
                throw new ArgumentException("Model can not be empty.");
            }

            Id = id;
            Manufacturer = manufacturer;
            Model = model;
            Price = price;
            OverallPerformance = overallPerformance;
        }

        public int Id
        {
            get => id;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Id can not be less or equal than 0.");
                }

                id = value;
            }
        }

        public string Manufacturer { get; }

        public string Model { get; }

        public virtual decimal Price
        {
            get => price;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price can not be less or equal than 0.");
                }

                price = value;
            }
        }

        public virtual double OverallPerformance
        {
            get => overallPerformance;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Overall Performance can not be less or equal than 0.");
                }

                overallPerformance = value;
            }
        }

        public override string ToString()
        {
            return $"Overall Performance: {OverallPerformance:F2}. Price: {Price:F2} - {this.GetType().Name}: {Manufacturer} {Model} (Id: {Id})";
        }
    }
}
