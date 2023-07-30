using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using PacMan.GameGL;

namespace PacManGUI.GameGL
{
    abstract class Bullet:GameObject
    {
        public Bullet(GameObjectType gameObjectType, Image image) : base(GameObjectType.PBULLET, image)
        {

        }

        public abstract GameCell move();
    }
}
