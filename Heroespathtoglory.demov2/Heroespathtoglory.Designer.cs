namespace Heroespathtoglory
{
    partial class Heroespathtoglory
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHitPoints = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.lblExperience = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboWeapons = new System.Windows.Forms.ComboBox();
            this.cboPotions = new System.Windows.Forms.ComboBox();
            this.btnUseWeapon = new System.Windows.Forms.Button();
            this.btnUsePotion = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.rbtLocation = new System.Windows.Forms.RichTextBox();
            this.rbtMessages = new System.Windows.Forms.RichTextBox();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.dgvQuests = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMana = new System.Windows.Forms.Label();
            this.cboSpells = new System.Windows.Forms.ComboBox();
            this.btnUseSpell = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFuel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("ROG Fonts v1.5", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hit points:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("ROG Fonts v1.5", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(18, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gold:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("ROG Fonts v1.5", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(18, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Experience:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("ROG Fonts v1.5", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(18, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Level:";
            // 
            // lblHitPoints
            // 
            this.lblHitPoints.AutoSize = true;
            this.lblHitPoints.BackColor = System.Drawing.Color.Transparent;
            this.lblHitPoints.ForeColor = System.Drawing.Color.DarkRed;
            this.lblHitPoints.Location = new System.Drawing.Point(110, 20);
            this.lblHitPoints.Name = "lblHitPoints";
            this.lblHitPoints.Size = new System.Drawing.Size(0, 13);
            this.lblHitPoints.TabIndex = 4;
            this.lblHitPoints.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.BackColor = System.Drawing.Color.Transparent;
            this.lblGold.ForeColor = System.Drawing.Color.Gold;
            this.lblGold.Location = new System.Drawing.Point(110, 45);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(0, 13);
            this.lblGold.TabIndex = 5;
            this.lblGold.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblExperience
            // 
            this.lblExperience.AutoSize = true;
            this.lblExperience.BackColor = System.Drawing.Color.Transparent;
            this.lblExperience.ForeColor = System.Drawing.Color.Purple;
            this.lblExperience.Location = new System.Drawing.Point(110, 70);
            this.lblExperience.Name = "lblExperience";
            this.lblExperience.Size = new System.Drawing.Size(0, 13);
            this.lblExperience.TabIndex = 6;
            this.lblExperience.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblLevel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblLevel.Location = new System.Drawing.Point(110, 95);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(0, 13);
            this.lblLevel.TabIndex = 7;
            this.lblLevel.Click += new System.EventHandler(this.label8_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("ROG Fonts v1.5", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(440, 720);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Select action";
            // 
            // cboWeapons
            // 
            this.cboWeapons.BackColor = System.Drawing.Color.Silver;
            this.cboWeapons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cboWeapons.FormattingEnabled = true;
            this.cboWeapons.Location = new System.Drawing.Point(640, 780);
            this.cboWeapons.Name = "cboWeapons";
            this.cboWeapons.Size = new System.Drawing.Size(121, 21);
            this.cboWeapons.TabIndex = 9;
            this.cboWeapons.SelectedIndexChanged += new System.EventHandler(this.cboWeapons_SelectedIndexChanged);
            // 
            // cboPotions
            // 
            this.cboPotions.BackColor = System.Drawing.Color.Silver;
            this.cboPotions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cboPotions.FormattingEnabled = true;
            this.cboPotions.Location = new System.Drawing.Point(640, 820);
            this.cboPotions.Name = "cboPotions";
            this.cboPotions.Size = new System.Drawing.Size(121, 21);
            this.cboPotions.TabIndex = 10;
            this.cboPotions.SelectedIndexChanged += new System.EventHandler(this.cboPotions_SelectedIndexChanged);
            // 
            // btnUseWeapon
            // 
            this.btnUseWeapon.BackColor = System.Drawing.Color.Transparent;
            this.btnUseWeapon.BackgroundImage = global::Heroespathtoglory.Properties.Resources.button;
            this.btnUseWeapon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUseWeapon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUseWeapon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUseWeapon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUseWeapon.Location = new System.Drawing.Point(760, 780);
            this.btnUseWeapon.Name = "btnUseWeapon";
            this.btnUseWeapon.Size = new System.Drawing.Size(75, 23);
            this.btnUseWeapon.TabIndex = 11;
            this.btnUseWeapon.Text = "Use";
            this.btnUseWeapon.UseVisualStyleBackColor = false;
            this.btnUseWeapon.Click += new System.EventHandler(this.btnUseWeapon_Click);
            // 
            // btnUsePotion
            // 
            this.btnUsePotion.BackColor = System.Drawing.Color.Transparent;
            this.btnUsePotion.BackgroundImage = global::Heroespathtoglory.Properties.Resources.button;
            this.btnUsePotion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUsePotion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsePotion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUsePotion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUsePotion.Location = new System.Drawing.Point(760, 820);
            this.btnUsePotion.Name = "btnUsePotion";
            this.btnUsePotion.Size = new System.Drawing.Size(75, 23);
            this.btnUsePotion.TabIndex = 12;
            this.btnUsePotion.Text = "Use";
            this.btnUsePotion.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUsePotion.UseVisualStyleBackColor = false;
            this.btnUsePotion.Click += new System.EventHandler(this.btnUsePotion_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.Transparent;
            this.btnUp.BackgroundImage = global::Heroespathtoglory.Properties.Resources.button;
            this.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUp.Font = new System.Drawing.Font("ROG Fonts v1.5", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUp.Location = new System.Drawing.Point(1740, 700);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 23);
            this.btnUp.TabIndex = 13;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.Color.Transparent;
            this.btnDown.BackgroundImage = global::Heroespathtoglory.Properties.Resources.button;
            this.btnDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDown.Font = new System.Drawing.Font("ROG Fonts v1.5", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDown.Location = new System.Drawing.Point(1740, 780);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 23);
            this.btnDown.TabIndex = 14;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.Transparent;
            this.btnRight.BackgroundImage = global::Heroespathtoglory.Properties.Resources.button;
            this.btnRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRight.Font = new System.Drawing.Font("ROG Fonts v1.5", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRight.Location = new System.Drawing.Point(1800, 740);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 15;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.Transparent;
            this.btnLeft.BackgroundImage = global::Heroespathtoglory.Properties.Resources.button;
            this.btnLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLeft.Font = new System.Drawing.Font("ROG Fonts v1.5", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLeft.Location = new System.Drawing.Point(1680, 740);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 16;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // rbtLocation
            // 
            this.rbtLocation.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbtLocation.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtLocation.ForeColor = System.Drawing.Color.DarkGreen;
            this.rbtLocation.Location = new System.Drawing.Point(1250, 460);
            this.rbtLocation.Name = "rbtLocation";
            this.rbtLocation.ReadOnly = true;
            this.rbtLocation.Size = new System.Drawing.Size(350, 105);
            this.rbtLocation.TabIndex = 17;
            this.rbtLocation.Text = "";
            this.rbtLocation.TextChanged += new System.EventHandler(this.rbtLocation_TextChanged);
            // 
            // rbtMessages
            // 
            this.rbtMessages.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbtMessages.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtMessages.ForeColor = System.Drawing.Color.DarkGreen;
            this.rbtMessages.Location = new System.Drawing.Point(1250, 580);
            this.rbtMessages.Name = "rbtMessages";
            this.rbtMessages.ReadOnly = true;
            this.rbtMessages.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rbtMessages.Size = new System.Drawing.Size(350, 286);
            this.rbtMessages.TabIndex = 18;
            this.rbtMessages.Text = "";
            this.rbtMessages.TextChanged += new System.EventHandler(this.rbtMessages_TextChanged);
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.AllowUserToResizeRows = false;
            this.dgvInventory.BackgroundColor = System.Drawing.Color.Black;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInventory.Enabled = false;
            this.dgvInventory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgvInventory.Location = new System.Drawing.Point(320, 660);
            this.dgvInventory.MultiSelect = false;
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.RowHeadersVisible = false;
            this.dgvInventory.Size = new System.Drawing.Size(300, 200);
            this.dgvInventory.TabIndex = 19;
            this.dgvInventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventory_CellContentClick);
            // 
            // dgvQuests
            // 
            this.dgvQuests.AllowUserToAddRows = false;
            this.dgvQuests.AllowUserToDeleteRows = false;
            this.dgvQuests.AllowUserToResizeRows = false;
            this.dgvQuests.BackgroundColor = System.Drawing.Color.Black;
            this.dgvQuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuests.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvQuests.Enabled = false;
            this.dgvQuests.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgvQuests.Location = new System.Drawing.Point(320, 470);
            this.dgvQuests.MultiSelect = false;
            this.dgvQuests.Name = "dgvQuests";
            this.dgvQuests.ReadOnly = true;
            this.dgvQuests.RowHeadersVisible = false;
            this.dgvQuests.Size = new System.Drawing.Size(300, 189);
            this.dgvQuests.TabIndex = 20;
            this.dgvQuests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(1100, 460);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("ROG Fonts v1.5", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(20, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Mana";
            // 
            // lblMana
            // 
            this.lblMana.AutoSize = true;
            this.lblMana.BackColor = System.Drawing.Color.Transparent;
            this.lblMana.ForeColor = System.Drawing.Color.White;
            this.lblMana.Location = new System.Drawing.Point(110, 120);
            this.lblMana.Name = "lblMana";
            this.lblMana.Size = new System.Drawing.Size(0, 13);
            this.lblMana.TabIndex = 23;
            // 
            // cboSpells
            // 
            this.cboSpells.BackColor = System.Drawing.Color.Silver;
            this.cboSpells.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cboSpells.FormattingEnabled = true;
            this.cboSpells.Location = new System.Drawing.Point(640, 740);
            this.cboSpells.Name = "cboSpells";
            this.cboSpells.Size = new System.Drawing.Size(121, 21);
            this.cboSpells.TabIndex = 24;
            this.cboSpells.SelectedIndexChanged += new System.EventHandler(this.cboSpells_SelectedIndexChanged);
            // 
            // btnUseSpell
            // 
            this.btnUseSpell.BackColor = System.Drawing.Color.Transparent;
            this.btnUseSpell.BackgroundImage = global::Heroespathtoglory.Properties.Resources.button;
            this.btnUseSpell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUseSpell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUseSpell.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUseSpell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUseSpell.Location = new System.Drawing.Point(760, 740);
            this.btnUseSpell.Name = "btnUseSpell";
            this.btnUseSpell.Size = new System.Drawing.Size(75, 23);
            this.btnUseSpell.TabIndex = 25;
            this.btnUseSpell.Text = "Use";
            this.btnUseSpell.UseVisualStyleBackColor = false;
            this.btnUseSpell.Click += new System.EventHandler(this.btnUseSpell_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label7.Location = new System.Drawing.Point(20, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Fuel";
            this.label7.Click += new System.EventHandler(this.label7_Click_1);
            // 
            // lblFuel
            // 
            this.lblFuel.AutoSize = true;
            this.lblFuel.BackColor = System.Drawing.Color.Transparent;
            this.lblFuel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblFuel.Location = new System.Drawing.Point(110, 145);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(0, 13);
            this.lblFuel.TabIndex = 28;
            // 
            // Heroespathtoglory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Heroespathtoglory.Properties.Resources.interfacev1;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.lblFuel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnUseSpell);
            this.Controls.Add(this.cboSpells);
            this.Controls.Add(this.lblMana);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvQuests);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.rbtMessages);
            this.Controls.Add(this.rbtLocation);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnUsePotion);
            this.Controls.Add(this.btnUseWeapon);
            this.Controls.Add(this.cboPotions);
            this.Controls.Add(this.cboWeapons);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblExperience);
            this.Controls.Add(this.lblGold);
            this.Controls.Add(this.lblHitPoints);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Heroespathtoglory";
            this.Text = "Heroespathtoglory";
            this.Load += new System.EventHandler(this.Heroespathtoglory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHitPoints;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.Label lblExperience;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboWeapons;
        private System.Windows.Forms.ComboBox cboPotions;
        private System.Windows.Forms.Button btnUseWeapon;
        private System.Windows.Forms.Button btnUsePotion;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.RichTextBox rbtLocation;
        private System.Windows.Forms.RichTextBox rbtMessages;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.DataGridView dgvQuests;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMana;
        private System.Windows.Forms.ComboBox cboSpells;
        private System.Windows.Forms.Button btnUseSpell;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFuel;
    }
}

