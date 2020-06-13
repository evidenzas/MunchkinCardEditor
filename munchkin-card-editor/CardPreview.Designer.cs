namespace munchkin_card_editor
{
    partial class CardPreview
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cardDescLabel = new System.Windows.Forms.Label();
            this.monsterLvlOrRestrLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rightBottomLabel = new System.Windows.Forms.Label();
            this.leftBottomLabel = new System.Windows.Forms.Label();
            this.backColorButton = new System.Windows.Forms.Button();
            this.fontColorButton = new System.Windows.Forms.Button();
            this.itemBonusLabel = new System.Windows.Forms.Label();
            this.bigItemLabel = new System.Windows.Forms.Label();
            this.oneShotTrOrLvlUpLabel = new System.Windows.Forms.Label();
            this.modifierToTheMonsterLvlLabel = new System.Windows.Forms.Label();
            this.saveDraftButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(3, 47);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(328, 25);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "no card name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(258, 472);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(70, 40);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save card as image";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cardDescLabel, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.nameLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.monsterLvlOrRestrLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.itemBonusLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.bigItemLabel, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.oneShotTrOrLvlUpLabel, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.modifierToTheMonsterLvlLabel, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(334, 466);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 99);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel1.SetRowSpan(this.panel1, 3);
            this.panel1.Size = new System.Drawing.Size(328, 201);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(9, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 195);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // cardDescLabel
            // 
            this.cardDescLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cardDescLabel.AutoSize = true;
            this.cardDescLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cardDescLabel.Location = new System.Drawing.Point(106, 303);
            this.cardDescLabel.Name = "cardDescLabel";
            this.cardDescLabel.Size = new System.Drawing.Size(122, 16);
            this.cardDescLabel.TabIndex = 7;
            this.cardDescLabel.Text = "no card description";
            this.cardDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monsterLvlOrRestrLabel
            // 
            this.monsterLvlOrRestrLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.monsterLvlOrRestrLabel.AutoSize = true;
            this.monsterLvlOrRestrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.monsterLvlOrRestrLabel.Location = new System.Drawing.Point(3, 24);
            this.monsterLvlOrRestrLabel.Name = "monsterLvlOrRestrLabel";
            this.monsterLvlOrRestrLabel.Size = new System.Drawing.Size(328, 20);
            this.monsterLvlOrRestrLabel.TabIndex = 8;
            this.monsterLvlOrRestrLabel.Text = "MonsterLvl/ItemRestriction";
            this.monsterLvlOrRestrLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.monsterLvlOrRestrLabel.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rightBottomLabel);
            this.panel2.Controls.Add(this.leftBottomLabel);
            this.panel2.Location = new System.Drawing.Point(3, 444);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(328, 19);
            this.panel2.TabIndex = 9;
            // 
            // rightBottomLabel
            // 
            this.rightBottomLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightBottomLabel.AutoEllipsis = true;
            this.rightBottomLabel.AutoSize = true;
            this.rightBottomLabel.Location = new System.Drawing.Point(152, 0);
            this.rightBottomLabel.Name = "rightBottomLabel";
            this.rightBottomLabel.Size = new System.Drawing.Size(173, 13);
            this.rightBottomLabel.TabIndex = 1;
            this.rightBottomLabel.Text = "Cost/TreasureReward/Race/Class";
            this.rightBottomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rightBottomLabel.Visible = false;
            // 
            // leftBottomLabel
            // 
            this.leftBottomLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.leftBottomLabel.AutoSize = true;
            this.leftBottomLabel.Location = new System.Drawing.Point(0, 0);
            this.leftBottomLabel.Name = "leftBottomLabel";
            this.leftBottomLabel.Size = new System.Drawing.Size(125, 13);
            this.leftBottomLabel.TabIndex = 0;
            this.leftBottomLabel.Text = "PieceOfBody/LvlReward";
            this.leftBottomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.leftBottomLabel.Visible = false;
            // 
            // backColorButton
            // 
            this.backColorButton.Location = new System.Drawing.Point(91, 472);
            this.backColorButton.Name = "backColorButton";
            this.backColorButton.Size = new System.Drawing.Size(70, 40);
            this.backColorButton.TabIndex = 7;
            this.backColorButton.Text = "Change background color";
            this.backColorButton.UseVisualStyleBackColor = true;
            this.backColorButton.Click += new System.EventHandler(this.backColorButton_Click);
            // 
            // fontColorButton
            // 
            this.fontColorButton.Location = new System.Drawing.Point(6, 472);
            this.fontColorButton.Name = "fontColorButton";
            this.fontColorButton.Size = new System.Drawing.Size(70, 40);
            this.fontColorButton.TabIndex = 8;
            this.fontColorButton.Text = "Change font color";
            this.fontColorButton.UseVisualStyleBackColor = true;
            this.fontColorButton.Click += new System.EventHandler(this.fontColorButton_Click);
            // 
            // itemBonusLabel
            // 
            this.itemBonusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.itemBonusLabel.AutoSize = true;
            this.itemBonusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itemBonusLabel.Location = new System.Drawing.Point(3, 1);
            this.itemBonusLabel.Name = "itemBonusLabel";
            this.itemBonusLabel.Size = new System.Drawing.Size(328, 20);
            this.itemBonusLabel.TabIndex = 10;
            this.itemBonusLabel.Text = "ItemBonus";
            this.itemBonusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.itemBonusLabel.Visible = false;
            // 
            // bigItemLabel
            // 
            this.bigItemLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bigItemLabel.AutoSize = true;
            this.bigItemLabel.Location = new System.Drawing.Point(3, 425);
            this.bigItemLabel.Name = "bigItemLabel";
            this.bigItemLabel.Size = new System.Drawing.Size(22, 13);
            this.bigItemLabel.TabIndex = 11;
            this.bigItemLabel.Text = "Big";
            this.bigItemLabel.Visible = false;
            // 
            // oneShotTrOrLvlUpLabel
            // 
            this.oneShotTrOrLvlUpLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.oneShotTrOrLvlUpLabel.AutoSize = true;
            this.oneShotTrOrLvlUpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oneShotTrOrLvlUpLabel.Location = new System.Drawing.Point(3, 402);
            this.oneShotTrOrLvlUpLabel.Name = "oneShotTrOrLvlUpLabel";
            this.oneShotTrOrLvlUpLabel.Size = new System.Drawing.Size(328, 18);
            this.oneShotTrOrLvlUpLabel.TabIndex = 12;
            this.oneShotTrOrLvlUpLabel.Text = "GoUpALvl/OneShotTreausre";
            this.oneShotTrOrLvlUpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.oneShotTrOrLvlUpLabel.Visible = false;
            // 
            // modifierToTheMonsterLvlLabel
            // 
            this.modifierToTheMonsterLvlLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.modifierToTheMonsterLvlLabel.AutoSize = true;
            this.modifierToTheMonsterLvlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modifierToTheMonsterLvlLabel.Location = new System.Drawing.Point(3, 74);
            this.modifierToTheMonsterLvlLabel.Name = "modifierToTheMonsterLvlLabel";
            this.modifierToTheMonsterLvlLabel.Size = new System.Drawing.Size(328, 20);
            this.modifierToTheMonsterLvlLabel.TabIndex = 13;
            this.modifierToTheMonsterLvlLabel.Text = "Modifier to the monster lvl";
            this.modifierToTheMonsterLvlLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.modifierToTheMonsterLvlLabel.Visible = false;
            // 
            // saveDraftButton
            // 
            this.saveDraftButton.Location = new System.Drawing.Point(174, 472);
            this.saveDraftButton.Name = "saveDraftButton";
            this.saveDraftButton.Size = new System.Drawing.Size(70, 40);
            this.saveDraftButton.TabIndex = 9;
            this.saveDraftButton.Text = "Save card as draft";
            this.saveDraftButton.UseVisualStyleBackColor = true;
            this.saveDraftButton.Click += new System.EventHandler(this.saveDraftButton_Click);
            // 
            // CardPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 521);
            this.Controls.Add(this.saveDraftButton);
            this.Controls.Add(this.fontColorButton);
            this.Controls.Add(this.backColorButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.saveButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 560);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 560);
            this.Name = "CardPreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CardPreview";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button saveButton;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label cardDescLabel;
        private System.Windows.Forms.Button backColorButton;
        private System.Windows.Forms.Button fontColorButton;
        public System.Windows.Forms.Label monsterLvlOrRestrLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label rightBottomLabel;
        private System.Windows.Forms.Label leftBottomLabel;
        private System.Windows.Forms.Label itemBonusLabel;
        private System.Windows.Forms.Label bigItemLabel;
        private System.Windows.Forms.Label oneShotTrOrLvlUpLabel;
        private System.Windows.Forms.Label modifierToTheMonsterLvlLabel;
        private System.Windows.Forms.Button saveDraftButton;
    }
}