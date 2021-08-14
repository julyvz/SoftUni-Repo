using OnlineShop.Models.Products.Computers;
using OnlineShop.Models.Products.Peripherals;
using System;
using System.Collections.Generic;
using OnlineShop.Models.Products.Components;
using System.Linq;
using System.Text;

namespace OnlineShop.Core
{
    public class Controller : IController
    {
        private List<IComputer> computers;
        private List<IComponent> components;
        private List<IPeripheral> peripherals;

        public Controller()
        {
            computers = new List<IComputer>();
            components = new List<IComponent>();
            peripherals = new List<IPeripheral>();
        }

        public string AddComponent(int computerId, int id, string componentType, string manufacturer, string model, decimal price, double overallPerformance, int generation)
        {
            var computer = EnsureComputerExists(computerId);

            if (components.Any(x => x.Id == id))
            {
                throw new ArgumentException("Component with this id already exists.");
            }

            IComponent component;

            switch (componentType)
            {
                case "CentralProcessingUnit":
                    component = new CentralProcessingUnit(id, manufacturer, model, price, overallPerformance, generation);
                    computer.AddComponent(component);
                    components.Add(component);
                    break;

                case "Motherboard":
                    component = new Motherboard(id, manufacturer, model, price, overallPerformance, generation);
                    computer.AddComponent(component);
                    components.Add(component);
                    break;

                case "PowerSupply":
                    component = new PowerSupply(id, manufacturer, model, price, overallPerformance, generation);
                    computer.AddComponent(component);
                    components.Add(component);
                    break;

                case "RandomAccessMemory":
                    component = new RandomAccessMemory(id, manufacturer, model, price, overallPerformance, generation);
                    computer.AddComponent(component);
                    components.Add(component);
                    break;

                case "SolidStateDrive":
                    component = new SolidStateDrive(id, manufacturer, model, price, overallPerformance, generation);
                    computer.AddComponent(component);
                    components.Add(component);
                    break;

                case "VideoCard":
                    component = new VideoCard(id, manufacturer, model, price, overallPerformance, generation);
                    computer.AddComponent(component);
                    components.Add(component);
                    break;

                default:
                    throw new ArgumentException("Component type is invalid.");
            }

            return $"Component {componentType} with id {id} added successfully in computer with id {computerId}.";
        }

        private IComputer EnsureComputerExists(int id)
        {
            var computer = computers.FirstOrDefault(c => c.Id == id);

            if (computer is null)
            {
                throw new ArgumentException("Computer with this id does not exist.");
            }

            return computer;
        }

        public string AddComputer(string computerType, int id, string manufacturer, string model, decimal price)
        {
            if (computers.Any(c => c.Id == id))
            {
                throw new ArgumentException("Computer with this id already exists.");
            }

            switch (computerType)
            {
                case "DesktopComputer":
                    computers.Add(new DesktopComputer(id, manufacturer, model, price));
                    break;

                case "Laptop":
                    computers.Add(new Laptop(id, manufacturer, model, price));
                    break;

                default:
                    throw new ArgumentException("Computer type is invalid.");
            }

            return $"Computer with id {id} added successfully.";
        }

        public string AddPeripheral(int computerId, int id, string peripheralType, string manufacturer, string model, decimal price, double overallPerformance, string connectionType)
        {
            var computer = EnsureComputerExists(computerId);

            if (peripherals.Any(x => x.Id == id))
            {
                throw new ArgumentException("Peripheral with this id already exists.");
            }

            IPeripheral peripheral;

            switch (peripheralType)
            {
                case "Headset":
                    peripheral = new Headset(id, manufacturer, model, price, overallPerformance, connectionType);
                    computer.AddPeripheral(peripheral);
                    peripherals.Add(peripheral);
                    break;

                case "Keyboard":
                    peripheral = new Keyboard(id, manufacturer, model, price, overallPerformance, connectionType);
                    computer.AddPeripheral(peripheral);
                    peripherals.Add(peripheral);
                    break;

                case "Monitor":
                    peripheral = new Monitor(id, manufacturer, model, price, overallPerformance, connectionType);
                    computer.AddPeripheral(peripheral);
                    peripherals.Add(peripheral);
                    break;

                case "Mouse":
                    peripheral = new Mouse(id, manufacturer, model, price, overallPerformance, connectionType);
                    computer.AddPeripheral(peripheral);
                    peripherals.Add(peripheral);
                    break;

                default:
                    throw new ArgumentException("Peripheral type is invalid.");
            }

            return $"Peripheral {peripheralType} with id {id} added successfully in computer with id {computer.Id}.";
        }

        public string BuyBest(decimal budget)
        {
            var computer = computers.Where(c => c.Price <= budget).OrderByDescending(c => c.OverallPerformance).FirstOrDefault();

            if (computer is null)
            {
                throw new ArgumentException($"Can't buy a computer with a budget of ${budget}.");
            }

            computers.Remove(computer);
            return computer.ToString();
        }

        public string BuyComputer(int id)
        {
            var computer = EnsureComputerExists(id);

            computers.Remove(computer);

            return computer.ToString();
        }

        public string GetComputerData(int id)
        {
            var computer = EnsureComputerExists(id);

            return computer.ToString();
        }

        public string RemoveComponent(string componentType, int computerId)
        {
            var computer = EnsureComputerExists(computerId);            

            IComponent component = computer.RemoveComponent(componentType);

            components.Remove(component);

            return $"Successfully removed {componentType} with id {component.Id}.";
        }

        public string RemovePeripheral(string peripheralType, int computerId)
        {
            var computer = EnsureComputerExists(computerId);
            IPeripheral peripheral = computer.RemovePeripheral(peripheralType);

            peripherals.Remove(peripheral);

            return $"Successfully removed {peripheralType} with id {peripheral.Id}.";
        }
    }
}
