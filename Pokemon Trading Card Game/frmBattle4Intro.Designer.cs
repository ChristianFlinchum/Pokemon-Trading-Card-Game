namespace Pokemon_Trading_Card_Game
{
    partial class frmBattle4Intro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBattle4Intro));
            this.lblBattle4Prompt = new System.Windows.Forms.Label();
            this.lblBattle4VS = new System.Windows.Forms.Label();
            this.lblRivalGary = new System.Windows.Forms.Label();
            this.lblBattle4PlayerPrompt = new System.Windows.Forms.Label();
            this.btnBeginBattle4 = new System.Windows.Forms.Button();
            this.pbxRivalGary = new System.Windows.Forms.PictureBox();
            this.pbxBattle4Player = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRivalGary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBattle4Player)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBattle4Prompt
            // 
            this.lblBattle4Prompt.AutoSize = true;
            this.lblBattle4Prompt.BackColor = System.Drawing.Color.Transparent;
            this.lblBattle4Prompt.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBattle4Prompt.Location = new System.Drawing.Point(550, 105);
            this.lblBattle4Prompt.Name = "lblBattle4Prompt";
            this.lblBattle4Prompt.Size = new System.Drawing.Size(350, 80);
            this.lblBattle4Prompt.TabIndex = 0;
            this.lblBattle4Prompt.Text = "Final Battle ";
            // 
            // lblBattle4VS
            // 
            this.lblBattle4VS.AutoSize = true;
            this.lblBattle4VS.BackColor = System.Drawing.Color.Transparent;
            this.lblBattle4VS.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBattle4VS.Location = new System.Drawing.Point(673, 380);
            this.lblBattle4VS.Name = "lblBattle4VS";
            this.lblBattle4VS.Size = new System.Drawing.Size(86, 60);
            this.lblBattle4VS.TabIndex = 1;
            this.lblBattle4VS.Text = "VS.";
            // 
            // lblRivalGary
            // 
            this.lblRivalGary.AutoSize = true;
            this.lblRivalGary.BackColor = System.Drawing.Color.Transparent;
            this.lblRivalGary.Location = new System.Drawing.Point(1179, 9);
            this.lblRivalGary.Name = "lblRivalGary";
            this.lblRivalGary.Size = new System.Drawing.Size(120, 29);
            this.lblRivalGary.TabIndex = 2;
            this.lblRivalGary.Text = "Rival Gary";
            // 
            // lblBattle4PlayerPrompt
            // 
            this.lblBattle4PlayerPrompt.AutoSize = true;
            this.lblBattle4PlayerPrompt.BackColor = System.Drawing.Color.Transparent;
            this.lblBattle4PlayerPrompt.Location = new System.Drawing.Point(150, 450);
            this.lblBattle4PlayerPrompt.Name = "lblBattle4PlayerPrompt";
            this.lblBattle4PlayerPrompt.Size = new System.Drawing.Size(81, 29);
            this.lblBattle4PlayerPrompt.TabIndex = 3;
            this.lblBattle4PlayerPrompt.Text = "Player";
            // 
            // btnBeginBattle4
            // 
            this.btnBeginBattle4.BackColor = System.Drawing.Color.Firebrick;
            this.btnBeginBattle4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBeginBattle4.ForeColor = System.Drawing.Color.White;
            this.btnBeginBattle4.Location = new System.Drawing.Point(627, 610);
            this.btnBeginBattle4.Name = "btnBeginBattle4";
            this.btnBeginBattle4.Size = new System.Drawing.Size(171, 101);
            this.btnBeginBattle4.TabIndex = 6;
            this.btnBeginBattle4.Text = "Begin Battle";
            this.btnBeginBattle4.UseVisualStyleBackColor = false;
            // 
            // pbxRivalGary
            // 
            this.pbxRivalGary.BackColor = System.Drawing.Color.White;
            this.pbxRivalGary.Image = global::Pokemon_Trading_Card_Game.Properties.Resources.Rival_Profile;
            this.pbxRivalGary.Location = new System.Drawing.Point(1062, 41);
            this.pbxRivalGary.Name = "pbxRivalGary";
            this.pbxRivalGary.Size = new System.Drawing.Size(339, 340);
            this.pbxRivalGary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxRivalGary.TabIndex = 5;
            this.pbxRivalGary.TabStop = false;
            // 
            // pbxBattle4Player
            // 
            this.pbxBattle4Player.BackColor = System.Drawing.Color.White;
            this.pbxBattle4Player.Image = global::Pokemon_Trading_Card_Game.Properties.Resources.Trainer_Profile;
            this.pbxBattle4Player.Location = new System.Drawing.Point(26, 482);
            this.pbxBattle4Player.Name = "pbxBattle4Player";
            this.pbxBattle4Player.Size = new System.Drawing.Size(339, 340);
            this.pbxBattle4Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxBattle4Player.TabIndex = 4;
            this.pbxBattle4Player.TabStop = false;
            // 
            // frmBattle4Intro
            // 
            this.AcceptButton = this.btnBeginBattle4;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pokemon_Trading_Card_Game.Properties.Resources.MasterBallStadiumBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1424, 822);
            this.Controls.Add(this.btnBeginBattle4);
            this.Controls.Add(this.pbxRivalGary);
            this.Controls.Add(this.pbxBattle4Player);
            this.Controls.Add(this.lblBattle4PlayerPrompt);
            this.Controls.Add(this.lblRivalGary);
            this.Controls.Add(this.lblBattle4VS);
            this.Controls.Add(this.lblBattle4Prompt);
            this.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frmBattle4Intro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            ((System.ComponentModel.ISupportInitialize)(this.pbxRivalGary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBattle4Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBattle4Prompt;
        private System.Windows.Forms.Label lblBattle4VS;
        private System.Windows.Forms.Label lblRivalGary;
        private System.Windows.Forms.Label lblBattle4PlayerPrompt;
        private System.Windows.Forms.PictureBox pbxBattle4Player;
        private System.Windows.Forms.PictureBox pbxRivalGary;
        private System.Windows.Forms.Button btnBeginBattle4;
    }
}