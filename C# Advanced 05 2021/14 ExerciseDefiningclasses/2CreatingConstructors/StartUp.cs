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
        Person georgi = new Person(18);
        Person stamo = new Person("Stamat", 43);
        }
    }
}
