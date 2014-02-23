using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamHermanMelvil.Worlds;
using TeamHermanMelvil.Items;
using TeamHermanMelvil.Obstacles;

namespace TeamHermanMelvil.Characters
{
    public abstract class Character : BaseObject, ICharacter
    {
        protected Weapon weapon;
        protected int life;
        protected bool isAlive; // either here or in class enemy

        public Character(Position position)
            : base(position)
        {
            type = ObjectType.Character;
        }

        public virtual void Move(List<BaseObject> obstacles, Position top)
        {
            
        }

        public void Attack()
        {
            throw new NotImplementedException();
        }


        public void Damage(int damage)
        {
            this.life -= damage;
        }

        protected bool isPossibleMove(Position position, List<BaseObject> obstacles)
        {
            foreach (BaseObject obstacle in obstacles)
            {
                if ((obstacle.Type != ObjectType.Item) && (obstacle.Position.Equals(position)))
                {
                    return false;
                }
            }

            return true;
        }


        public void Damage()
        {
            throw new NotImplementedException();
        }

        public void ReduceLife(int reduce) {
            this.life -= reduce;
        }
    }
}
