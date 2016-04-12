namespace Pokemon_Trading_Card_Game
{
    partial class frmChampion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChampion));
            this.lblCongrats = new System.Windows.Forms.Label();
            this.lblMaster = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCongrats
            // 
            this.lblCongrats.AutoSize = true;
            this.lblCongrats.BackColor = System.Drawing.Color.Transparent;
            this.lblCongrats.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCongrats.Location = new System.Drawing.Point(6, 0);
            this.lblCongrats.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblCongrats.Name = "lblCongrats";
            this.lblCongrats.Size = new System.Drawing.Size(728, 117);
            this.lblCongrats.TabIndex = 0;
            this.lblCongrats.Text = "Congratulations!\r\n";
            // 
            // lblMaster
            // 
            this.lblMaster.AutoSize = true;
            this.lblMaster.BackColor = System.Drawing.Color.Transparent;
            this.lblMaster.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaster.Location = new System.Drawing.Point(439, 753);
            this.lblMaster.Name = "lblMaster";
            this.lblMaster.Size = new System.Drawing.Size(554, 60);
            this.lblMaster.TabIndex = 1;
            this.lblMaster.Text = "You\'re A Pokemon Master!";
            // 
            // frmChampion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Pokemon_Trading_Card_Game.Properties.Resources.Celebrate;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1424, 822);
            this.Controls.Add(this.lblMaster);
            this.Controls.Add(this.lblCongrats);
            this.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "frmChampion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCongrats;
        private System.Windows.Forms.Label lblMaster;
    }
}