namespace CrazyFarmer
{
    partial class MainPage
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
            this.Score = new System.Windows.Forms.Label();
            this.ScoreView = new System.Windows.Forms.Label();
            this.ScoreINT = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Location = new System.Drawing.Point(12, 9);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(38, 13);
            this.Score.TabIndex = 0;
            this.Score.Text = "Score:";
            // 
            // ScoreView
            // 
            this.ScoreView.AutoSize = true;
            this.ScoreView.Location = new System.Drawing.Point(56, 9);
            this.ScoreView.Name = "ScoreView";
            this.ScoreView.Size = new System.Drawing.Size(0, 13);
            this.ScoreView.TabIndex = 1;
            // 
            // ScoreINT
            // 
            this.ScoreINT.AutoSize = true;
            this.ScoreINT.Location = new System.Drawing.Point(56, 9);
            this.ScoreINT.Name = "ScoreINT";
            this.ScoreINT.Size = new System.Drawing.Size(63, 13);
            this.ScoreINT.TabIndex = 2;
            this.ScoreINT.Text = "TheSCORE";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.ScoreINT);
            this.Controls.Add(this.ScoreView);
            this.Controls.Add(this.Score);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrazyFarmer";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormMainPage_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMainPage_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label ScoreView;
        private System.Windows.Forms.Label ScoreINT;
        private System.Windows.Forms.Timer GameTimer;
    }
}

