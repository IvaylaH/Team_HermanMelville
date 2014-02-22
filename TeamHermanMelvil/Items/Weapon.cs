using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamHermanMelvil.Characters;

namespace TeamHermanMelvil.Items
{
    public abstract class Weapon : IWeapons
    {
        protected int Damage { get; set; }
        Random rand = new Random();

        public virtual void Fire(Character character)
        {
            character.ReduceLife(rand.Next(-3, 3) + this.Damage);
        }
    }
}
