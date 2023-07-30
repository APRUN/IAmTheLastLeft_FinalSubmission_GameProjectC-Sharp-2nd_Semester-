using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PacMan.GameGL;
using EZInput;
using PacManGUI.GameGL;
namespace PacManGUI
{
    public partial class Form1 : Form
    {
        Player PTank;


        HGhost BCar1;
        HGhost Corp1;
        HGhost Corp2;
        HGhost BTruck1;
        HGhost Solider1;
        HGhost Solider2;
        HGhost Solider3;
        HGhost GreensCanon1;
        HGhost GreensCanon2;
        HGhost B51Plane;
        HGhost RafalePlane;
        HGhost ETank1;
        HGhost BossTruck;
        HGhost BossUACar;
        HGhost BossUFirer;
        HGhost BossUTank;
        HGhost BossACar;
        HGhost BossACar2;
        HGhost Tank1;
        HGhost Tank2;
        HGhost Tank3;
        HGhost Tank4;
        HGhost Tank5;
        HGhost Tank6;
        HGhost Tank7;

        CollsionDetectors collider = new CollsionDetectors();
        GamePlayMenu gm = new GamePlayMenu();

       

        GameDirection HorizontalGhostDir = GameDirection.Left;
        GameGrid grid;

        int timer = 0;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            grid = new GameGrid("maze.txt", 20, 40);
            Image pacManImage = Game.getGameObjectImage("P");
            GameCell startCell = grid.getCell(8, 10);
            PTank = new Player(pacManImage, startCell);
            if (Game.Wave1 == 1)
            {
                Wave1();
            }
            if (Game.Wave1 == 2)
            {
                Wave2();
            }
            if (Game.Wave1 == 3)
            {
                FinalWave();
            }
            if (Game.Wave1 == 4)
            {
                TankFightWave();
            }


            printMaze(grid);
            
        }
        public void TankFightWave()
        {
            Tank1 = GenerateCharacter(4,36,"Tank1",Tank1);
            Tank2 = GenerateCharacter(6,36,"Tank2",Tank2);
            Tank3 = GenerateCharacter(7,36,"Tank3",Tank3);
            Tank4 = GenerateCharacter(9,36,"Tank4",Tank4);
            Tank5 = GenerateCharacter(12,36,"Tank5",Tank5);
            Tank6 = GenerateCharacter(14,36,"Tank6",Tank6);
            Tank7 = GenerateCharacter(18,36,"Tank7",Tank7);

            Game.enemies.Add(Tank1);
            Game.enemies.Add(Tank2);
            Game.enemies.Add(Tank3);
            Game.enemies.Add(Tank4);
            Game.enemies.Add(Tank5);
            Game.enemies.Add(Tank6);
            Game.enemies.Add(Tank7);
        }
        public void FinalWave()
        {
            BossTruck = GenerateCharacter(7,37,"BossTruck",BossTruck);
            BossUACar = GenerateCharacter(12,37,"BossUACar",BossUACar);
            BossUFirer = GenerateCharacter(10,36,"BossUFirer",BossUFirer);
            BossUTank = GenerateCharacter(14,36,"BossUTank",BossUTank);
            BossACar = GenerateCharacter(5,37,"BossACar",BossACar);
            BossACar2 = GenerateCharacter(17,37,"BossACar2",BossACar2);

            Game.enemies.Add(BossTruck);
            Game.enemies.Add(BossUACar);
            Game.enemies.Add(BossUFirer);
            Game.enemies.Add(BossUTank);
            Game.enemies.Add(BossACar);
            Game.enemies.Add(BossACar2);
        }
        public void Wave2()
        {
            ETank1 = GenerateCharacter(15, 37, "Tank1", ETank1);
            Corp1 = GenerateCharacter(13, 37, "ActiveCorp", Corp1);
            Corp2 = GenerateCharacter(14, 37, "ActiveCorp", Corp2);
            RafalePlane = GenerateCharacter(16, 33, "Rafale", RafalePlane);
            B51Plane = GenerateCharacter(5, 33, "WhiteAircraft", B51Plane);
            GreensCanon1 = GenerateCharacter(9, 33, "GreensCanon", GreensCanon1);
            GreensCanon2 = GenerateCharacter(4, 32, "GreensCanon", GreensCanon2);

            Game.enemies.Add(Corp1);
            Game.enemies.Add(Corp2);
            Game.enemies.Add(ETank1);
            Game.enemies.Add(B51Plane);
            Game.enemies.Add(GreensCanon1);
            Game.enemies.Add(GreensCanon2);
        }
        public void Wave1()
        {
            GreensCanon1 = GenerateCharacter(9, 33, "GreensCanon", GreensCanon1);
            BTruck1 = GenerateCharacter(8, 38, "LightBrownTruck", BTruck1);
            BCar1 = GenerateCharacter(8, 36, "BrownsCar", BCar1);
            Solider1 = GenerateCharacter(7, 37, "SoliderActive", Solider1);
            Solider2 = GenerateCharacter(6, 36, "SoliderActive", Solider2);
            Solider3 = GenerateCharacter(5, 36, "SoliderActive", Solider3);


            Game.enemies.Add(BTruck1);
            Game.enemies.Add(BCar1);
            Game.enemies.Add(Solider1);
            Game.enemies.Add(Solider2);
            Game.enemies.Add(Solider3);
            Game.enemies.Add(GreensCanon1);
        }
        HGhost GenerateCharacter(int x, int y, string type, HGhost HorGhost)
        {
            Image CharacterImg = Game.getGameObjectImage(type);
            GameCell startCell = grid.getCell(x, y);
            HorGhost = new HGhost(CharacterImg, startCell);
            return HorGhost;
        }


