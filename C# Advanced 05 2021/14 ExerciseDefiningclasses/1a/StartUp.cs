using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
        Person peter = new Person();
            peter.Name = "Pesho";
            peter.Age = 20;
        Person georgi = new Person { Name = "Gosho", Age = 18 };
        Person stamo = new Person { Name = "Stamat", Age = 43 };
        }
    }
}
