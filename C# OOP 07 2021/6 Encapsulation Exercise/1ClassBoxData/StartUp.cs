using System;

namespace ClassBoxData
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Box myBox;

            try
            {
                myBox = new Box(length, width, height);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            Console.WriteLine($"Surface Area - {myBox.SurfaceArea():F2}");
            Console.WriteLine($"Lateral Surface Area - {myBox.LateralSurfaceArea():F2}");
            Console.WriteLine($"Volume - {myBox.Volume():F2}");
        }
    }
}
