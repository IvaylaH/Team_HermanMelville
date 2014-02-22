using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamHermanMelvil.Obstacles;
using TeamHermanMelvil.Worlds;

namespace TeamHermanMelvil.Characters
{
    public class Player : Character, IPlayer
    {

        public Player(Position position)
            :base(position)
        {
            life = 500;
            this.Vision = '@';
        }

        public override void Move(List<BaseObject> obstacles, Position top)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo userInput = Console.ReadKey(true);
                while (Console.KeyAvailable) Console.ReadKey(true);
                string checkInput = userInput.KeyChar.ToString().ToLower();

                switch (userInput.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (isPossibleMove(new Position(this.Position.x, this.Position.y - 1), obstacles))
                        {
                            this.Draw(top, new Position(this.Position.x, this.Position.y - 1));
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (isPossibleMove(new Position(this.Position.x, this.Position.y + 1), obstacles))
                        {
                            this.Draw(top, new Position(this.Position.x, this.Position.y + 1));
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (isPossibleMove(new Position(this.Position.x - 1, this.Position.y), obstacles))
                        {
                            this.Draw(top, new Position(this.Position.x - 1, this.Position.y));
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (isPossibleMove(new Position(this.Position.x + 1, this.Position.y), obstacles))
                        {
                            this.Draw(top, new Position(this.Position.x + 1, this.Position.y));
                        }
                        break;
                    case ConsoleKey.Spacebar:
                        break;
                    case ConsoleKey.Q:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
            base.Move(obstacles, top);
        }

        public void Heal()
        {
            throw new NotImplementedException();
        }

        public void Pick()
        {
            throw new NotImplementedException();
        }
    }
}
