namespace Pokemon_Trading_Card_Game
{
    partial class frmBattle1Intro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBattle1Intro));
            this.pbxBattle1Player = new System.Windows.Forms.PictureBox();
            this.btnBattle1 = new System.Windows.Forms.Button();
            this.lblBattle1Prompt = new System.Windows.Forms.Label();
            this.lblBattle1VSPrompt = new System.Windows.Forms.Label();
            this.lblBattle1BrockPrompt = new System.Windows.Forms.Label();
            this.lblBattle1PlayerPrompt = new System.Windows.Forms.Label();
            this.pbxBattle1Brock = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBattle1Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBattle1Brock)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxBattle1Player
            // 
            this.pbxBattle1Player.Image = global::Pokemon_Trading_Card_Game.Properties.Resources.Trainer_Profile;
            this.pbxBattle1Player.Location = new System.Drawing.Point(25, 482);
            this.pbxBattle1Player.Name = "pbxBattle1Player";
            this.pbxBattle1Player.Size = new System.Drawing.Size(339, 340);
            this.pbxBattle1Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxBattle1Player.TabIndex = 1;
            this.pbxBattle1Player.TabStop = false;
            // 
            // btnBattle1
            // 
            this.btnBattle1.BackColor = System.Drawing.Color.Firebrick;
            this.btnBattle1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBattle1.ForeColor = System.Drawing.Color.White;
            this.btnBattle1.Location = new System.Drawing.Point(630, 652);
            this.btnBattle1.Name = "btnBattle1";
            this.btnBattle1.Size = new System.Drawing.Size(171, 101);
            this.btnBattle1.TabIndex = 2;
            this.btnBattle1.Text = "Begin Battle";
            this.btnBattle1.UseVisualStyleBackColor = false;
            this.btnBattle1.Click += new System.EventHandler(this.btnBattle1_Click);
            // 
            // lblBattle1Prompt
            // 
            this.lblBattle1Prompt.AutoSize = true;
            this.lblBattle1Prompt.BackColor = System.Drawing.Color.Transparent;
            this.lblBattle1Prompt.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBattle1Prompt.Location = new System.Drawing.Point(633, 137);
            this.lblBattle1Prompt.Name = "lblBattle1Prompt";
            this.lblBattle1Prompt.Size = new System.Drawing.Size(178, 60);
            this.lblBattle1Prompt.TabIndex = 3;
            this.lblBattle1Prompt.Text = "Battle 1";
            // 
            // lblBattle1VSPrompt
            // 
            this.lblBattle1VSPrompt.AutoSize = true;
            this.lblBattle1VSPrompt.BackColor = System.Drawing.Color.Transparent;
            this.lblBattle1VSPrompt.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBattle1VSPrompt.Location = new System.Drawing.Point(683, 389);
            this.lblBattle1VSPrompt.Name = "lblBattle1VSPrompt";
            this.lblBattle1VSPrompt.Size = new System.Drawing.Size(86, 60);
            this.lblBattle1VSPrompt.TabIndex = 4;
            this.lblBattle1VSPrompt.Text = "VS.";
            // 
            // lblBattle1BrockPrompt
            // 
            this.lblBattle1BrockPrompt.AutoSize = true;
            this.lblBattle1BrockPrompt.BackColor = System.Drawing.Color.Transparent;
            this.lblBattle1BrockPrompt.Location = new System.Drawing.Point(1180, 9);
            this.lblBattle1BrockPrompt.Name = "lblBattle1BrockPrompt";
            this.lblBattle1BrockPrompt.Size = new System.Drawing.Size(75, 29);
            this.lblBattle1BrockPrompt.TabIndex = 5;
            this.lblBattle1BrockPrompt.Text = "Brock";
            // 
            // lblBattle1PlayerPrompt
            // 
            this.lblBattle1PlayerPrompt.AutoSize = true;
            this.lblBattle1PlayerPrompt.BackColor = System.Drawing.Color.Transparent;
            this.lblBattle1PlayerPrompt.Location = new System.Drawing.Point(153, 450);
            this.lblBattle1PlayerPrompt.Name = "lblBattle1PlayerPrompt";
            this.lblBattle1PlayerPrompt.Size = new System.Drawing.Size(81, 29);
            this.lblBattle1PlayerPrompt.TabIndex = 6;
            this.lblBattle1PlayerPrompt.Text = "Player";
            // 
            // pbxBattle1Brock
            // 
            this.pbxBattle1Brock.Image = global::Pokemon_Trading_Card_Game.Properties.Resources.BrockProfile;
            this.pbxBattle1Brock.Location = new System.Drawing.Point(1028, 41);
            this.pbxBattle1Brock.Name = "pbxBattle1Brock";
            this.pbxBattle1Brock.Size = new System.Drawing.Size(370, 338);
            this.pbxBattle1Brock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBattle1Brock.TabIndex = 7;
            this.pbxBattle1Brock.TabStop = false;
            // 
            // frmBattle1Intro
            // 
            this.AcceptButton = this.btnBattle1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Pokemon_Trading_Card_Game.Properties.Resources.PokeballStadiumBackround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1424, 822);
            this.Controls.Add(this.pbxBattle1Brock);
            this.Controls.Add(this.lblBattle1PlayerPrompt);
            this.Controls.Add(this.lblBattle1BrockPrompt);
            this.Controls.Add(this.lblBattle1VSPrompt);
            this.Controls.Add(this.lblBattle1Prompt);
            this.Controls.Add(this.btnBattle1);
            this.Controls.Add(this.pbxBattle1Player);
            this.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frmBattle1Intro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            
            ((System.ComponentModel.ISupportInitialize)(this.pbxBattle1Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBattle1Brock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBattle1;
        private System.Windows.Forms.Label lblBattle1Prompt;
        private System.Windows.Forms.Label lblBattle1VSPrompt;
        private System.Windows.Forms.Label lblBattle1BrockPrompt;
        private System.Windows.Forms.Label lblBattle1PlayerPrompt;
        private System.Windows.Forms.PictureBox pbxBattle1Brock;
        private System.Windows.Forms.PictureBox pbxBattle1Player;
    }
}