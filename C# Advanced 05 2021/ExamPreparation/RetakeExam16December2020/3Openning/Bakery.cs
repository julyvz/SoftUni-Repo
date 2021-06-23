using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BakeryOpenning
{
    public class Bakery
    {
        private List<Employee> employees;
        
        public Bakery(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            employees = new List<Employee>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count => employees.Count;

        public void Add(Employee employee)
        {
            if (employees.Count < Capacity)
            {
                employees.Add(employee);
            }
        }

        public bool Remove(string name)
        {
            Employee toBeRemoved = employees.FirstOrDefault(x => x.Name == name);
            if (toBeRemoved == null)
            {
                return false;
            }
            else
            {
                employees.Remove(toBeRemoved);
                return true;
            }
        }

        public Employee GetOldestEmployee()
        {
            return employees.OrderByDescending(x => x.Age).First();
        }

        public Employee GetEmployee(string name)
        {
            return employees.FirstOrDefault(x => x.Name == name);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Employees working at Bakery {Name}:");
            foreach (var emp in employees)
            {
                sb.AppendLine(emp.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
