namespace Aquariums
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
           Aquarium aquarium = new Aquarium("My", 3);
            aquarium.Add(new Fish("Nemo"));
            aquarium.Add(new Fish("Pipi"));

            Console.WriteLine(aquarium.Report());
        }
    }
}
