using OnlineShop.Models.Products.Components;
using OnlineShop.Models.Products.Peripherals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShop.Models.Products.Computers
{
    public abstract class Computer : Product, IComputer
    {
        private readonly List<IComponent> components;
        private readonly List<IPeripheral> peripherals;

        protected Computer(int id, string manufacturer, string model, decimal price, double overallPerformance)
            : base(id, manufacturer, model, price, overallPerformance)
        {
            components = new List<IComponent>();
            peripherals = new List<IPeripheral>();
        }

        public IReadOnlyCollection<IComponent> Components { get => components.AsReadOnly(); }

        public IReadOnlyCollection<IPeripheral> Peripherals { get => peripherals.AsReadOnly(); }

        public override double OverallPerformance //PP
        {
            get
            {
                if (!this.Components.Any())
                {
                    return base.OverallPerformance;
                }

                return base.OverallPerformance + components.Average(c => c.OverallPerformance);
            }
        }

        public override decimal Price  // PP
        {
            get
            {
                decimal componentsPrice = this.Components.Any() ? this.Components.Sum(c => c.Price) : 0;
                decimal peripheralsPrice = this.Peripherals.Any() ? this.Peripherals.Sum(p => p.Price) : 0;

                return base.Price + componentsPrice + peripheralsPrice;
            }
        }

        public void AddComponent(IComponent component)
        {
            
            
            if (components.Any(c => c.GetType().Name == component.GetType().Name))
            {
                throw new ArgumentException($"Component {component.GetType().Name} already exists in {this.GetType().Name} with Id {Id}.");
            }

            components.Add(component);
        }

        public void AddPeripheral(IPeripheral peripheral)
        {
            if (peripherals.Any(p => p.GetType().Name == peripheral.GetType().Name))
            {
                throw new ArgumentException($"Peripheral {peripheral.GetType().Name} already exists in {this.GetType().Name} with Id {Id}.");
            }

            peripherals.Add(peripheral);
        }

        public IComponent RemoveComponent(string componentType)
        {
            var component = components.FirstOrDefault(c => c.GetType().Name == componentType);

            if (component is null)
            {
                throw new ArgumentException($"Component {componentType} does not exist in {GetType().Name} with Id {Id}.");
            }

            components.Remove(component);

            return component;
        }

        public IPeripheral RemovePeripheral(string peripheralType)
        {
            var peripheral = peripherals.FirstOrDefault(p => p.GetType().Name == peripheralType);

            if (peripheral is null)
            {
                throw new ArgumentException($"Peripheral {peripheralType} does not exist in {GetType().Name} with Id {Id}.");
            }

            peripherals.Remove(peripheral);

            return peripheral;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());

            sb.AppendLine($" Components ({components.Count}):");
            foreach (var component in components)
            {
                sb.AppendLine("  " + component.ToString());
            }

            double avgOverallPerformance = 0;
            if (peripherals.Count > 0)
            {
                avgOverallPerformance = peripherals.Average(p => p.OverallPerformance);
            }

            sb.AppendLine($" Peripherals ({peripherals.Count}); Average Overall Performance ({avgOverallPerformance:F2}):");

            foreach (var peripheral in peripherals)
            {
                sb.AppendLine("  " + peripheral.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
