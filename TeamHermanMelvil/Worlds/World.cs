using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TeamHermanMelvil.Obstacles;

namespace TeamHermanMelvil.Worlds
{
    public class World
    {
        Position top = new Position(1, 1);
        List<Obstacle> obstacles = new List<Obstacle>();

        public World()
        {
            this.InitializeMap("scene1.txt");
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
                            obstacles.Add(new Wall(new Position(x, y)));
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
            Console.WriteLine("");
        }
    }
}
