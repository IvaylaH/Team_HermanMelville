using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamHermanMelvil.Worlds;

namespace TeamHermanMelvil.Obstacles
{
    public class Wall : Obstacle
    {
        public Wall(Position position)
            : base(position)
        {
            this.Vision = '#';
        }
    }
}
