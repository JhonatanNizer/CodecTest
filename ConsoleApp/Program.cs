using Controller.Controllers;
using Controller.Interfaces;

namespace ConsroleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           IGameController gameController = new GameController();
           gameController.Run();
        }   
    }
}