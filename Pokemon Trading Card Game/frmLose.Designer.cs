namespace Pokemon_Trading_Card_Game
{
    partial class frmLose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLose));
            this.lblGameOver = new System.Windows.Forms.Label();
            this.lblYouLose = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.Color.Transparent;
            this.lblGameOver.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.Location = new System.Drawing.Point(948, 705);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(477, 117);
            this.lblGameOver.TabIndex = 0;
            this.lblGameOver.Text = "Game Over";
            // 
            // lblYouLose
            // 
            this.lblYouLose.AutoSize = true;
            this.lblYouLose.BackColor = System.Drawing.Color.Transparent;
            this.lblYouLose.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYouLose.Location = new System.Drawing.Point(-1, -2);
            this.lblYouLose.Name = "lblYouLose";
            this.lblYouLose.Size = new System.Drawing.Size(435, 117);
            this.lblYouLose.TabIndex = 1;
            this.lblYouLose.Text = "You Lost...";
            // 
            // frmLose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Pokemon_Trading_Card_Game.Properties.Resources.CryingPikachu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1424, 822);
            this.Controls.Add(this.lblYouLose);
            this.Controls.Add(this.lblGameOver);
            this.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frmLose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label lblYouLose;
    }
}