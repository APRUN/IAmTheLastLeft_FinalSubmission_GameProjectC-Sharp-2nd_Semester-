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

namespace PacManGUI
{
    public partial class GameModeForm : Form
    {
        public GameModeForm()
        {
            InitializeComponent();
        }

        private void GameModeForm_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            MainMenuForm mc = new MainMenuForm();
            this.Hide();
            mc.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            Game.Wave1 = 4;
            f1.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //Form1 f1 = new Form1();
            //this.Hide();
            //Game.Wave1 = 5;
            //f1.Show();
        }
    }
}
