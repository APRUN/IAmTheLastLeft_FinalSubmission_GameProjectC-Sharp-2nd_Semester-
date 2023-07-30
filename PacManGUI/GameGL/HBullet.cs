using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacMan.GameGL;
using System.Drawing;

namespace PacManGUI.GameGL
{
    class HBullet:Bullet
    {
        GameDirection direction;
        bool isActive;

        public HBullet(GameDirection direction, Image image, GameCell startCell) : base(GameObjectType.EBULLET, image)
        {
            this.direction = direction;
            this.CurrentCell = startCell;

        }

        public bool IsActive { get => isActive; set => isActive = value; }

        public override GameCell move()
        {
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(direction);
            this.CurrentCell = nextCell;

            if (currentCell != nextCell)
            {
                currentCell.setGameObject(Game.getBlankGameObject());
            }
            else if (currentCell == nextCell)
            {
                this.CurrentCell.setGameObject(Game.getBlankGameObject());

            }
            return nextCell;
        }
    }
}
