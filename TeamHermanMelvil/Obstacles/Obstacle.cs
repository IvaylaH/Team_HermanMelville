using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamHermanMelvil.Worlds;

namespace TeamHermanMelvil.Obstacles
{
    public class Obstacle : BaseObject, IObstacle
    {
        public Obstacle(Position position)
            : base(position)
        {
   
        }

        public void Show(Position top)
        {
            base.Draw(top);
        }

        public void Hide(Position top)
        {
            base.Draw(top, ' ');
        }
    }
}
