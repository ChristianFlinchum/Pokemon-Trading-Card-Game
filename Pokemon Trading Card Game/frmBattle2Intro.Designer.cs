namespace Pokemon_Trading_Card_Game
{
    partial class frmBattle2Intro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBattle2Intro));
            this.lblBattle2Prompt = new System.Windows.Forms.Label();
            this.lblMistyPrompt = new System.Windows.Forms.Label();
            this.lblBattle2PlayerPrompt = new System.Windows.Forms.Label();
            this.lblBatlle2VS = new System.Windows.Forms.Label();
            this.btnBattle2 = new System.Windows.Forms.Button();
            this.pbxBattle2Player = new System.Windows.Forms.PictureBox();
            this.pbxMisty = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBattle2Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMisty)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBattle2Prompt
            // 
            this.lblBattle2Prompt.AutoSize = true;
            this.lblBattle2Prompt.BackColor = System.Drawing.Color.Transparent;
            this.lblBattle2Prompt.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBattle2Prompt.Location = new System.Drawing.Point(628, 137);
            this.lblBattle2Prompt.Name = "lblBattle2Prompt";
            this.lblBattle2Prompt.Size = new System.Drawing.Size(184, 60);
            this.lblBattle2Prompt.TabIndex = 0;
            this.lblBattle2Prompt.Text = "Battle 2";
            // 
            // lblMistyPrompt
            // 
            this.lblMistyPrompt.AutoSize = true;
            this.lblMistyPrompt.BackColor = System.Drawing.Color.Transparent;
            this.lblMistyPrompt.Location = new System.Drawing.Point(1191, 9);
            this.lblMistyPrompt.Name = "lblMistyPrompt";
            this.lblMistyPrompt.Size = new System.Drawing.Size(70, 29);
            this.lblMistyPrompt.TabIndex = 1;
            this.lblMistyPrompt.Text = "Misty";
            // 
            // lblBattle2PlayerPrompt
            // 
            this.lblBattle2PlayerPrompt.AutoSize = true;
            this.lblBattle2PlayerPrompt.BackColor = System.Drawing.Color.Transparent;
            this.lblBattle2PlayerPrompt.Location = new System.Drawing.Point(152, 451);
            this.lblBattle2PlayerPrompt.Name = "lblBattle2PlayerPrompt";
            this.lblBattle2PlayerPrompt.Size = new System.Drawing.Size(81, 29);
            this.lblBattle2PlayerPrompt.TabIndex = 2;
            this.lblBattle2PlayerPrompt.Text = "Player";
            // 
            // lblBatlle2VS
            // 
            this.lblBatlle2VS.AutoSize = true;
            this.lblBatlle2VS.BackColor = System.Drawing.Color.Transparent;
            this.lblBatlle2VS.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatlle2VS.Location = new System.Drawing.Point(674, 381);
            this.lblBatlle2VS.Name = "lblBatlle2VS";
            this.lblBatlle2VS.Size = new System.Drawing.Size(86, 60);
            this.lblBatlle2VS.TabIndex = 3;
            this.lblBatlle2VS.Text = "VS.";
            // 
            // btnBattle2
            // 
            this.btnBattle2.BackColor = System.Drawing.Color.Firebrick;
            this.btnBattle2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBattle2.ForeColor = System.Drawing.Color.White;
            this.btnBattle2.Location = new System.Drawing.Point(638, 615);
            this.btnBattle2.Name = "btnBattle2";
            this.btnBattle2.Size = new System.Drawing.Size(171, 101);
            this.btnBattle2.TabIndex = 4;
            this.btnBattle2.Text = "Begin Battle";
            this.btnBattle2.UseVisualStyleBackColor = false;
            this.btnBattle2.Click += new System.EventHandler(this.btnBattle2_Click);
            // 
            // pbxBattle2Player
            // 
            this.pbxBattle2Player.BackColor = System.Drawing.Color.White;
            this.pbxBattle2Player.Image = global::Pokemon_Trading_Card_Game.Properties.Resources.Trainer_Profile;
            this.pbxBattle2Player.Location = new System.Drawing.Point(31, 483);
            this.pbxBattle2Player.Name = "pbxBattle2Player";
            this.pbxBattle2Player.Size = new System.Drawing.Size(339, 340);
            this.pbxBattle2Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxBattle2Player.TabIndex = 5;
            this.pbxBattle2Player.TabStop = false;
            // 
            // pbxMisty
            // 
            this.pbxMisty.BackColor = System.Drawing.Color.White;
            this.pbxMisty.Image = global::Pokemon_Trading_Card_Game.Properties.Resources.Misty_Profile;
            this.pbxMisty.Location = new System.Drawing.Point(1063, 41);
            this.pbxMisty.Name = "pbxMisty";
            this.pbxMisty.Size = new System.Drawing.Size(339, 340);
            this.pbxMisty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMisty.TabIndex = 6;
            this.pbxMisty.TabStop = false;
            // 
            // frmBattle2Intro
            // 
            this.AcceptButton = this.btnBattle2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pokemon_Trading_Card_Game.Properties.Resources.GreatBallStaduimBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1424, 822);
            this.Controls.Add(this.pbxMisty);
            this.Controls.Add(this.pbxBattle2Player);
            this.Controls.Add(this.btnBattle2);
            this.Controls.Add(this.lblBatlle2VS);
            this.Controls.Add(this.lblBattle2PlayerPrompt);
            this.Controls.Add(this.lblMistyPrompt);
            this.Controls.Add(this.lblBattle2Prompt);
            this.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmBattle2Intro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            ((System.ComponentModel.ISupportInitialize)(this.pbxBattle2Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMisty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBattle2Prompt;
        private System.Windows.Forms.Label lblMistyPrompt;
        private System.Windows.Forms.Label lblBattle2PlayerPrompt;
        private System.Windows.Forms.Label lblBatlle2VS;
        private System.Windows.Forms.Button btnBattle2;
        private System.Windows.Forms.PictureBox pbxBattle2Player;
        private System.Windows.Forms.PictureBox pbxMisty;
    }
}