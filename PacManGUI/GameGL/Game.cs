using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using PacManGUI.GameGL;
namespace PacMan.GameGL
{
    public class Game
    {
        private static int Wave;
        private static List<HBullet> bullets = new List<HBullet>();
        private static List<Bullet> Pbullets = new List<Bullet>();
        public static List<Enemy> enemies = new List<Enemy>();

        internal static List<HBullet> Bullets { get => bullets; set => bullets = value; }
        internal static List<Bullet> Pbullets1 { get => Pbullets; set => Pbullets = value; }
        public static int Wave1 { get => Wave; set => Wave = value; }

        public static GameObject getBlankGameObject(){
            Image img = null;
            GameObject blankGameObject = new GameObject(GameObjectType.NONE, img);
            return blankGameObject;
        }
        public static Image getGameObjectImage(string displayCharacter)
        {
            Image img = null;
            if (displayCharacter == "CanonBall")
            {
                img = PacManGUI.Properties.Resources.canonBullet;
            }
            if (displayCharacter == "BossTruck")
            {
                img = PacManGUI.Properties.Resources.BossTruck;
            }
            if (displayCharacter == "BossACar")
            {
                img = PacManGUI.Properties.Resources.BossArmouredCar;
            }
            if (displayCharacter == "BossACar2")
            {
                img = PacManGUI.Properties.Resources.BossArmouredCar2;
            }
            if (displayCharacter == "BossUACar")
            {
                img = PacManGUI.Properties.Resources.BossUltimateArmouredCar;
            }
            if (displayCharacter == "BossUFirer")
            {
                img = PacManGUI.Properties.Resources.BossUltimateFirer;
            }
            if (displayCharacter == "BossUTank")
            {
                img = PacManGUI.Properties.Resources.BossUltimateTank;
            }
            if (displayCharacter == "MissileTank1M")
            {
                img = PacManGUI.Properties.Resources.BrownsSingleMissiles;
            }
            if (displayCharacter == "MissileTank2M")
            {
                img = PacManGUI.Properties.Resources.BrownsTwoMissiles;
            }
            if (displayCharacter == "Tank1")
            {
                img = PacManGUI.Properties.Resources.TankNo1;
            }
            if (displayCharacter == "Tank2")
            {
                img = PacManGUI.Properties.Resources.TankNo2;
            }
            if (displayCharacter == "Tank3")
            {
                img = PacManGUI.Properties.Resources.TankNo3;
            }
            if (displayCharacter == "Tank4")
            {
                img = PacManGUI.Properties.Resources.TankNo4;
            }
            if (displayCharacter == "Tank5")
            {
                img = PacManGUI.Properties.Resources.TankNo5;
            }
            if (displayCharacter == "Tank6")
            {
                img = PacManGUI.Properties.Resources.TankNo6;
            }
            if (displayCharacter == "Tank7")
            {
                img = PacManGUI.Properties.Resources.TankNo7;
            }
            if (displayCharacter == "Tank8")
            {
                img = PacManGUI.Properties.Resources.TankNo8;
            }
            if (displayCharacter == "GreensshootingCar")
            {
                img = PacManGUI.Properties.Resources.GreensHardCar;
            }
            if (displayCharacter == "GreensArmouredCar")
            {
                img = PacManGUI.Properties.Resources.GreensArmouredCar;
            }
            if (displayCharacter == "GreensCar")
            {
                img = PacManGUI.Properties.Resources.GreensCar2;
            }
            if (displayCharacter == "GreensArmouredTruck")
            {
                img = PacManGUI.Properties.Resources.GreensArmouredTruck;
            }
            if (displayCharacter == "GreensTruck")
            {
                img = PacManGUI.Properties.Resources.GreensTruck;
            }
            if (displayCharacter == "Rafale")
            {
                img = PacManGUI.Properties.Resources.Rafale;
            }
            if (displayCharacter == "WhiteAircraft")
            {
                img = PacManGUI.Properties.Resources.WhiteAircraft;
            }
            if (displayCharacter == "GreensHardCar")
            {
                img = PacManGUI.Properties.Resources.GreensHardCar;
            }
            if (displayCharacter == "GreensCanon")
            {
                img = PacManGUI.Properties.Resources.GreeensCanon;
            }
            if (displayCharacter == "SoliderMoving")
            {
                img = PacManGUI.Properties.Resources.Solider1Moving;
            }
            if (displayCharacter == "SoliderActive")
            {
                img = PacManGUI.Properties.Resources.SoliderActive;
            }
            if (displayCharacter == "ActiveCorp")
            {
                img = PacManGUI.Properties.Resources.ActiveCorp;
            }

            if (displayCharacter == "BrownsCar")
            {
                img = PacManGUI.Properties.Resources.BrownsCar;
            }
            if (displayCharacter == "BrownsOilTanker")
            {
                img = PacManGUI.Properties.Resources.BrownsOilTanker;
            }
            if (displayCharacter == "LightBrownTruck")
            {
                img = PacManGUI.Properties.Resources.Brow;
            }
            if (displayCharacter == "|" || displayCharacter == "%")
            {
                img = null;
            }

            if (displayCharacter == "#")
            {
                img = null;
            }

            if (displayCharacter == ".")
            {
                img = null;
            }
            if (displayCharacter == "P" || displayCharacter == "p") {
                img = PacManGUI.Properties.Resources.MyTank;
            }
            if (displayCharacter == "H" || displayCharacter == "H") {
                img = null;
            }
            if (displayCharacter == "F")
            {
                img = PacManGUI.Properties.Resources.BulletTank_removebg_preview;
            }
            if(displayCharacter=="TroopBullet")
            {
                img = PacManGUI.Properties.Resources.FireWBullet;

            }
            if (displayCharacter == "CorpBullet")
            {
                img = PacManGUI.Properties.Resources.Spell_Bullet;

            }
            if(displayCharacter=="Laser")
            {
                img = PacManGUI.Properties.Resources.AircraftLaserRed;
            }

            return img;
        }
    }
}
