using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamHermanMelvil.Worlds;

namespace TeamHermanMelvil.Obstacles
{
    interface IObstacle
    {
        void Show(Position top);

        void Hide(Position top);
    }
}
