namespace cemal
{
    partial class MainPencere
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPencere));
            this.oyunBasla = new System.Windows.Forms.Panel();
            this.startGame = new System.Windows.Forms.Label();
            this.oyunAdi = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.scoreSayac = new System.Windows.Forms.Label();
            this.gameOver = new System.Windows.Forms.Label();
            this.oyunBasla.SuspendLayout();
            this.SuspendLayout();
            // 
            // oyunBasla
            // 
            this.oyunBasla.BackColor = System.Drawing.Color.Transparent;
            this.oyunBasla.Controls.Add(this.startGame);
            this.oyunBasla.Controls.Add(this.oyunAdi);
            this.oyunBasla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oyunBasla.Font = new System.Drawing.Font("Old English Text MT", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oyunBasla.ForeColor = System.Drawing.Color.Snow;
            this.oyunBasla.Location = new System.Drawing.Point(0, 0);
            this.oyunBasla.Name = "oyunBasla";
            this.oyunBasla.Size = new System.Drawing.Size(605, 340);
            this.oyunBasla.TabIndex = 0;
            // 
            // startGame
            // 
            this.startGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.startGame.AutoSize = true;
            this.startGame.Font = new System.Drawing.Font("Trajan Pro", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.startGame.Location = new System.Drawing.Point(145, 249);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(334, 34);
            this.startGame.TabIndex = 1;
            this.startGame.Text = "Press ENTER to Start";
            // 
            // oyunAdi
            // 
            this.oyunAdi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.oyunAdi.AutoSize = true;
            this.oyunAdi.Font = new System.Drawing.Font("Trajan Pro", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oyunAdi.Location = new System.Drawing.Point(139, 181);
            this.oyunAdi.Name = "oyunAdi";
            this.oyunAdi.Size = new System.Drawing.Size(340, 54);
            this.oyunAdi.TabIndex = 0;
            this.oyunAdi.Text = "THE IMPERIO";
            // 
            // score
            // 
            this.score.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.Transparent;
            this.score.Font = new System.Drawing.Font("Trajan Pro", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.score.ForeColor = System.Drawing.Color.Coral;
            this.score.Location = new System.Drawing.Point(448, 9);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(105, 28);
            this.score.TabIndex = 1;
            this.score.Text = "SCORE :";
            // 
            // scoreSayac
            // 
            this.scoreSayac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scoreSayac.BackColor = System.Drawing.Color.Transparent;
            this.scoreSayac.Font = new System.Drawing.Font("Trajan Pro", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scoreSayac.ForeColor = System.Drawing.Color.Coral;
            this.scoreSayac.Location = new System.Drawing.Point(557, 9);
            this.scoreSayac.Name = "scoreSayac";
            this.scoreSayac.Size = new System.Drawing.Size(36, 23);
            this.scoreSayac.TabIndex = 2;
            // 
            // gameOver
            // 
            this.gameOver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gameOver.AutoSize = true;
            this.gameOver.BackColor = System.Drawing.Color.Transparent;
            this.gameOver.Font = new System.Drawing.Font("Trajan Pro", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gameOver.ForeColor = System.Drawing.Color.Maroon;
            this.gameOver.Location = new System.Drawing.Point(1, 139);
            this.gameOver.Name = "gameOver";
            this.gameOver.Size = new System.Drawing.Size(610, 108);
            this.gameOver.TabIndex = 2;
            this.gameOver.Text = "GAME OVER";
            this.gameOver.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.gameOver.Visible = false;
            // 
            // MainPencere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 340);
            this.Controls.Add(this.gameOver);
            this.Controls.Add(this.scoreSayac);
            this.Controls.Add(this.score);
            this.Controls.Add(this.oyunBasla);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPencere";
            this.Text = "Imperio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.oyunBasla.ResumeLayout(false);
            this.oyunBasla.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel oyunBasla;
        private System.Windows.Forms.Label startGame;
        private System.Windows.Forms.Label oyunAdi;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label scoreSayac;
        private System.Windows.Forms.Label gameOver;
    }
}

