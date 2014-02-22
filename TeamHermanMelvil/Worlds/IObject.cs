using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamHermanMelvil.Worlds
{
    interface IObject
    {
        void Draw(Position top);

        void Draw(Position top, Position position);

        void Draw(Position top, char vision);
    }
}
