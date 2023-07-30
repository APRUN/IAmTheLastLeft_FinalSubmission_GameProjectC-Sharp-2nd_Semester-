
namespace PacManGUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameLoop = new System.Windows.Forms.Timer(this.components);
            this.PlayerGreenBarSkeleton = new System.Windows.Forms.Panel();
            this.playerGreenBar = new System.Windows.Forms.Panel();
            this.EnemyRedBarSkeleron = new System.Windows.Forms.Panel();
            this.EnemyRedBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EnemyRedBarSkeleron.SuspendLayout();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gameLoop
            // 
            this.gameLoop.Enabled = true;
            this.gameLoop.Interval = 50;
            this.gameLoop.Tick += new System.EventHandler(this.gameLoop_Tick);
            // 
            // PlayerGreenBarSkeleton
            // 
            this.PlayerGreenBarSkeleton.BackColor = System.Drawing.Color.Transparent;
            this.PlayerGreenBarSkeleton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlayerGreenBarSkeleton.Location = new System.Drawing.Point(117, 468);
            this.PlayerGreenBarSkeleton.Name = "PlayerGreenBarSkeleton";
            this.PlayerGreenBarSkeleton.Size = new System.Drawing.Size(244, 20);
            this.PlayerGreenBarSkeleton.TabIndex = 0;
            // 
            // playerGreenBar
            // 
            this.playerGreenBar.BackColor = System.Drawing.Color.DarkGreen;
            this.playerGreenBar.Location = new System.Drawing.Point(116, 6);
            this.playerGreenBar.Name = "playerGreenBar";
            this.playerGreenBar.Size = new System.Drawing.Size(240, 20);
            this.playerGreenBar.TabIndex = 2;
            // 
            // EnemyRedBarSkeleron
            // 
            this.EnemyRedBarSkeleron.BackColor = System.Drawing.Color.Black;
            this.EnemyRedBarSkeleron.Controls.Add(this.EnemyRedBar);
            this.EnemyRedBarSkeleron.ForeColor = System.Drawing.Color.Black;
            this.EnemyRedBarSkeleron.Location = new System.Drawing.Point(622, 6);
            this.EnemyRedBarSkeleron.Name = "EnemyRedBarSkeleron";
            this.EnemyRedBarSkeleron.Size = new System.Drawing.Size(335, 20);
            this.EnemyRedBarSkeleron.TabIndex = 1;
            // 
            // EnemyRedBar
            // 
            this.EnemyRedBar.BackColor = System.Drawing.Color.DarkRed;
            this.EnemyRedBar.ForeColor = System.Drawing.Color.Black;
            this.EnemyRedBar.Location = new System.Drawing.Point(0, 0);
            this.EnemyRedBar.Name = "EnemyRedBar";
            this.EnemyRedBar.Size = new System.Drawing.Size(335, 20);
            this.EnemyRedBar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(9, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(393, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enemy Strength:";
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.Transparent;
            this.Panel.Controls.Add(this.playerGreenBar);
            this.Panel.Controls.Add(this.label1);
            this.Panel.Controls.Add(this.label2);
            this.Panel.Controls.Add(this.EnemyRedBarSkeleron);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel.Location = new System.Drawing.Point(0, 469);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(960, 31);
            this.Panel.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PacManGUI.Properties.Resources.Back_Arrow;
            this.pictureBox1.Location = new System.Drawing.Point(9, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::PacManGUI.Properties.Resources.Battle2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 500);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.PlayerGreenBarSkeleton);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.EnemyRedBarSkeleron.ResumeLayout(false);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameLoop;
        private System.Windows.Forms.Panel PlayerGreenBarSkeleton;
        private System.Windows.Forms.Panel playerGreenBar;
        private System.Windows.Forms.Panel EnemyRedBarSkeleron;
        private System.Windows.Forms.Panel EnemyRedBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

