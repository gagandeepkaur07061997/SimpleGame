namespace SimpleGame
{
    partial class Simple_Game
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
            this.pic_box = new System.Windows.Forms.PictureBox();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_Play = new System.Windows.Forms.Button();
            this.btn_Spin = new System.Windows.Forms.Button();
            this.btn_Shoot = new System.Windows.Forms.Button();
            this.btn_Shoot_away = new System.Windows.Forms.Button();
            this.btn_Exit_Game = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_box
            // 
            this.pic_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pic_box.BackgroundImage = global::SimpleGame.Properties.Resources.images;
            this.pic_box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_box.Location = new System.Drawing.Point(89, 36);
            this.pic_box.Name = "pic_box";
            this.pic_box.Size = new System.Drawing.Size(397, 210);
            this.pic_box.TabIndex = 0;
            this.pic_box.TabStop = false;
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.Yellow;
            this.btn_load.Location = new System.Drawing.Point(47, 264);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(95, 35);
            this.btn_load.TabIndex = 1;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_Play
            // 
            this.btn_Play.BackColor = System.Drawing.Color.Yellow;
            this.btn_Play.Location = new System.Drawing.Point(451, 264);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(95, 35);
            this.btn_Play.TabIndex = 2;
            this.btn_Play.Text = "Play";
            this.btn_Play.UseVisualStyleBackColor = false;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // btn_Spin
            // 
            this.btn_Spin.BackColor = System.Drawing.Color.Yellow;
            this.btn_Spin.Location = new System.Drawing.Point(148, 264);
            this.btn_Spin.Name = "btn_Spin";
            this.btn_Spin.Size = new System.Drawing.Size(95, 35);
            this.btn_Spin.TabIndex = 3;
            this.btn_Spin.Text = "Spin";
            this.btn_Spin.UseVisualStyleBackColor = false;
            this.btn_Spin.Click += new System.EventHandler(this.Btn_Spin_Click);
            // 
            // btn_Shoot
            // 
            this.btn_Shoot.BackColor = System.Drawing.Color.Yellow;
            this.btn_Shoot.Location = new System.Drawing.Point(249, 264);
            this.btn_Shoot.Name = "btn_Shoot";
            this.btn_Shoot.Size = new System.Drawing.Size(95, 35);
            this.btn_Shoot.TabIndex = 4;
            this.btn_Shoot.Text = "Shoot";
            this.btn_Shoot.UseVisualStyleBackColor = false;
            this.btn_Shoot.Click += new System.EventHandler(this.Btn_Shoot_Click);
            // 
            // btn_Shoot_away
            // 
            this.btn_Shoot_away.BackColor = System.Drawing.Color.Yellow;
            this.btn_Shoot_away.Location = new System.Drawing.Point(350, 264);
            this.btn_Shoot_away.Name = "btn_Shoot_away";
            this.btn_Shoot_away.Size = new System.Drawing.Size(95, 35);
            this.btn_Shoot_away.TabIndex = 5;
            this.btn_Shoot_away.Text = "Shoot away";
            this.btn_Shoot_away.UseVisualStyleBackColor = false;
            this.btn_Shoot_away.Click += new System.EventHandler(this.btn_Shoot_away_Click);
            // 
            // btn_Exit_Game
            // 
            this.btn_Exit_Game.BackColor = System.Drawing.Color.Yellow;
            this.btn_Exit_Game.Location = new System.Drawing.Point(591, 12);
            this.btn_Exit_Game.Name = "btn_Exit_Game";
            this.btn_Exit_Game.Size = new System.Drawing.Size(95, 35);
            this.btn_Exit_Game.TabIndex = 6;
            this.btn_Exit_Game.Text = "Exit Game";
            this.btn_Exit_Game.UseVisualStyleBackColor = false;
            this.btn_Exit_Game.Click += new System.EventHandler(this.btn_Exit_Game_Click);
            // 
            // Simple_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SimpleGame.Properties.Resources.picbox;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Exit_Game);
            this.Controls.Add(this.btn_Shoot_away);
            this.Controls.Add(this.btn_Shoot);
            this.Controls.Add(this.btn_Spin);
            this.Controls.Add(this.btn_Play);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.pic_box);
            this.Name = "Simple_Game";
            this.Text = "SimpleGame";
            ((System.ComponentModel.ISupportInitialize)(this.pic_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_box;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Button btn_Spin;
        private System.Windows.Forms.Button btn_Shoot;
        private System.Windows.Forms.Button btn_Shoot_away;
        private System.Windows.Forms.Button btn_Exit_Game;
    }
}

