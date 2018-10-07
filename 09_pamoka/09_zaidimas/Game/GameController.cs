using _09_zaidimas.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_zaidimas.Game
{
    class GameController
    {
        private GameWindow gameWindow = new GameWindow();
        private CreditWindow crediteWindow = new CreditWindow();

        public void ShowMenu()
        {
            ConsoleKeyInfo keyPressed;
            do
            {
                gameWindow.Render();
                keyPressed = Console.ReadKey(true);
                switch (keyPressed.Key)
                {                                           
                    case ConsoleKey.LeftArrow:
                        gameWindow.SellectNextMenuItem();
                        break;
                    case ConsoleKey.RightArrow:
                        gameWindow.SellectNextMenuItem();
                        break;

                }
            } while (keyPressed.Key != ConsoleKey.Escape);
        }
        private void StartGame()
        {
            // init game
            GameScreen myGame = new GameScreen(30, 20);

            // fill game with game data.
            myGame.SetHero(new Hero(5, 5, "HERO"));

            Random rnd = new Random();
            int enemyCount = 0;
            for (int i = 0; i < 10; i++)
            {
                myGame.AddEnemy(new Enemy(enemyCount, rnd.Next(0, 10), rnd.Next(0, 10), "enemy" + enemyCount));
                enemyCount++;
            }

            // render loop
            bool needToRender = true;

            do
            {
                // isvalom ekrana
                Console.Clear();

                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedChar = Console.ReadKey(true);
                    int hashCode = pressedChar.Key.GetHashCode();

                    switch (hashCode)
                    {
                        case 27: //ConsoleKey.Escape:
                            needToRender = false;
                            break;
                        case 39: // ConsoleKey.RightArrow:
                            myGame.GetHero().MoveRight();
                            break;
                        case 37: // ConsoleKey.LeftArrow:
                            myGame.GetHero().MoveLeft();
                            break;
                    }
                }

                myGame.Render();

                System.Threading.Thread.Sleep(250);
            } while (needToRender);
        }
    }
}
