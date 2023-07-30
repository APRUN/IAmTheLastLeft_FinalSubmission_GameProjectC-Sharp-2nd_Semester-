using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacMan.GameGL;

namespace PacManGUI.GameGL
{
    class CollsionDetectors
    {
        public bool IsEnemeyCollidedwithPlayer(Enemy enemy)
        {
            bool flag = false;
                GameCell nextcell =enemy.CurrentCell.nextCell(GameDirection.Left);
                if(nextcell.CurrentGameObject.GameObjectType==GameObjectType.PLAYER)
                {
                    flag = true;
                }
            return flag;
        }
        public bool IsPlayerCollidedwithenemy(Player player,GameDirection dir)
        {
            bool flag = false;
                GameCell nextcell = player.CurrentCell.nextCell(dir);
            if (nextcell.CurrentGameObject.GameObjectType == GameObjectType.GHOST)
            {
                flag = true;
            }
            return flag;
        }
        public bool isBulletCollideWithEnemy(PBullet bullet)
        {
            bool flag = false;
            if (bullet.IsActive)
            {
                GameCell up = bullet.CurrentCell.nextCell(GameDirection.Right);
                if (up.CurrentGameObject.GameObjectType == GameObjectType.GHOST)
                {
                    return true;
                }
            }
            return flag;
        }
        public bool isBulletCollidedwithPlayer(HBullet bullet)
        {
            bool flag = false;
            if(bullet.IsActive)
            {
                GameCell nc = bullet.CurrentCell.nextCell(GameDirection.Left);
                if(nc.CurrentGameObject.GameObjectType==GameObjectType.PLAYER)
                {
                    flag= true;
                }
            }
            return flag;
        }
    }
}
