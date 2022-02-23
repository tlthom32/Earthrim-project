namespace Code_Louisville_Final_project
{
    partial class appName
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param Name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.health = new System.Windows.Forms.Label();
            this.Gold = new System.Windows.Forms.Label();
            this.XP = new System.Windows.Forms.Label();
            this.Level = new System.Windows.Forms.Label();
            this.lblHitPoints = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.lblXP = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // health
            // 
            this.health.AutoSize = true;
            this.health.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.health.Location = new System.Drawing.Point(0, 8);
            this.health.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.health.Name = "health";
            this.health.Size = new System.Drawing.Size(71, 19);
            this.health.TabIndex = 0;
            this.health.Text = "Hit Points:";
            // 
            // Gold
            // 
            this.Gold.AutoSize = true;
            this.Gold.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gold.Location = new System.Drawing.Point(29, 27);
            this.Gold.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Gold.Name = "Gold";
            this.Gold.Size = new System.Drawing.Size(42, 19);
            this.Gold.TabIndex = 1;
            this.Gold.Text = "Gold:";
            // 
            // XP
            // 
            this.XP.AutoSize = true;
            this.XP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XP.Location = new System.Drawing.Point(39, 63);
            this.XP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.XP.Name = "XP";
            this.XP.Size = new System.Drawing.Size(32, 19);
            this.XP.TabIndex = 2;
            this.XP.Text = "XP:";
            // 
            // Level
            // 
            this.Level.AutoSize = true;
            this.Level.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Level.Location = new System.Drawing.Point(26, 44);
            this.Level.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(45, 19);
            this.Level.TabIndex = 3;
            this.Level.Text = "Level:";
            // 
            // lblHitPoints
            // 
            this.lblHitPoints.AutoSize = true;
            this.lblHitPoints.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHitPoints.ForeColor = System.Drawing.Color.Red;
            this.lblHitPoints.Location = new System.Drawing.Point(77, 8);
            this.lblHitPoints.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHitPoints.Name = "lblHitPoints";
            this.lblHitPoints.Size = new System.Drawing.Size(0, 19);
            this.lblHitPoints.TabIndex = 4;
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGold.ForeColor = System.Drawing.Color.Gold;
            this.lblGold.Location = new System.Drawing.Point(77, 27);
            this.lblGold.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(0, 19);
            this.lblGold.TabIndex = 5;
            // 
            // lblXP
            // 
            this.lblXP.AutoSize = true;
            this.lblXP.ForeColor = System.Drawing.Color.Blue;
            this.lblXP.Location = new System.Drawing.Point(77, 63);
            this.lblXP.Name = "lblXP";
            this.lblXP.Size = new System.Drawing.Size(0, 19);
            this.lblXP.TabIndex = 6;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.ForeColor = System.Drawing.Color.Lime;
            this.lblLevel.Location = new System.Drawing.Point(77, 44);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(0, 19);
            this.lblLevel.TabIndex = 7;
            // 
            // appName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(711, 631);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblXP);
            this.Controls.Add(this.lblGold);
            this.Controls.Add(this.lblHitPoints);
            this.Controls.Add(this.Level);
            this.Controls.Add(this.XP);
            this.Controls.Add(this.Gold);
            this.Controls.Add(this.health);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "appName";
            this.Text = "My Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label health;
        private System.Windows.Forms.Label Gold;
        private System.Windows.Forms.Label XP;
        private System.Windows.Forms.Label Level;
        private System.Windows.Forms.Label lblHitPoints;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.Label lblXP;
        private System.Windows.Forms.Label lblLevel;
    }
}

