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
using task_017_evi.Cards;
using task_017_evi.Model;
using task_017_evi.Model.Doors;
using task_017_evi.Model.Treasures;

namespace task_017_evi
{
    public partial class Form1 : Form
    {
        public Card card;
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
                        catch (Exception)
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
            modifierPlusSignComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
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

            GroupBox itemModifierGroupBox = new GroupBox();
            additionalParamsGroupBox.Controls.Add(itemModifierGroupBox);
            itemModifierGroupBox.Text = "Modifier";

            GroupBox itemModifierSignGroupBox = new GroupBox();
            additionalParamsGroupBox.Controls.Add(itemModifierSignGroupBox);
            itemModifierSignGroupBox.Text = "Sign";

            itemModifierGroupBox.Location = new Point(60, 20);
            itemModifierGroupBox.Size = new Size(95, 40);

            itemModifierSignGroupBox.Location = new Point(5, 20);
            itemModifierSignGroupBox.Size = new Size(50, 40);

            ComboBox itemModifierPlusSignComboBox = new ComboBox();
            itemModifierSignGroupBox.Controls.Add(itemModifierPlusSignComboBox);
            itemModifierPlusSignComboBox.Items.Add("+");
            itemModifierPlusSignComboBox.Items.Add("-");
            itemModifierPlusSignComboBox.Text = "+";
            itemModifierPlusSignComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            itemModifierPlusSignComboBox.Dock = DockStyle.Fill;
            itemModifierPlusSignComboBox.Size = new Size(30, 30);

            TextBox itemModifierTextBox = new TextBox();
            itemModifierGroupBox.Controls.Add(itemModifierTextBox);
            itemModifierTextBox.Dock = DockStyle.Fill;

            GroupBox restrictionGroupBox = new GroupBox();
            restrictionGroupBox.Text = "Restriction";
            GroupBox partOfBodyGroupBox = new GroupBox();
            partOfBodyGroupBox.Text = "Part of body";
            GroupBox costGroupBox = new GroupBox();
            costGroupBox.Text = "Cost";

            additionalParamsGroupBox.Controls.Add(restrictionGroupBox);
            additionalParamsGroupBox.Controls.Add(partOfBodyGroupBox);
            additionalParamsGroupBox.Controls.Add(costGroupBox);

            restrictionGroupBox.Location = new Point(5, 60);
            restrictionGroupBox.Size = new Size(150, 40);
            partOfBodyGroupBox.Location = new Point(5, 100);
            partOfBodyGroupBox.Size = new Size(150, 40);
            costGroupBox.Location = new Point(5, 140);
            costGroupBox.Size = new Size(150, 40);

            TextBox restrictionTextBox = new TextBox();
            TextBox partOfBodyTextBox = new TextBox();
            TextBox costTextBox = new TextBox();

            restrictionGroupBox.Controls.Add(restrictionTextBox);
            partOfBodyGroupBox.Controls.Add(partOfBodyTextBox);
            costGroupBox.Controls.Add(costTextBox);

            restrictionTextBox.Dock = DockStyle.Fill;
            partOfBodyTextBox.Dock = DockStyle.Fill;
            costTextBox.Dock = DockStyle.Fill;

            CheckBox isBigItemCheckBox = new CheckBox();
            isBigItemCheckBox.Text = "Big item";
            additionalParamsGroupBox.Controls.Add(isBigItemCheckBox);
            isBigItemCheckBox.Location = new Point(9, 180);
            
            itemModifierTextBox.KeyPress += itemModifierTextBox_KeyPress;

            additionalParamsGroupBox.Show();
        }
        private void oneShotTreasureCardRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            additionalParamsGroupBox.Controls.Clear();
            additionalParamsGroupBox.Size = new Size(170, 70);
            tableLayoutPanel1.SetRowSpan(additionalParamsGroupBox, 2);

            GroupBox costOSTGroupBox = new GroupBox();
            additionalParamsGroupBox.Controls.Add(costOSTGroupBox);
            costOSTGroupBox.Text = "Cost";

            additionalParamsGroupBox.Controls.Add(costOSTGroupBox);

            costOSTGroupBox.Location = new Point(5, 20);
            costOSTGroupBox.Size = new Size(150, 40);

            TextBox costOSTTextBox = new TextBox();

            costOSTGroupBox.Controls.Add(costOSTTextBox);

            costOSTTextBox.Dock = DockStyle.Fill;

