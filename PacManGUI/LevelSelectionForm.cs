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
    public partial class LevelSelectionForm : Form
    {
        public LevelSelectionForm()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Game.Wave1 = 1;
            Form1 f = new Form1();
            this.Hide();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Game.Wave1 = 2;
            Form1 f = new Form1();
            this.Hide();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Game.Wave1 = 3;
            Form1 f = new Form1();
            this.Hide();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }
    }
}
