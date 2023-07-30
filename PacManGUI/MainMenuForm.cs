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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            LevelSelectionForm lv = new LevelSelectionForm();
            this.Hide();
            lv.StartPosition =FormStartPosition.CenterScreen;
            lv.Show();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            GamePlayMenu.loadWaveFromFile();
            Form1 f = new Form1();
            this.Hide();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            GameModeForm lf = new GameModeForm();
            this.Hide();
            lf.Show();
        }
    }
}
