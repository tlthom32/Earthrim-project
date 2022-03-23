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
            this.label1 = new System.Windows.Forms.Label();
            this.cboWeapons = new System.Windows.Forms.ComboBox();
            this.cboPotions = new System.Windows.Forms.ComboBox();
            this.btnUseWeapon = new System.Windows.Forms.Button();
            this.btnUsePotion = new System.Windows.Forms.Button();
            this.btnNorth = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.btnSouth = new System.Windows.Forms.Button();
            this.rtbLocation = new System.Windows.Forms.RichTextBox();
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.dgvQuests = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).BeginInit();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(535, 537);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select Action";
            // 
            // cboWeapons
            // 
            this.cboWeapons.FormattingEnabled = true;
            this.cboWeapons.Location = new System.Drawing.Point(366, 555);
            this.cboWeapons.Name = "cboWeapons";
            this.cboWeapons.Size = new System.Drawing.Size(121, 27);
            this.cboWeapons.TabIndex = 9;
            this.cboWeapons.SelectedIndexChanged += new System.EventHandler(this.cboWeapons_SelectedIndexChanged);
            // 
            // cboPotions
            // 
            this.cboPotions.FormattingEnabled = true;
            this.cboPotions.Location = new System.Drawing.Point(366, 588);
            this.cboPotions.Name = "cboPotions";
            this.cboPotions.Size = new System.Drawing.Size(121, 27);
            this.cboPotions.TabIndex = 10;
            this.cboPotions.SelectedIndexChanged += new System.EventHandler(this.cboPotions_SelectedIndexChanged);
            // 
            // btnUseWeapon
            // 
            this.btnUseWeapon.Location = new System.Drawing.Point(539, 559);
            this.btnUseWeapon.Name = "btnUseWeapon";
            this.btnUseWeapon.Size = new System.Drawing.Size(75, 23);
            this.btnUseWeapon.TabIndex = 11;
            this.btnUseWeapon.Text = "Use";
            this.btnUseWeapon.UseVisualStyleBackColor = true;
            this.btnUseWeapon.Click += new System.EventHandler(this.btnUseWeapon_Click);
            // 
            // btnUsePotion
            // 
            this.btnUsePotion.Location = new System.Drawing.Point(539, 592);
            this.btnUsePotion.Name = "btnUsePotion";
            this.btnUsePotion.Size = new System.Drawing.Size(75, 23);
            this.btnUsePotion.TabIndex = 12;
            this.btnUsePotion.Text = "Use";
            this.btnUsePotion.UseVisualStyleBackColor = true;
            this.btnUsePotion.Click += new System.EventHandler(this.btnUsePotion_Click);
            // 
            // btnNorth
            // 
            this.btnNorth.Location = new System.Drawing.Point(439, 464);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(75, 23);
            this.btnNorth.TabIndex = 13;
            this.btnNorth.Text = "North";
            this.btnNorth.UseVisualStyleBackColor = true;
            this.btnNorth.Click += new System.EventHandler(this.btnNorth_Click);
            // 
            // btnEast
            // 
            this.btnEast.Location = new System.Drawing.Point(486, 493);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(75, 23);
            this.btnEast.TabIndex = 14;
            this.btnEast.Text = "East";
            this.btnEast.UseVisualStyleBackColor = true;
            this.btnEast.Click += new System.EventHandler(this.btnEast_Click);
            // 
            // btnWest
            // 
            this.btnWest.Location = new System.Drawing.Point(396, 493);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(75, 23);
            this.btnWest.TabIndex = 15;
            this.btnWest.Text = "West";
            this.btnWest.UseVisualStyleBackColor = true;
            this.btnWest.Click += new System.EventHandler(this.btnWest_Click);
            // 
            // btnSouth
            // 
            this.btnSouth.Location = new System.Drawing.Point(439, 522);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(75, 23);
            this.btnSouth.TabIndex = 16;
            this.btnSouth.Text = "South";
            this.btnSouth.UseVisualStyleBackColor = true;
            this.btnSouth.Click += new System.EventHandler(this.btnSouth_Click);
            // 
            // rtbLocation
            // 
            this.rtbLocation.Location = new System.Drawing.Point(339, 12);
            this.rtbLocation.Name = "rtbLocation";
            this.rtbLocation.ReadOnly = true;
            this.rtbLocation.Size = new System.Drawing.Size(360, 105);
            this.rtbLocation.TabIndex = 17;
            this.rtbLocation.Text = "";
            // 
            // rtbMessages
            // 
            this.rtbMessages.Location = new System.Drawing.Point(339, 128);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.ReadOnly = true;
            this.rtbMessages.Size = new System.Drawing.Size(360, 286);
            this.rtbMessages.TabIndex = 18;
            this.rtbMessages.Text = "";
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInventory.Location = new System.Drawing.Point(21, 111);
            this.dgvInventory.MultiSelect = false;
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.Size = new System.Drawing.Size(312, 309);
            this.dgvInventory.TabIndex = 19;
            // 
            // dgvQuests
            // 
            this.dgvQuests.AllowUserToAddRows = false;
            this.dgvQuests.AllowUserToDeleteRows = false;
            this.dgvQuests.AllowUserToResizeRows = false;
            this.dgvQuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuests.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvQuests.Location = new System.Drawing.Point(21, 426);
            this.dgvQuests.MultiSelect = false;
            this.dgvQuests.Name = "dgvQuests";
            this.dgvQuests.ReadOnly = true;
            this.dgvQuests.Size = new System.Drawing.Size(312, 189);
            this.dgvQuests.TabIndex = 20;
            // 
            // appName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(711, 631);
            this.Controls.Add(this.dgvQuests);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.rtbMessages);
            this.Controls.Add(this.rtbLocation);
            this.Controls.Add(this.btnSouth);
            this.Controls.Add(this.btnWest);
            this.Controls.Add(this.btnEast);
            this.Controls.Add(this.btnNorth);
            this.Controls.Add(this.btnUsePotion);
            this.Controls.Add(this.btnUseWeapon);
            this.Controls.Add(this.cboPotions);
            this.Controls.Add(this.cboWeapons);
            this.Controls.Add(this.label1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboWeapons;
        private System.Windows.Forms.ComboBox cboPotions;
        private System.Windows.Forms.Button btnUseWeapon;
        private System.Windows.Forms.Button btnUsePotion;
        private System.Windows.Forms.Button btnNorth;
        private System.Windows.Forms.Button btnEast;
        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.RichTextBox rtbLocation;
        private System.Windows.Forms.RichTextBox rtbMessages;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.DataGridView dgvQuests;
    }
}

