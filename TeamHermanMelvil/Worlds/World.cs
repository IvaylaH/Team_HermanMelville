using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TeamHermanMelvil.Obstacles;
using TeamHermanMelvil.Characters;
using System.Threading;

namespace TeamHermanMelvil.Worlds
{
    public class World
    {
        Position top = new Position(1, 1);
        List<Obstacle> obstacles = new List<Obstacle>();
        List<BaseObject> objects = new List<BaseObject>();
        //TODO: да се позиционира в средата на полето, като се направи проверка дали е възможно да седи в средата
        Player player = new Player(new Position(3, 3));
        IEnumerable<Enemy> enemies = new List<Enemy>(); //!!

        public World()
        {
            this.InitializeMap("scene1.txt");
            enemies = Enemy.CreateEnemies(objects);
            //Инициализация на противниците
        }

        public void InitializeMap(string sceneName)
        {
            int x = 1;
            int y = 1;

            StreamReader reader = new StreamReader("Data\\Maps\\" + sceneName);
            using (reader)
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    foreach (char c in line)
                    {
                        if (c.Equals('#'))
                        {
                            Wall wall = new Wall(new Position(x, y));
                            obstacles.Add(wall);
                            objects.Add(wall);
                        }
                        x++;
                    }
                    x = 1;
                    y++;
                }
            }
        }

        public void Draw()
        {
            foreach (var obstacle in obstacles)
            {
                obstacle.Draw(this.top);
            }
            Console.WriteLine("");  // why do we have it here?

            foreach (var enemy in enemies)
            {
                enemy.Draw(this.top);
            }
        }

     /*   public void Draw(IEnumerable<Enemy> enemies)
        {
           
        }*/


        public void Play()
        {
            player.Draw(top);
            //Изчертаване на противниците
            while (true)
            {
                player.Move(objects, top);
                //Цикъл, за преместване на противниците

                Thread.Sleep(100);
            }
        }
    }
}
