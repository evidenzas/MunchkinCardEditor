using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_017_evi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox4.Hide();
            additionalParamsGroupBox.Hide();
            cardSubTypeGroupBox.Hide();
            choosePictureButton.Hide();
        }

        private void createNewCardButton_Click(object sender, EventArgs e)
        {
            createNewCardButton.Enabled = false;
            groupBox1.Show();
            groupBox2.Show();
            groupBox3.Show();
            groupBox4.Show();
            choosePictureButton.Show();
        }

        private void choosePictureButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            Stream fileStream = null;
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";

            openFileDialog.FileOk += CheckFileExt;

            if (openFileDialog.ShowDialog() == DialogResult.OK && (fileStream = openFileDialog.OpenFile()) != null)
            {
                try
                {
                    string fileName = openFileDialog.FileName;
                    using (fileStream)
                    {
                        picturePathLabel.Text = fileName;
                        try
                        {
                            pictureBox1.Image = Image.FromFile(fileName);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: Could not open image file");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }

            }
        }

        void CheckFileExt(object sender, System.ComponentModel.CancelEventArgs e)
        {
            OpenFileDialog openFileDialog = (sender as OpenFileDialog);
            if (Path.GetExtension(openFileDialog.FileName).ToLower() != ".jpg" &&
                Path.GetExtension(openFileDialog.FileName).ToLower() != ".jpeg" &&
                Path.GetExtension(openFileDialog.FileName).ToLower() != ".png")
            {
                e.Cancel = true;
                MessageBox.Show("Please choose files with the image extension: .jpg, .jpeg, .png");
                return;
            }
        }
        //Type params
        private void doorTypeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            cardSubTypeGroupBox.Controls.Clear();
            additionalParamsGroupBox.Controls.Clear();
            additionalParamsGroupBox.Hide();

            RadioButton classCardRadioButton = new RadioButton();
            RadioButton curseCardRadioButton = new RadioButton();
            RadioButton modifierCardRadioButton = new RadioButton();
            RadioButton monsterCardRadioButton = new RadioButton();
            RadioButton raceCardRadioButton = new RadioButton();

            classCardRadioButton.Text = "Class card";
            curseCardRadioButton.Text = "Curse card";
            modifierCardRadioButton.Text = "Modifier card";
            monsterCardRadioButton.Text = "Monster card";
            raceCardRadioButton.Text = "Race card";

            cardSubTypeGroupBox.Controls.Add(classCardRadioButton);
            cardSubTypeGroupBox.Controls.Add(curseCardRadioButton);
            cardSubTypeGroupBox.Controls.Add(modifierCardRadioButton);
            cardSubTypeGroupBox.Controls.Add(monsterCardRadioButton);
            cardSubTypeGroupBox.Controls.Add(raceCardRadioButton);

            cardSubTypeGroupBox.Size = new Size(130, 130);
            classCardRadioButton.Location = new Point(6, 15);
            curseCardRadioButton.Location = new Point(6, 35);
            modifierCardRadioButton.Location = new Point(6, 55);
            monsterCardRadioButton.Location = new Point(6, 75);
            raceCardRadioButton.Location = new Point(6, 95);

            classCardRadioButton.CheckedChanged += classCardRadioButton_CheckedChanged;
            curseCardRadioButton.CheckedChanged += curseCardRadioButton_CheckedChanged;
            modifierCardRadioButton.CheckedChanged += modifierCardRadioButton_CheckedChanged;
            monsterCardRadioButton.CheckedChanged += monsterCardRadioButton_CheckedChanged;
            raceCardRadioButton.CheckedChanged += raceCardRadioButton_CheckedChanged;

            cardSubTypeGroupBox.Show();
        }

        private void treasureTypeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            cardSubTypeGroupBox.Controls.Clear();
            additionalParamsGroupBox.Controls.Clear();
            additionalParamsGroupBox.Hide();

            RadioButton goUpALevelCardRadioButton = new RadioButton();
            RadioButton itemCardRadioButton = new RadioButton();
            RadioButton oneShotTreasureCardRadioButton = new RadioButton();

            goUpALevelCardRadioButton.Text = "Go up a level card";
            itemCardRadioButton.Text = "Item card";
            oneShotTreasureCardRadioButton.Text = "One shot trasure card";

            cardSubTypeGroupBox.Controls.Add(goUpALevelCardRadioButton);
            cardSubTypeGroupBox.Controls.Add(itemCardRadioButton);
            cardSubTypeGroupBox.Controls.Add(oneShotTreasureCardRadioButton);


            cardSubTypeGroupBox.Size = new Size(130, 90);
            goUpALevelCardRadioButton.Location = new Point(6, 20);
            itemCardRadioButton.Location = new Point(6, 40);
            oneShotTreasureCardRadioButton.Location = new Point(6, 60);

            goUpALevelCardRadioButton.CheckedChanged += goUpALevelCardRadioButton_CheckedChanged;
            itemCardRadioButton.CheckedChanged += itemCardRadioButton_CheckedChanged;
            oneShotTreasureCardRadioButton.CheckedChanged += oneShotTreasureCardRadioButton_CheckedChanged;

            cardSubTypeGroupBox.Show();
        }

        private void otherTypeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            cardSubTypeGroupBox.Controls.Clear();
            additionalParamsGroupBox.Controls.Clear();
            additionalParamsGroupBox.Hide();

            RadioButton otherCardRadioButton = new RadioButton();

            otherCardRadioButton.Text = "Other card";

            cardSubTypeGroupBox.Controls.Add(otherCardRadioButton);

            cardSubTypeGroupBox.Size = new Size(130, 45);
            otherCardRadioButton.Location = new Point(6, 15);

            otherCardRadioButton.CheckedChanged += otherCardRadioButton_CheckedChanged;

            cardSubTypeGroupBox.Show();
        }

        //Subtype Params
        private void classCardRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            additionalParamsGroupBox.Controls.Clear();
            additionalParamsGroupBox.Hide();
        }
        private void curseCardRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            additionalParamsGroupBox.Controls.Clear();
            additionalParamsGroupBox.Hide();
        }
        private void modifierCardRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            additionalParamsGroupBox.Controls.Clear();
            additionalParamsGroupBox.Size = new Size(170, 70);
            tableLayoutPanel1.SetRowSpan(additionalParamsGroupBox, 2);

            GroupBox modifierGroupBox = new GroupBox();
            additionalParamsGroupBox.Controls.Add(modifierGroupBox);
            modifierGroupBox.Text = "Modifier";

            GroupBox modifierSignGroupBox = new GroupBox();
            additionalParamsGroupBox.Controls.Add(modifierSignGroupBox);
            modifierSignGroupBox.Text = "Sign";

            modifierGroupBox.Location = new Point(60, 20);
            modifierGroupBox.Size = new Size(100, 40);

            modifierSignGroupBox.Location = new Point(5, 20);
            modifierSignGroupBox.Size = new Size(50, 40);

            ComboBox modifierPlusSignComboBox = new ComboBox();
            modifierSignGroupBox.Controls.Add(modifierPlusSignComboBox);
            modifierPlusSignComboBox.Items.Add("+");
            modifierPlusSignComboBox.Items.Add("-");
            modifierPlusSignComboBox.Text = "+";
            modifierPlusSignComboBox.Dock = DockStyle.Fill;
            modifierPlusSignComboBox.Size = new Size(30, 30);


            TextBox modifierTextBox = new TextBox();
            modifierGroupBox.Controls.Add(modifierTextBox);
            modifierTextBox.Dock = DockStyle.Fill;

            modifierTextBox.KeyPress += modifierTextBox_KeyPress;

            additionalParamsGroupBox.Show();
        }
        private void monsterCardRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            additionalParamsGroupBox.Controls.Clear();
            additionalParamsGroupBox.Size = new Size(160, 550);
            tableLayoutPanel1.SetRowSpan(additionalParamsGroupBox, 8);


            GroupBox monsterLevelGroupBox = new GroupBox();
            monsterLevelGroupBox.Text = "Monster level";
            GroupBox monsterRaceGroupBox = new GroupBox();
            monsterRaceGroupBox.Text = "Monster race";
            GroupBox treasureRewardGroupBox = new GroupBox();
            treasureRewardGroupBox.Text = "Treasure reward";
            GroupBox levelRewardGroupBox = new GroupBox();
            levelRewardGroupBox.Text = "Level reward";
            GroupBox badStuffGroupBox = new GroupBox();
            badStuffGroupBox.Text = "Bad stuff";

            additionalParamsGroupBox.Controls.Add(monsterLevelGroupBox);
            additionalParamsGroupBox.Controls.Add(monsterRaceGroupBox);
            additionalParamsGroupBox.Controls.Add(treasureRewardGroupBox);
            additionalParamsGroupBox.Controls.Add(levelRewardGroupBox);
            additionalParamsGroupBox.Controls.Add(badStuffGroupBox);

            monsterLevelGroupBox.Location = new Point(5, 20);
            monsterLevelGroupBox.Size = new Size(150, 40);
            monsterRaceGroupBox.Location = new Point(5, 60);
            monsterRaceGroupBox.Size = new Size(150, 40);
            treasureRewardGroupBox.Location = new Point(5, 100);
            treasureRewardGroupBox.Size = new Size(150, 40);
            levelRewardGroupBox.Location = new Point(5, 140);
            levelRewardGroupBox.Size = new Size(150, 40);
            badStuffGroupBox.Location = new Point(5, 180);
            badStuffGroupBox.Size = new Size(150, 150);

            TextBox monsterLevelTextBox = new TextBox();
            TextBox monsterRaceTextBox = new TextBox();
            TextBox treasureRewardTextBox = new TextBox();
            TextBox levelRewardTextBox = new TextBox();
            TextBox badStuffTextBox = new TextBox();

            monsterLevelGroupBox.Controls.Add(monsterLevelTextBox);
            monsterRaceGroupBox.Controls.Add(monsterRaceTextBox);
            treasureRewardGroupBox.Controls.Add(treasureRewardTextBox);
            levelRewardGroupBox.Controls.Add(levelRewardTextBox);
            badStuffGroupBox.Controls.Add(badStuffTextBox);

            monsterLevelTextBox.Dock = DockStyle.Fill;
            monsterRaceTextBox.Dock = DockStyle.Fill;
            treasureRewardTextBox.Dock = DockStyle.Fill;
            levelRewardTextBox.Dock = DockStyle.Fill;
            badStuffTextBox.Dock = DockStyle.Fill;
            badStuffTextBox.Multiline = true;
            badStuffTextBox.ScrollBars = ScrollBars.Vertical;

            monsterLevelTextBox.KeyPress += monsterLevelTextBox_KeyPress;
            treasureRewardTextBox.KeyPress += treasureRewardTextBox_KeyPress;
            levelRewardTextBox.KeyPress += levelRewardTextBox_KeyPress;

            additionalParamsGroupBox.Show();
        }
        private void raceCardRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            additionalParamsGroupBox.Controls.Clear();
            additionalParamsGroupBox.Hide();
        }

        private void goUpALevelCardRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            additionalParamsGroupBox.Controls.Clear();
            additionalParamsGroupBox.Hide();
        }
        private void itemCardRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            additionalParamsGroupBox.Controls.Clear();
            additionalParamsGroupBox.Size = new Size(160, 350);
            tableLayoutPanel1.SetRowSpan(additionalParamsGroupBox, 5);

            GroupBox modifierGroupBox = new GroupBox();
            additionalParamsGroupBox.Controls.Add(modifierGroupBox);
            modifierGroupBox.Text = "Modifier";

            GroupBox modifierSignGroupBox = new GroupBox();
            additionalParamsGroupBox.Controls.Add(modifierSignGroupBox);
            modifierSignGroupBox.Text = "Sign";

            modifierGroupBox.Location = new Point(60, 20);
            modifierGroupBox.Size = new Size(95, 40);

            modifierSignGroupBox.Location = new Point(5, 20);
            modifierSignGroupBox.Size = new Size(50, 40);

            ComboBox modifierPlusSignComboBox = new ComboBox();
            modifierSignGroupBox.Controls.Add(modifierPlusSignComboBox);
            modifierPlusSignComboBox.Items.Add("+");
            modifierPlusSignComboBox.Items.Add("-");
            modifierPlusSignComboBox.Text = "+";
            modifierPlusSignComboBox.Dock = DockStyle.Fill;
            modifierPlusSignComboBox.Size = new Size(30, 30);

            TextBox modifierTextBox = new TextBox();
            modifierGroupBox.Controls.Add(modifierTextBox);
            modifierTextBox.Dock = DockStyle.Fill;

            GroupBox raceRestrictionGroupBox = new GroupBox();
            raceRestrictionGroupBox.Text = "Race restriction";
            GroupBox partOfBodyGroupBox = new GroupBox();
            partOfBodyGroupBox.Text = "Part of body";
            GroupBox costGroupBox = new GroupBox();
            costGroupBox.Text = "Cost";

            additionalParamsGroupBox.Controls.Add(raceRestrictionGroupBox);
            additionalParamsGroupBox.Controls.Add(partOfBodyGroupBox);
            additionalParamsGroupBox.Controls.Add(costGroupBox);

            raceRestrictionGroupBox.Location = new Point(5, 60);
            raceRestrictionGroupBox.Size = new Size(150, 40);
            partOfBodyGroupBox.Location = new Point(5, 100);
            partOfBodyGroupBox.Size = new Size(150, 40);
            costGroupBox.Location = new Point(5, 140);
            costGroupBox.Size = new Size(150, 40);

            TextBox raceRestrictionTextBox = new TextBox();
            TextBox partOfBodyTextBox = new TextBox();
            TextBox costTextBox = new TextBox();

            raceRestrictionGroupBox.Controls.Add(raceRestrictionTextBox);
            partOfBodyGroupBox.Controls.Add(partOfBodyTextBox);
            costGroupBox.Controls.Add(costTextBox);

            raceRestrictionTextBox.Dock = DockStyle.Fill;
            partOfBodyTextBox.Dock = DockStyle.Fill;
            costTextBox.Dock = DockStyle.Fill;

            CheckBox isBigItemCheckBox = new CheckBox();
            isBigItemCheckBox.Text = "Big item";
            additionalParamsGroupBox.Controls.Add(isBigItemCheckBox);
            isBigItemCheckBox.Location = new Point(9, 180);

            modifierTextBox.KeyPress += modifierTextBox_KeyPress;
            costTextBox.KeyPress += costTextBox_KeyPress;

            additionalParamsGroupBox.Show();
        }
        private void oneShotTreasureCardRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            additionalParamsGroupBox.Controls.Clear();
            additionalParamsGroupBox.Size = new Size(170, 70);
            tableLayoutPanel1.SetRowSpan(additionalParamsGroupBox, 2);

            GroupBox costGroupBox = new GroupBox();
            additionalParamsGroupBox.Controls.Add(costGroupBox);
            costGroupBox.Text = "Cost";

            additionalParamsGroupBox.Controls.Add(costGroupBox);

            costGroupBox.Location = new Point(5, 20);
            costGroupBox.Size = new Size(150, 40);

            TextBox costTextBox = new TextBox();

            costGroupBox.Controls.Add(costTextBox);

            costTextBox.Dock = DockStyle.Fill;

            costTextBox.KeyPress += costTextBox_KeyPress;

            additionalParamsGroupBox.Show();
        }

        private void otherCardRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            additionalParamsGroupBox.Controls.Clear();
            additionalParamsGroupBox.Hide();
        }

        //UI validation for only nums input
        //split
        private void modifierTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //split
        private void costTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void monsterLevelTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void treasureRewardTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void levelRewardTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            cd.ShowDialog();
            this.BackColor = cd.Color;
            colorButton.BackColor = cd.Color;
            createNewCardButton.BackColor = cd.Color;
            saveDraftButton.BackColor = cd.Color;
            saveCardButton.BackColor = cd.Color;
            loadDraftButton.BackColor = cd.Color;
            choosePictureButton.BackColor = cd.Color;
        }
        /*
        private void saveCardButton_Click(object sender, EventArgs e)
        {
            if() 
            {
                //smt
                MessageBox.Show("class card created");
            }
        }*/


        private void saveCardButton_Click(object sender, EventArgs e)
        {
            foreach (RadioButton rb in cardSubTypeGroupBox.Controls)
            {
                if (rb.Checked)
                {
                    CardPreview cp = new CardPreview();
                    cp.pictureBox1.Image = pictureBox1.Image;
                    cp.nameLabel.Text = nameTextBox.Text;
                    cp.cardDescLabel.Text = descriptionTextBox.Text;

                    switch (rb.Text)
                    {
                        case "Class card":
                            cp.ShowDialog();
                            break;
                        case "Curse card":
                            //add creation
                            break;
                    }
                    //MessageBox.Show(rb.Text + " created");
                }
                else MessageBox.Show("Select card sub-type");
                break;
            }
        }





    }
}
