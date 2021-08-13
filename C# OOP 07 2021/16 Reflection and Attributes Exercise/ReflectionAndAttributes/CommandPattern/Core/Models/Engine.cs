using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Core.Models
{
    public class Engine : IEngine
    {
        private ICommandInterpreter command;
        
        public Engine(ICommandInterpreter command)
        {
            this.command = command;
        }
        
        public void Run()
        {
            while (true)
            {
                string inputLine = Console.ReadLine();

               string result = command.Read(inputLine);

                if (result is null)
                {
                    break;
                }

                Console.WriteLine(result);
            }
        }
    }
}
