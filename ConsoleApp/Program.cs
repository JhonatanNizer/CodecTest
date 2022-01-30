using Controller;
using System;
using ConsoleApp.Helpers;

namespace ConsroleApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Set Mars plateau size (width X heigth): ");
            var size = Console.ReadLine();

            int width = InputHelper.GetWidthFromInput(size);
            int heigth = InputHelper.GetHeigthFromInput(size);

            IGridController controller = new GridController();
            controller.CreateGrid(width, heigth);

            
            Console.WriteLine("Set movement input (F, R, S, L)");
            var input = Console.ReadLine();

            //Console.WriteLine("Plateu size is: " + size + " - Input is: " + input);
        }
    }
}