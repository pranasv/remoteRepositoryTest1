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
            /*	//STEP1
        	Hero zaidejas1 = new Hero("Pranas");
            zaidejas1.PrintInfo();
            zaidejas1.MoveRight();
            zaidejas1.PrintInfo();
            List<Enemy> priesas = new List<Enemy>();
            Random RND = new Random();
            for (int i = 0; i<10; i++)
            {
                string name = "Enemy" + Convert.ToString(i+1);
                priesas.Add(new Enemy(i, RND.Next(0,100), RND.Next(0,20, name)));                
            }
            foreach (Enemy item in priesas)
            {
                item.PrintInfo();
            }*/
            
            //STEP2
            GameScreen MyGame = new GameScreen(100,30);
            Hero Player = new Hero(50,30,"Player1");
            MyGame.SetHero(Player);
            Random RND = new Random();
            for (int i=0; i<10; i++)
            {
            	MyGame.AddEnemy(new Enemy(i,RND.Next(0,100),RND.Next(0,30),"Enemy"+(i+1)));
            }
            MyGame.Render();            
            
            // Console.ReadKey();
            //STEP4
            bool needToRender = true;
            do
            {
            	Console.Clear();
            	
            	while(Console.KeyAvailable)
            	{
            		ConsoleKeyInfo PressedChar = Console.ReadKey(true);
            		switch (PressedChar.Key)
            		{
            			case ConsoleKey.Escape:
            				needToRender = false;            				
            				break;
            			case ConsoleKey.RightArrow:
            				Player.MoveRight();
            				break;
            			case ConsoleKey.LeftArrow:
            				Player.MoveLeft();
            				break;
            		}
            	}
            	
            	
            	MyGame.Render();
            	System.Threading.Thread.Sleep(50);
            }            
            while(needToRender);
            
        }
    }
}
