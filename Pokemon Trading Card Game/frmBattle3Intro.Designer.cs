namespace Pokemon_Trading_Card_Game
{
    partial class frmBattle3Intro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBattle3Intro));
            this.lblBattle3PlayerPrompt = new System.Windows.Forms.Label();
            this.lblBattle3VS = new System.Windows.Forms.Label();
            this.lblBattle3Prompt = new System.Windows.Forms.Label();
            this.lblLTSurge = new System.Windows.Forms.Label();
            this.btnBeginBattle3 = new System.Windows.Forms.Button();
            this.pbxBattle3Player = new System.Windows.Forms.PictureBox();
            this.pbxLTSurge = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBattle3Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLTSurge)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBattle3PlayerPrompt
            // 
            this.lblBattle3PlayerPrompt.AutoSize = true;
            this.lblBattle3PlayerPrompt.BackColor = System.Drawing.Color.Transparent;
            this.lblBattle3PlayerPrompt.Location = new System.Drawing.Point(146, 447);
            this.lblBattle3PlayerPrompt.Name = "lblBattle3PlayerPrompt";
            this.lblBattle3PlayerPrompt.Size = new System.Drawing.Size(81, 29);
            this.lblBattle3PlayerPrompt.TabIndex = 2;
            this.lblBattle3PlayerPrompt.Text = "Player";
            // 
            // lblBattle3VS
            // 
            this.lblBattle3VS.AutoSize = true;
            this.lblBattle3VS.BackColor = System.Drawing.Color.Transparent;
            this.lblBattle3VS.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBattle3VS.Location = new System.Drawing.Point(673, 381);
            this.lblBattle3VS.Name = "lblBattle3VS";
            this.lblBattle3VS.Size = new System.Drawing.Size(86, 60);
            this.lblBattle3VS.TabIndex = 3;
            this.lblBattle3VS.Text = "VS.";
            // 
            // lblBattle3Prompt
            // 
            this.lblBattle3Prompt.AutoSize = true;
            this.lblBattle3Prompt.BackColor = System.Drawing.Color.Transparent;
            this.lblBattle3Prompt.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBattle3Prompt.ForeColor = System.Drawing.Color.Gold;
            this.lblBattle3Prompt.Location = new System.Drawing.Point(621, 185);
            this.lblBattle3Prompt.Name = "lblBattle3Prompt";
            this.lblBattle3Prompt.Size = new System.Drawing.Size(185, 60);
            this.lblBattle3Prompt.TabIndex = 4;
            this.lblBattle3Prompt.Text = "Battle 3";
            // 
            // lblLTSurge
            // 
            this.lblLTSurge.AutoSize = true;
            this.lblLTSurge.BackColor = System.Drawing.Color.Transparent;
            this.lblLTSurge.Location = new System.Drawing.Point(1161, 9);
            this.lblLTSurge.Name = "lblLTSurge";
            this.lblLTSurge.Size = new System.Drawing.Size(104, 29);
            this.lblLTSurge.TabIndex = 5;
            this.lblLTSurge.Text = "Lt. Surge";
            // 
            // btnBeginBattle3
            // 
            this.btnBeginBattle3.BackColor = System.Drawing.Color.Firebrick;
            this.btnBeginBattle3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBeginBattle3.ForeColor = System.Drawing.Color.White;
            this.btnBeginBattle3.Location = new System.Drawing.Point(631, 648);
            this.btnBeginBattle3.Name = "btnBeginBattle3";
            this.btnBeginBattle3.Size = new System.Drawing.Size(171, 101);
            this.btnBeginBattle3.TabIndex = 6;
            this.btnBeginBattle3.Text = "Begin Battle";
            this.btnBeginBattle3.UseVisualStyleBackColor = false;
            this.btnBeginBattle3.Click += new System.EventHandler(this.btnBeginBattle3_Click);
            // 
            // pbxBattle3Player
            // 
            this.pbxBattle3Player.BackColor = System.Drawing.Color.White;
            this.pbxBattle3Player.Image = global::Pokemon_Trading_Card_Game.Properties.Resources.Trainer_Profile;
            this.pbxBattle3Player.Location = new System.Drawing.Point(26, 483);
            this.pbxBattle3Player.Margin = new System.Windows.Forms.Padding(7);
            this.pbxBattle3Player.Name = "pbxBattle3Player";
            this.pbxBattle3Player.Size = new System.Drawing.Size(339, 340);
            this.pbxBattle3Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxBattle3Player.TabIndex = 1;
            this.pbxBattle3Player.TabStop = false;
            // 
            // pbxLTSurge
            // 
            this.pbxLTSurge.Image = global::Pokemon_Trading_Card_Game.Properties.Resources.Lt_SurgeProfile;
            this.pbxLTSurge.Location = new System.Drawing.Point(1054, 45);
            this.pbxLTSurge.Margin = new System.Windows.Forms.Padding(7);
            this.pbxLTSurge.Name = "pbxLTSurge";
            this.pbxLTSurge.Size = new System.Drawing.Size(339, 340);
            this.pbxLTSurge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLTSurge.TabIndex = 0;
            this.pbxLTSurge.TabStop = false;
            // 
            // frmBattle3Intro
            // 
            this.AcceptButton = this.btnBeginBattle3;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pokemon_Trading_Card_Game.Properties.Resources.UltraBallStadiumBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1424, 822);
            this.Controls.Add(this.btnBeginBattle3);
            this.Controls.Add(this.lblLTSurge);
            this.Controls.Add(this.lblBattle3Prompt);
            this.Controls.Add(this.lblBattle3VS);
            this.Controls.Add(this.lblBattle3PlayerPrompt);
            this.Controls.Add(this.pbxBattle3Player);
            this.Controls.Add(this.pbxLTSurge);
            this.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frmBattle3Intro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            ((System.ComponentModel.ISupportInitialize)(this.pbxBattle3Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLTSurge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxLTSurge;
        private System.Windows.Forms.PictureBox pbxBattle3Player;
        private System.Windows.Forms.Label lblBattle3PlayerPrompt;
        private System.Windows.Forms.Label lblBattle3VS;
        private System.Windows.Forms.Label lblBattle3Prompt;
        private System.Windows.Forms.Label lblLTSurge;
        private System.Windows.Forms.Button btnBeginBattle3;
    }
}