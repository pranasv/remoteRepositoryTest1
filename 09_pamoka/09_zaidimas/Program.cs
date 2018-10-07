using _09_zaidimas.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _09_zaidimas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
           
            GameController gameController = new GameController();
            gameController.ShowMenu();

            Console.ReadKey();
        }
    }
}
