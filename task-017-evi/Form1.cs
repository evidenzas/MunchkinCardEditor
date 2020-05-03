using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void doorTypeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            cardSubTypeGroupBox.Controls.Clear();

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

            cardSubTypeGroupBox.Show();
        }

        private void TreasureTypeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            cardSubTypeGroupBox.Controls.Clear();

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
            goUpALevelCardRadioButton.Location = new Point(6, 15);
            itemCardRadioButton.Location = new Point(6, 35);
            oneShotTreasureCardRadioButton.Location = new Point(6, 55);

            cardSubTypeGroupBox.Show();
        }

        private void otherTypeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            cardSubTypeGroupBox.Controls.Clear();

            RadioButton otherCardRadioButton = new RadioButton();

            otherCardRadioButton.Text = "Other card";

            cardSubTypeGroupBox.Controls.Add(otherCardRadioButton);

            cardSubTypeGroupBox.Size = new Size(130, 45);
            otherCardRadioButton.Location = new Point(6, 15);

            cardSubTypeGroupBox.Show();
        }
    }
}
