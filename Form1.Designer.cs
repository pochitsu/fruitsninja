namespace GameIn3Hours
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MoveBGTimer = new System.Windows.Forms.Timer(this.components);
            this.Ninja = new System.Windows.Forms.PictureBox();
            this.UpTimer = new System.Windows.Forms.Timer(this.components);
            this.DownTimer = new System.Windows.Forms.Timer(this.components);
            this.LeftTimer = new System.Windows.Forms.Timer(this.components);
            this.RightTimer = new System.Windows.Forms.Timer(this.components);
            this.WepaonsMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.FruitsTimer = new System.Windows.Forms.Timer(this.components);
            this.FruitsShootTimer = new System.Windows.Forms.Timer(this.components);
            this.Exit = new System.Windows.Forms.Button();
            this.Replay = new System.Windows.Forms.Button();
            this.GameOverLabel = new System.Windows.Forms.Label();
            this.ShowLevel = new System.Windows.Forms.Label();
            this.ShowScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Ninja)).BeginInit();
            this.SuspendLayout();
            // 
            // MoveBGTimer
            // 
            this.MoveBGTimer.Enabled = true;
            this.MoveBGTimer.Interval = 10;
            this.MoveBGTimer.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Ninja
            // 
            this.Ninja.BackColor = System.Drawing.Color.Transparent;
            this.Ninja.Image = ((System.Drawing.Image)(resources.GetObject("Ninja.Image")));
            this.Ninja.Location = new System.Drawing.Point(261, 400);
            this.Ninja.Name = "Ninja";
            this.Ninja.Size = new System.Drawing.Size(61, 54);
            this.Ninja.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ninja.TabIndex = 1;
            this.Ninja.TabStop = false;
            // 
            // UpTimer
            // 
            this.UpTimer.Interval = 5;
            this.UpTimer.Tick += new System.EventHandler(this.Uptimer_Tick);
            // 
            // DownTimer
            // 
            this.DownTimer.Interval = 5;
            this.DownTimer.Tick += new System.EventHandler(this.DownTimer_Tick);
            // 
            // LeftTimer
            // 
            this.LeftTimer.Interval = 5;
            this.LeftTimer.Tick += new System.EventHandler(this.LeftTimer_Tick);
            // 
            // RightTimer
            // 
            this.RightTimer.Interval = 5;
            this.RightTimer.Tick += new System.EventHandler(this.RightTimer_Tick);
            // 
            // WepaonsMoveTimer
            // 
            this.WepaonsMoveTimer.Enabled = true;
            this.WepaonsMoveTimer.Interval = 20;
            this.WepaonsMoveTimer.Tick += new System.EventHandler(this.WepaonsMoveTimer_Tick);
            // 
            // FruitsTimer
            // 
            this.FruitsTimer.Enabled = true;
            this.FruitsTimer.Tick += new System.EventHandler(this.FruitsTimer_Tick);
            // 
            // FruitsShootTimer
            // 
            this.FruitsShootTimer.Enabled = true;
            this.FruitsShootTimer.Interval = 20;
            this.FruitsShootTimer.Tick += new System.EventHandler(this.FruitsShootTimer_Tick);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Exit.Font = new System.Drawing.Font("Goudy Stout", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(212, 313);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(159, 59);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit?";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Visible = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Replay
            // 
            this.Replay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Replay.Font = new System.Drawing.Font("Goudy Stout", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Replay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Replay.Location = new System.Drawing.Point(175, 219);
            this.Replay.Name = "Replay";
            this.Replay.Size = new System.Drawing.Size(227, 70);
            this.Replay.TabIndex = 5;
            this.Replay.Text = "Replay?";
            this.Replay.UseVisualStyleBackColor = false;
            this.Replay.Visible = false;
            this.Replay.Click += new System.EventHandler(this.Replay_Click);
            // 
            // GameOverLabel
            // 
            this.GameOverLabel.BackColor = System.Drawing.Color.Transparent;
            this.GameOverLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GameOverLabel.Enabled = false;
            this.GameOverLabel.Font = new System.Drawing.Font("Goudy Stout", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameOverLabel.ForeColor = System.Drawing.Color.Red;
            this.GameOverLabel.Location = new System.Drawing.Point(92, 96);
            this.GameOverLabel.Name = "GameOverLabel";
            this.GameOverLabel.Size = new System.Drawing.Size(401, 80);
            this.GameOverLabel.TabIndex = 6;
            this.GameOverLabel.Text = "Game Over";
            this.GameOverLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GameOverLabel.Visible = false;
            // 
            // ShowLevel
            // 
            this.ShowLevel.AutoSize = true;
            this.ShowLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ShowLevel.Font = new System.Drawing.Font("Goudy Stout", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowLevel.Location = new System.Drawing.Point(464, 9);
            this.ShowLevel.Name = "ShowLevel";
            this.ShowLevel.Size = new System.Drawing.Size(112, 27);
            this.ShowLevel.TabIndex = 7;
            this.ShowLevel.Text = "Level ";
            this.ShowLevel.UseCompatibleTextRendering = true;
            // 
            // ShowScore
            // 
            this.ShowScore.AutoSize = true;
            this.ShowScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ShowScore.Font = new System.Drawing.Font("Goudy Stout", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowScore.Location = new System.Drawing.Point(12, 9);
            this.ShowScore.Name = "ShowScore";
            this.ShowScore.Size = new System.Drawing.Size(102, 22);
            this.ShowScore.TabIndex = 8;
            this.ShowScore.Text = "Score";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(588, 454);
            this.Controls.Add(this.ShowScore);
            this.Controls.Add(this.ShowLevel);
            this.Controls.Add(this.GameOverLabel);
            this.Controls.Add(this.Replay);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Ninja);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(610, 510);
            this.MinimumSize = new System.Drawing.Size(610, 510);
            this.Name = "Form1";
            this.Text = "FruitsNinja";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Ninja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            

        }

        #endregion

        private System.Windows.Forms.Timer MoveBGTimer;
        private System.Windows.Forms.PictureBox Ninja;
        private System.Windows.Forms.Timer UpTimer;
        private System.Windows.Forms.Timer DownTimer;
        private System.Windows.Forms.Timer LeftTimer;
        private System.Windows.Forms.Timer RightTimer;
        private System.Windows.Forms.Timer WepaonsMoveTimer;
        private System.Windows.Forms.Timer FruitsTimer;
        private System.Windows.Forms.Timer FruitsShootTimer;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Replay;
        private System.Windows.Forms.Label GameOverLabel;
        private System.Windows.Forms.Label ShowLevel;
        private System.Windows.Forms.Label ShowScore;
    }
}

