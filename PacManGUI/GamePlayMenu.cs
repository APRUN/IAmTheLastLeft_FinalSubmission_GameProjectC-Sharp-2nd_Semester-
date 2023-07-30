using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PacMan.GameGL;

namespace PacManGUI
{
    public partial class GamePlayMenu : UserControl
    {
        public GamePlayMenu()
        {
            InitializeComponent();
        }
        public static void WriteWaveToFile()
        {
            string path = "Data.txt";
            StreamWriter file = new StreamWriter(path);
            file.WriteLine(Game.Wave1);
            file.Flush();
            file.Close();
        }
        public static void loadWaveFromFile()
        {
            string path = "Data.txt";
            StreamReader file = new StreamReader(path);
            string line;
            while (!(file.EndOfStream))
            {
                line = file.ReadLine();
                int wave;
                int.TryParse(line,out wave);
                Game.Wave1 = wave;
            }
            file.Close();
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            WriteWaveToFile();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Game.Wave1 = 1;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