        void printMaze(GameGrid grid)
        {
            for (int x = 0; x < grid.Rows; x++)
            {
                for (int y = 0; y < grid.Cols; y++)
                {
                    GameCell cell = grid.getCell(x, y);
                    this.Controls.Add(cell.PictureBox);          
            //        printCell(cell);
                }
            }
        }

        static void printCell(GameCell cell)
        {
            Console.SetCursorPosition(cell.Y, cell.X);
            Console.Write(cell.CurrentGameObject.DisplayCharacter);
        }

        private void gameLoop_Tick(object sender, EventArgs e)
        {
            timer++;
            if(Keyboard.IsKeyPressed(Key.LeftArrow)) {
                if(!(collider.IsPlayerCollidedwithenemy(PTank,GameDirection.Left)))
                {
                    PTank.move(GameDirection.Left);
                }
            }
            if (Keyboard.IsKeyPressed(Key.RightArrow)){
                if (!(collider.IsPlayerCollidedwithenemy(PTank, GameDirection.Right)))
                {
                    PTank.move(GameDirection.Right);
                }
                
            }
            if (Keyboard.IsKeyPressed(Key.UpArrow)){
                if (!(collider.IsPlayerCollidedwithenemy(PTank, GameDirection.Up)))
                {
                    PTank.move(GameDirection.Up);
                }
                
            }
            if (Keyboard.IsKeyPressed(Key.DownArrow))
            {
                if (!(collider.IsPlayerCollidedwithenemy(PTank, GameDirection.Down)))
                {
                    PTank.move(GameDirection.Down);
                }
                
            }
            if (Keyboard.IsKeyPressed(Key.Space))
            {
                GeneratePlayerBullet();
            }
            if (Game.Wave1 == 1)
            {

                if (timer % 6 == 0)
                {

                    if(!(collider.IsEnemeyCollidedwithPlayer(BTruck1)))
                    {
                            BTruck1.Move(ref HorizontalGhostDir);
                        
                    }

                }
                if (timer % 9 == 0)
                {
                    if (!(collider.IsEnemeyCollidedwithPlayer(Solider1)))
                    {
                        Solider1.Move(ref HorizontalGhostDir);
                    }
                    if (!(collider.IsEnemeyCollidedwithPlayer(Solider2)))
                    {
                        Solider3.Move(ref HorizontalGhostDir);
                    }
                    if (!(collider.IsEnemeyCollidedwithPlayer(Solider3)))
                    {
                        Solider2.Move(ref HorizontalGhostDir);
                    }
                }
                if (SearchPlayer(Solider1))
                {
                    GenerateBullets(7, Solider1.CurrentCell.nextCell(GameDirection.Left).Y, PacMan.GameGL.Game.getGameObjectImage("TroopBullet"));
                }
                if (SearchPlayer(Solider2))
                {
                    GenerateBullets(6, Solider2.CurrentCell.nextCell(GameDirection.Left).Y, PacMan.GameGL.Game.getGameObjectImage("TroopBullet"));
                }
                if (SearchPlayer(Solider3))
                {
                    GenerateBullets(5, Solider3.CurrentCell.nextCell(GameDirection.Left).Y, PacMan.GameGL.Game.getGameObjectImage("TroopBullet"));
                }
                if (timer % 30 == 0)
                {
                    generateCanonBullet(9, 32);
                }
            }

            //Wave 2

            if (Game.Wave1 == 2)
            {
                if (timer % 30 == 0)
                {
                    //Generate Canon 1 Bullet
                    GenerateBullets(9, 32, PacMan.GameGL.Game.getGameObjectImage("CanonBall"));
                }
                if (timer % 35 == 0)
                {
                    //Generating canon Bullet
                    GenerateBullets(4, 31, PacMan.GameGL.Game.getGameObjectImage("CanonBall"));
                }
                if (timer % 20 == 0)
                {
                    //Movement of B51 Plane
                    B51Plane.Move(ref HorizontalGhostDir);
                }
                if (timer % 18 == 0)
                {
                    //Movement of Rafale
                    RafalePlane.Move(ref HorizontalGhostDir);
                }

                if (timer % 10 == 0)
                {
                    //For Corps
                    if (!(collider.IsEnemeyCollidedwithPlayer(Corp1)))
                    {
                        Corp1.Move(ref HorizontalGhostDir);
                    }
                    if (!(collider.IsEnemeyCollidedwithPlayer(Corp2)))
                    {
                        Corp2.Move(ref HorizontalGhostDir);
                    }

                }
                if (SearchPlayer(Corp1))
                {
                    //For Corps bullet
                    GenerateBullets(13, Corp1.CurrentCell.nextCell(GameDirection.Left).Y, PacMan.GameGL.Game.getGameObjectImage("CorpBullet"));
                }
                if (SearchPlayer(Corp2))
                {
                    //For Corp2 Bullet
                    GenerateBullets(13, Corp2.CurrentCell.nextCell(GameDirection.Left).Y, PacMan.GameGL.Game.getGameObjectImage("CorpBullet"));
                }
                if (timer % 20 == 0)
                {
                    //For B51 Plane
                    GenerateBullets(5, B51Plane.CurrentCell.nextCell(GameDirection.Left).Y, PacMan.GameGL.Game.getGameObjectImage("Laser"));
                }
                if (timer % 18 == 0)
                {
                    //For Aircrafts
                    GenerateBullets(16, RafalePlane.CurrentCell.nextCell(GameDirection.Left).Y, PacMan.GameGL.Game.getGameObjectImage("Laser"));
                }
            }
            if (Game.Wave1 == 3)
            {
                if(timer%15==0)
                {
                    BossTruck.Move(ref HorizontalGhostDir);

                }
                if(timer%25==0)
                {
                    BossUFirer.Move(ref HorizontalGhostDir);
                }
                if(timer%17==0)
                {
                    BossUTank.Move(ref HorizontalGhostDir);
                }
                if(timer%10==0)
                {
                    BossUACar.Move(ref HorizontalGhostDir);
                }
                if(timer%9==0)
                {
                    BossACar.Move(ref HorizontalGhostDir);
                    BossACar2.Move(ref HorizontalGhostDir);
                }
                if(SearchPlayer(BossUFirer))
                {
                    GenerateBullets(10,BossUFirer.CurrentCell.nextCell(GameDirection.Left).Y, PacMan.GameGL.Game.getGameObjectImage("Laser"));
                }
                if(SearchPlayer(BossUTank))
                {
                    GenerateBullets(14, BossUTank.CurrentCell.nextCell(GameDirection.Left).Y, PacMan.GameGL.Game.getGameObjectImage("CanonBall"));
                }
                if(timer%19==0)
                {
                    GenerateBullets(12,BossUACar.CurrentCell.nextCell(GameDirection.Left).Y, PacMan.GameGL.Game.getGameObjectImage("TroopBullet"));
                }
            }
            //Super TankFight
            if(Game.Wave1==4)
            {
                if(timer%45==0)
                {
                GenerateBullets(7, Tank3.CurrentCell.nextCell(GameDirection.Left).Y, PacMan.GameGL.Game.getGameObjectImage("CorpBullet"));

                }
                if(timer%40==0)
                {

                    GenerateBullets(14, Tank6.CurrentCell.nextCell(GameDirection.Left).Y, PacMan.GameGL.Game.getGameObjectImage("CorpBullet"));
                }
                if (timer%28==0)
                {
                    Tank1.Move(ref HorizontalGhostDir);
                    GenerateBullets(12, Tank5.CurrentCell.nextCell(GameDirection.Left).Y, PacMan.GameGL.Game.getGameObjectImage("CorpBullet"));
                }
                if (timer % 24 == 0)
                {
                    Tank2.Move(ref HorizontalGhostDir);
                    GenerateBullets(18, Tank7.CurrentCell.nextCell(GameDirection.Left).Y, PacMan.GameGL.Game.getGameObjectImage("CorpBullet"));


                }
                if (timer % 28 == 0)
                {
                    Tank3.Move(ref HorizontalGhostDir);

                }
                if (timer % 17 == 0)
                {
                    Tank4.Move(ref HorizontalGhostDir);

                }
                if (timer % 26 == 0)
                {
                    Tank5.Move(ref HorizontalGhostDir);
                    GenerateBullets(4, Tank1.CurrentCell.nextCell(GameDirection.Left).Y, PacMan.GameGL.Game.getGameObjectImage("CorpBullet"));

                }
                if (timer % 31 == 0)
                {
                    GenerateBullets(6, Tank2.CurrentCell.nextCell(GameDirection.Left).Y, PacMan.GameGL.Game.getGameObjectImage("CorpBullet"));
                    Tank6.Move(ref HorizontalGhostDir);

                }
                if(timer%33==0)
                {
                    GenerateBullets(9, Tank4.CurrentCell.nextCell(GameDirection.Left).Y, PacMan.GameGL.Game.getGameObjectImage("CorpBullet"));
                    Tank7.Move(ref HorizontalGhostDir);
                }
            }


            moveEBullet();
            movePBullets();
        }
        bool SearchPlayer(HGhost Solider)
        {
            GameCell cell1 = Solider.CurrentCell.nextCell(GameDirection.Left);
            GameCell cell2 = cell1.nextCell(GameDirection.Left);
            GameCell cell3 = cell2.nextCell(GameDirection.Left);
            GameCell cell4 = cell3.nextCell(GameDirection.Left);
            GameCell cell5 = cell4.nextCell(GameDirection.Left);
            GameCell cell6 = cell5.nextCell(GameDirection.Left);
            GameCell cell7 = cell6.nextCell(GameDirection.Left);
            GameCell cell8 = cell7.nextCell(GameDirection.Left);

            if (PTank.CurrentCell==cell1|| PTank.CurrentCell == cell2 || PTank.CurrentCell == cell3|| PTank.CurrentCell == cell4 || PTank.CurrentCell == cell5|| PTank.CurrentCell == cell6|| PTank.CurrentCell == cell7 || PTank.CurrentCell == cell8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void moveEBullet()
        {
            foreach(HBullet b in Game.Bullets)
            {
                if(!(collider.isBulletCollidedwithPlayer(b)))
                {
                    b.move();               
                }
                if(collider.isBulletCollidedwithPlayer(b))
                {
                    b.Image = null;
                    b.IsActive = false;
                    Game.Pbullets1.Remove(b);
                }
            }
        }
        public void generateCanonBullet(int x,int y)
        {
            HBullet CanonBullet;          
            Image bullet2 = PacMan.GameGL.Game.getGameObjectImage("CanonBall");
            GameCell StartCanonShootCell = grid.getCell(x,y);
            CanonBullet = new HBullet(GameDirection.Left, bullet2, StartCanonShootCell);
            Game.Bullets.Add(CanonBullet);
        }
        void GeneratePlayerBullet()
        {
            PBullet b = new PBullet(GameDirection.Right, PacMan.GameGL.Game.getGameObjectImage("F"), PTank.CurrentCell.nextCell(GameDirection.Right));  
            Game.Pbullets1.Add(b);
        }
        void movePBullets()
        {

            foreach(PBullet b in Game.Pbullets1)
            {
                if(Game.Pbullets1.Count>0)
                {
                    if(b.IsActive)
                    {

                        if (!(collider.isBulletCollideWithEnemy(b)))
                        {
                               b.move();
                        }
                        if ((collider.isBulletCollideWithEnemy(b)))
                        {
                                b.IsActive = false;
                                b.Image = null;
                                EnemyRedBar.Width -= 25;
                        }
 
                    }
                }
            }
        }
        void GenerateBullets(int x,int y,Image img)
        {
            GameCell startCell = grid.getCell(x,y);
            HBullet BossBullet = new HBullet(GameDirection.Left,img,startCell);
            Game.Bullets.Add(BossBullet);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

               
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            MainMenuForm mf = new MainMenuForm();
            GamePlayMenu.WriteWaveToFile();
            this.Hide();
            mf.Show();
        }
    }
}
