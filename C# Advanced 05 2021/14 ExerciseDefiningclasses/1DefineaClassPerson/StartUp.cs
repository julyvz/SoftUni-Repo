using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person peter = new Person();
            peter.Name = "Pesho";
            peter.Age = 20;
            var georgi = new Person { Name = "Gosho", Age = 18 };
            var stamo = new Person { Name = "Stamat", Age = 43 };
        }
    }
}
