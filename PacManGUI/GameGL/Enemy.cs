using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using PacMan.GameGL;

namespace PacManGUI.GameGL
{
    public class Enemy:GameObject
    {
        public Enemy(Image ghost, GameCell startCell) : base(GameObjectType.GHOST, ghost)
        {
            CurrentCell = startCell;
        }
        public virtual GameCell Move(ref GameDirection direction)
        {
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(direction);
            this.CurrentCell = nextCell;
            if (currentCell != nextCell)
            {
                //if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.REWARD)
                //{
                //    GameObject rewardObject = new GameObject(GameObjectType.REWARD, PacManGUI.Properties.Resources.pallet);
                //    currentCell.setGameObject(rewardObject);
                //}
                if(nextCell.CurrentGameObject.GameObjectType==GameObjectType.PLAYER)
                {

                    currentCell.setGameObject(Game.getBlankGameObject());
                }
            }
            return nextCell;
        }
    }
}
