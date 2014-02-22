using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamHermanMelvil.Worlds
{
    public class BaseObject : IObject
    {
        private Position position;
        protected ObjectType type;

        public BaseObject(Position position)
        {
            this.Position = position;
        }

        public ObjectType Type {get { return this.type; } }

        public Position Position
        {
            get
            {
                return this.position;
            }
            set
            {
                this.position = value;
            }
        }

        public char Vision
        {
            get;
            protected set;
        }

        public enum ObjectType
        {
            Character,
            Obstacle,
            Item
        }
    

        public void Draw(Position top)
        {
            this.Draw(top, this.Vision);
        }

        public void Draw(Position top, Position newPosition)
        {
            this.Draw(top, ' ');
            this.Position = newPosition;
            this.Draw(top, this.Vision);
        }

        public void Draw(Position top, char vision)
        {
            if (((top.x <= this.Position.x) && (top.x + 79 > this.Position.x)) && (((top.y <= this.Position.y) && (top.y + 24 > this.Position.y))))
            {
                Console.SetCursorPosition(this.Position.x, this.Position.y);
                Console.Write(vision);
            }
        }
    }
}