            additionalParamsGroupBox.Show();
        }

        private void otherCardRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            additionalParamsGroupBox.Controls.Clear();
            additionalParamsGroupBox.Hide();
        }

        //UI validation for only nums input
        private void modifierTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void itemModifierTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
            saveCardButton.BackColor = cd.Color;
            loadDraftButton.BackColor = cd.Color;
            choosePictureButton.BackColor = cd.Color;
            clearButton.BackColor = cd.Color;
        }

        public static string GetMyData(Control container, int controlIndex, int depth, params int[] containerIndicies)
        {
            var myContainer = container;
            for (int i = 0; i < depth; i++)
            {
                if (myContainer.Controls == null || myContainer.Controls.Count - 1 < containerIndicies[i]) return null;

                myContainer = myContainer.Controls.Cast<Control>().Where(
                    c => c is GroupBox || c is FlowLayoutPanel || c is TableLayoutPanel).ElementAt(containerIndicies[i]);
                if (myContainer == null) return null;
            }

            if (myContainer.Controls.Count - 1 < controlIndex) return null;
            var myControl = myContainer.Controls[controlIndex];
            switch (myControl)
            {
                case TextBox _:
                    return myControl.Text;
                case ComboBox _:
                    return myControl.Text;
                case CheckBox _:
                    return (myControl as CheckBox).Checked.ToString();
                case RadioButton _:
                    return (myControl as RadioButton).Checked.ToString();
                default:
                    return null;
            }
        }

        private void saveCardButton_Click(object sender, EventArgs e)
        {
            var checkedButton = cardSubTypeGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            if (checkedButton != null && checkedButton.Checked)
            {
                if (card == null) card = CardCreator.CreateNewCard(checkedButton.Text);
                else
                {
                    Color fontColor = card.FontCardColor;
                    Color backColor = card.BackCardColor;
                    card = CardCreator.CreateNewCard(checkedButton.Text);
                    card.FontCardColor = fontColor;
                    card.BackCardColor = backColor;
                }
                //var card = CardCreator.CreateNewCard(checkedButton.Text);
                CardCreator.FillMainFieldsOfCard(card, picturePathLabel.Text, nameTextBox.Text, descriptionTextBox.Text);
                var test = GetMyData(additionalParamsGroupBox, 5, 0, 0);
                switch (checkedButton.Text)
                {
                    case "Modifier card":
                        CardCreator.FillAdvFiledsOfCard((ModifierCard)card, 
                            GetMyData(additionalParamsGroupBox, 0, 1, 0),
                            GetMyData(additionalParamsGroupBox, 0, 1, 1));
                        break;
                    case "Monster card":
                        CardCreator.FillAdvFiledsOfCard((MonsterCard)card, 
                            GetMyData(additionalParamsGroupBox, 0, 1, 0),
                            GetMyData(additionalParamsGroupBox, 0, 1, 1),
                            GetMyData(additionalParamsGroupBox, 0, 1, 4),
                            GetMyData(additionalParamsGroupBox, 0, 1, 2),
                            GetMyData(additionalParamsGroupBox, 0, 1, 3));

                        break;
                    case "Item card":
                        CardCreator.FillAdvFiledsOfCard((ItemCard)card,
                            GetMyData(additionalParamsGroupBox, 0, 1, 0),
                            GetMyData(additionalParamsGroupBox, 0, 1, 1),
                            GetMyData(additionalParamsGroupBox, 0, 1, 2),
                            GetMyData(additionalParamsGroupBox, 0, 1, 3),
                            GetMyData(additionalParamsGroupBox, 0, 1, 4),
                            GetMyData(additionalParamsGroupBox, 5, 0, 0));
                        break;
                    case "One shot trasure card":
                        CardCreator.FillAdvFiledsOfCard((OneShotTreasureCard)card, GetMyData(additionalParamsGroupBox, 0, 1, 0));
                        break;
                }
                CardPreview cp = new CardPreview(card);
                cp.ShowDialog();
            }
            else MessageBox.Show("Select card sub-type");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            foreach (var item in groupBox4.Controls)
            {
                (item as RadioButton).Checked = false;
            }

            cardSubTypeGroupBox.Controls.Clear();
            cardSubTypeGroupBox.Hide();
            additionalParamsGroupBox.Controls.Clear();
            additionalParamsGroupBox.Hide();

            picturePathLabel.Text = "";
            pictureBox1.Image = null;
            nameTextBox.Text = "";
            descriptionTextBox.Text = "";

            if (card != null) card = null;
        }
        void CheckJsonFileExt(object sender, System.ComponentModel.CancelEventArgs e)
        {
            OpenFileDialog openFileDialog = (sender as OpenFileDialog);
            if (Path.GetExtension(openFileDialog.FileName).ToLower() != ".json" &&
                Path.GetExtension(openFileDialog.FileName).ToLower() != ".txt")
            {
                e.Cancel = true;
                MessageBox.Show("Please choose files with the text extension: .json or .txt");
                return;
            }
        }

        private void loadDraftButton_Click(object sender, EventArgs e)
        {
            var openDraftFileDialog = new OpenFileDialog();
            Stream fileStream = null;
            openDraftFileDialog.Filter = "Json files (*.json, *.txt) | *.json; *.txt;";

            openDraftFileDialog.FileOk += CheckJsonFileExt;

            if (openDraftFileDialog.ShowDialog() == DialogResult.OK && (fileStream = openDraftFileDialog.OpenFile()) != null)
            {
                try
                {
                    string fileName = openDraftFileDialog.FileName;
                    using (fileStream)
                    {
                        string filelines = File.ReadAllText(fileName);
                        card = JsonWorker.CardDeserialize(filelines);
                        try
                        {
                            createNewCardButton.Enabled = false;
                            groupBox1.Show();
                            groupBox2.Show();
                            groupBox3.Show();
                            groupBox4.Show();
                            choosePictureButton.Show();

                            //fill form fields from drafft file
                            nameTextBox.Text = card.Name;
                            descriptionTextBox.Text = card.Description;
                            picturePathLabel.Text = card.PicturePath;
                            pictureBox1.Image = Image.FromFile(card.PicturePath);
                            //TODO add card type field
                            //and then https://stackoverflow.com/questions/8513042/json-net-serialize-deserialize-derived-types
                            /*
                            cardSubTypeGroupBox.Show();
                            cardSubTypeGroupBox.Controls.Clear();
                            cardSubTypeGroupBox.Show();
                            additionalParamsGroupBox.Controls.Clear();
                            additionalParamsGroupBox.Show();
                            */

                            switch (card.CardType)
                            {
                                case "ClassCard":
                                    doorTypeRadioButton.Checked = true;
                                    cardSubTypeGroupBox.Show();
                                    (cardSubTypeGroupBox.Controls[0] as RadioButton).Checked = true;
                                    break;
                                case "CurseCard":
                                    doorTypeRadioButton.Checked = true;
                                    cardSubTypeGroupBox.Show();
                                    (cardSubTypeGroupBox.Controls[1] as RadioButton).Checked = true;
                                    break;
                                case "ModifierCard":
                                    doorTypeRadioButton.Checked = true;
                                    (cardSubTypeGroupBox.Controls[2] as RadioButton).Checked = true;
                                    additionalParamsGroupBox.Controls[1].Controls[0].Text = ((ModifierCard)card).Sign;
                                    additionalParamsGroupBox.Controls[0].Controls[0].Text = ((ModifierCard)card).Modifier.ToString();
                                    cardSubTypeGroupBox.Show();
                                    break;
                                case "MonsterCard":
                                    doorTypeRadioButton.Checked = true;
                                    (cardSubTypeGroupBox.Controls[3] as RadioButton).Checked = true;
                                    additionalParamsGroupBox.Controls[0].Controls[0].Text = ((MonsterCard)card).Level.ToString();
                                    additionalParamsGroupBox.Controls[1].Controls[0].Text = ((MonsterCard)card).Race.ToString();
                                    additionalParamsGroupBox.Controls[2].Controls[0].Text = ((MonsterCard)card).TreasureReward.ToString();
                                    additionalParamsGroupBox.Controls[3].Controls[0].Text = ((MonsterCard)card).LevelReward.ToString();
                                    additionalParamsGroupBox.Controls[4].Controls[0].Text = ((MonsterCard)card).BadStuff.ToString();
                                    cardSubTypeGroupBox.Show();
                                    break;
                                case "RaceCard":
                                    doorTypeRadioButton.Checked = true;
                                    (cardSubTypeGroupBox.Controls[4] as RadioButton).Checked = true;
                                    cardSubTypeGroupBox.Show();
                                    break;
                                case "GoUpALevelCard":
                                    (cardSubTypeGroupBox.Controls[0] as RadioButton).Checked = true;
                                    cardSubTypeGroupBox.Show();
                                    break;
                                case "ItemCard":
                                    treasureTypeRadioButton.Checked = true;
                                    (cardSubTypeGroupBox.Controls[1] as RadioButton).Checked = true;
                                    additionalParamsGroupBox.Controls[0].Controls[0].Text = ((ItemCard)card).Modifier.ToString();
                                    additionalParamsGroupBox.Controls[1].Controls[0].Text = ((ItemCard)card).Sign.ToString();
                                    additionalParamsGroupBox.Controls[2].Controls[0].Text = ((ItemCard)card).Restriction.ToString();
                                    additionalParamsGroupBox.Controls[3].Controls[0].Text = ((ItemCard)card).PartOfBody.ToString();
                                    additionalParamsGroupBox.Controls[4].Controls[0].Text = ((ItemCard)card).Cost.ToString();
                                    (additionalParamsGroupBox.Controls[5] as CheckBox).Checked = ((ItemCard)card).IsBigItem;
                                    cardSubTypeGroupBox.Show();
                                    break;
                                case "OneShotTreasureCard":
                                    treasureTypeRadioButton.Checked = true;
                                    (cardSubTypeGroupBox.Controls[2] as RadioButton).Checked = true;
                                    (additionalParamsGroupBox.Controls[0].Controls[0] as TextBox).Text = ((OneShotTreasureCard)card).Cost.ToString();
                                    cardSubTypeGroupBox.Show();
                                    additionalParamsGroupBox.Show();
                                    break;
                                case "Other":
                                    otherTypeRadioButton.Checked = true;
                                    (cardSubTypeGroupBox.Controls[0] as RadioButton).Checked = true;
                                    cardSubTypeGroupBox.Show();
                                    break;

                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error: Could not set some fields from file");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }

            }
        }
    }
}
