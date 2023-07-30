using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacMan.GameGL;
using System.Drawing;
namespace PacManGUI.GameGL
{
    public class HGhost : Enemy
    {
        public HGhost(Image HGhost, GameCell currentCell) : base(HGhost, currentCell)
        {

        } 
        public override GameCell Move(ref GameDirection direction)
        {

            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(direction);
            GameObject previousObject = nextCell.CurrentGameObject;
            this.CurrentCell = nextCell;
            if (currentCell != nextCell)
            {
                currentCell.setGameObject(previousObject);
            }
            else if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.PLAYER)
            {
                currentCell.CurrentGameObject.Image = null;
            }
            return nextCell;
        }
    }
}
