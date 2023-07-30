using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace PacMan.GameGL
{
    public class GameObject
    {
        string displayCharacter;
        GameObjectType gameObjectType;
        GameCell currentCell;
        Image image;
        protected bool Alive;
        protected int eHealth;

        public bool getAliveStatus()
        {
            return Alive;
        }
        public void setAliveStatus(bool status)
        {
            Alive=status;
        }
        protected int EHealth { get => eHealth; set => eHealth = value; }
        public void ResetEHealth(int total)
        {
            eHealth = total;
        }
        public void DecEHealth(int dec)
        {
            eHealth = eHealth - dec;
        }
        public void IncEHealth(int inc)
        {
            eHealth = eHealth + inc;
        }
        public GameObject(GameObjectType type, Image image)
        {
            Alive = true;
            this.gameObjectType = type;
            this.Image = image; 
        }
        public GameObject(GameObjectType type, string displayCharacter)
        {
            this.gameObjectType = type;
            this.displayCharacter = displayCharacter;
        }

        public static GameObjectType getGameObjectType(string displayCharacter) { 

            if (displayCharacter == "|" || displayCharacter == "%" || displayCharacter == "#") {
                return GameObjectType.WALL;
            }
            if(displayCharacter=="MyTank")
            {
                return GameObjectType.PLAYER;
            }
            if(displayCharacter=="CanonBall"|| displayCharacter == "TroopBullet" || displayCharacter == "CorpBullet" || displayCharacter == "Laser")
            {
                return GameObjectType.EBULLET;
            }
            if(displayCharacter == "F")
            {
                return GameObjectType.PBULLET;
            }
            if(displayCharacter == "LightBrownTruck"|| displayCharacter == "BrownsCar"|| displayCharacter == "ActiveCorp"|| displayCharacter == "SoliderActive"|| displayCharacter == "GreensCanon"|| displayCharacter == "SoliderMoving"|| displayCharacter == "GreensHardCar"|| displayCharacter == "WhiteAircraft"|| displayCharacter == "Rafale"|| displayCharacter == "GreensTruck"|| displayCharacter == "GreensArmouredTruck"|| displayCharacter == "GreensCar"|| displayCharacter == "GreensArmouredCar"|| displayCharacter == "GreensshootingCar"|| displayCharacter == "Tank4"|| displayCharacter == "Tank3"||displayCharacter == "Tank2"||displayCharacter == "Tank1"|| displayCharacter == "MissileTank2M"|| displayCharacter == "BossUTank"|| displayCharacter == "BossUFirer"|| displayCharacter == "BossUACar"|| displayCharacter == "BossACar2"|| displayCharacter == "BossACar"|| displayCharacter == "BossTruck")
            {
                return GameObjectType.ENEMY;
            }
            if (displayCharacter == ".") {
            return GameObjectType.REWARD;
            }

            return GameObjectType.NONE;
        }
        public string DisplayCharacter { get => displayCharacter; set => displayCharacter = value; }
        public GameObjectType GameObjectType { get => gameObjectType; set => gameObjectType = value; }
        public GameCell CurrentCell { 
            get => currentCell; 
            set  { 
                currentCell = value;
                currentCell.setGameObject(this);
            }
        }

        public Image Image { get => image; set => image = value; }
    }
}
