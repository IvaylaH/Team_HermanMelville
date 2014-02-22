using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamHermanMelvil.Obstacles;
using TeamHermanMelvil.Worlds;

namespace TeamHermanMelvil.Characters
{
    interface ICharacter
    {
        void Move(List<BaseObject> obstacles, Position top);

        void Attack();

        void Damage();

        void ReduceLife(int reduce);
    }
}
