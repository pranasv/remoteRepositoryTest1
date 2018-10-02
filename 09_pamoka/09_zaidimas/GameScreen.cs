using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_zaidimas
{
    class GameScreen
    {
        private int Width;
        private int Height;
        private Hero hero;
        private List<Enemy> enemies = new List<Enemy>();

        public GameScreen(int x, int y)
        {
            Width = x;
            Height = y;
        }
        public void SetHero(Hero hero)
        {
            this.hero = hero;
        }
        public Hero GetHero()
        {
            return this.hero;
        }
        public void AddEnemy(Enemy enemy)
        {
            enemies.Add(enemy);
        }
        public void MoveAllEnemiesDown()
        {
            foreach (Enemy enemy in enemies)
            {
                enemy.MoveDown();
            }                     
        }
        public Enemy GetEnemyById(int id)
        {
            foreach(Enemy enemy in enemies)
            {
                if (enemy.GetId() == id)
                {
                    return enemy;
                }                
            }
            return null;
        }
        public void Render()
        {
        	hero.PrintInfo();
            foreach (Enemy enemy in enemies)
            {
                enemy.PrintInfo();
            }
        }
    }
}
