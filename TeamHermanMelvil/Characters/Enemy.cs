using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamHermanMelvil.Worlds;

namespace TeamHermanMelvil.Characters
{
    public class Enemy : Character, IEnemy
    {
        private static List<Enemy> enemies = new List<Enemy>();
        private static Random generatePosition = new Random(); // generates random position for the enemy
        private static Random generateNumOfEnemies = new Random();
     //   private bool isAlive;

        public Enemy(Position position)
            : base(position)
        {
            life = 200; //?!?
            this.Vision = 'X';
            isAlive = true;
        }

        public virtual void Move(List<BaseObject> obstacles, Position top)
        {
            while (true)
            {
                
            }
        }

        public static IEnumerable<Enemy> CreateEnemies(List<BaseObject> objects)
        {
            int numberOfEnemiesPerLevel = generateNumOfEnemies.Next(10, 16); // optional number of enemies

            for (int i = 0; i < numberOfEnemiesPerLevel; i++)
            {
                // can use variables for the size of the screen, so we don't need to use magic numbers
                Position position = new Position(generatePosition.Next(0, 168 + 1), generatePosition.Next(0, 52 + 1));
                if (CanCreateEnemy(position, objects))
                {
                    Enemy enemy = new Enemy(position);
                    enemies.Add(enemy);
                    objects.Add(enemy);
                }  
            }

            return enemies;
        }
        public static bool CanCreateEnemy(Position position, List<BaseObject> objects)
        {
            foreach (BaseObject obj in objects)
            {
                if (obj.Position.Equals(position))
                {
                    return false;
                }
            }
            return true;
        }

        public void CallHelp()
        {
            throw new NotImplementedException();
        }
    }
}
