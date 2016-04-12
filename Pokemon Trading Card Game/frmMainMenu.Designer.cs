namespace Pokemon_Trading_Card_Game
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.btnEnterTournament = new System.Windows.Forms.Button();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnterTournament
            // 
            this.btnEnterTournament.BackColor = System.Drawing.Color.Firebrick;
            this.btnEnterTournament.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnterTournament.Location = new System.Drawing.Point(369, 690);
            this.btnEnterTournament.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnEnterTournament.Name = "btnEnterTournament";
            this.btnEnterTournament.Size = new System.Drawing.Size(171, 101);
            this.btnEnterTournament.TabIndex = 0;
            this.btnEnterTournament.Text = "Enter Tournament";
            this.btnEnterTournament.UseVisualStyleBackColor = false;
            this.btnEnterTournament.Click += new System.EventHandler(this.btnEnterTournament_Click);
            // 
            // btnInstructions
            // 
            this.btnInstructions.BackColor = System.Drawing.Color.Firebrick;
            this.btnInstructions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInstructions.Location = new System.Drawing.Point(654, 690);
            this.btnInstructions.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(171, 101);
            this.btnInstructions.TabIndex = 1;
            this.btnInstructions.Text = "Instructions";
            this.btnInstructions.UseVisualStyleBackColor = false;
            this.btnInstructions.Click += new System.EventHandler(this.btnInstructions_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Firebrick;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(931, 690);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(171, 101);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::Pokemon_Trading_Card_Game.Properties.Resources.Pokémon_Trading_Card_Game_Logo;
            this.pbxLogo.Location = new System.Drawing.Point(0, 0);
            this.pbxLogo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(1440, 650);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            // 
            // frmMainMenu
            // 
            this.AcceptButton = this.btnEnterTournament;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1424, 822);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnInstructions);
            this.Controls.Add(this.btnEnterTournament);
            this.Controls.Add(this.pbxLogo);
            this.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Button btnEnterTournament;
        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.Button btnExit;
    }
}

