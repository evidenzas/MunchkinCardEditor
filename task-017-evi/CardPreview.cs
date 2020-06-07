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
using task_017_evi.Model.Doors;
using task_017_evi.Model.Others;
using task_017_evi.Model.Treasures;

namespace task_017_evi
{
    public partial class CardPreview : Form
    {
        public Card viewedCard;
        public CardPreview(Card card)
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            
            //nameLabel.Parent = pictureBox1;
            //cardDescLabel.Parent = pictureBox1;
            nameLabel.Parent = tableLayoutPanel1;
            cardDescLabel.Parent = tableLayoutPanel1;
            monsterLvlOrRestrLabel.Parent = tableLayoutPanel1;

            nameLabel.BackColor = Color.Transparent;
            cardDescLabel.BackColor = Color.Transparent;
            monsterLvlOrRestrLabel.BackColor = Color.Transparent;
            leftBottomLabel.BackColor = Color.Transparent;
            rightBottomLabel.BackColor = Color.Transparent;
            itemBonusLabel.BackColor = Color.Transparent;
            monsterLvlOrRestrLabel.BackColor = Color.Transparent;
            modifierToTheMonsterLvlLabel.BackColor = Color.Transparent;
            oneShotTrOrLvlUpLabel.BackColor = Color.Transparent;
            bigItemLabel.BackColor = Color.Transparent;

            nameLabel.TextAlign = ContentAlignment.MiddleCenter;
            cardDescLabel.TextAlign = ContentAlignment.MiddleCenter;
            //cardDescLabel.MaximumSize = new Size(100, 0);
            nameLabel.AutoSize = true;
            cardDescLabel.AutoSize = true;
            monsterLvlOrRestrLabel.AutoSize = true;
            leftBottomLabel.AutoSize = false;
            rightBottomLabel.AutoSize = false;
            itemBonusLabel.AutoSize = true;
            monsterLvlOrRestrLabel.AutoSize = true;
            modifierToTheMonsterLvlLabel.AutoSize = true;
            oneShotTrOrLvlUpLabel.AutoSize = true;
            bigItemLabel.AutoSize = true;

            viewedCard = card;
            Color fontCardColor = card.FontCardColor == null ? Color.Black : card.FontCardColor;
            Color backCardColor = card.BackCardColor == null ? SystemColors.Control : card.BackCardColor;
            fontColorFormInit(fontCardColor);
            backColorFormInit(backCardColor);

            SetUpPreview(card);
        }

        public void fontColorFormInit(Color fontColor)
        {
            nameLabel.ForeColor = fontColor;
            cardDescLabel.ForeColor = fontColor;
            monsterLvlOrRestrLabel.ForeColor = fontColor;
            rightBottomLabel.ForeColor = fontColor;
            leftBottomLabel.ForeColor = fontColor;
            itemBonusLabel.ForeColor = fontColor;
            monsterLvlOrRestrLabel.ForeColor = fontColor;
            modifierToTheMonsterLvlLabel.ForeColor = fontColor;
            oneShotTrOrLvlUpLabel.ForeColor = fontColor;
            bigItemLabel.ForeColor = fontColor;
        }

        public void backColorFormInit(Color backColor)
        {
            this.BackColor = backColor;
            tableLayoutPanel1.BackColor = backColor;
            panel1.BackColor = backColor;
            pictureBox1.BackColor = backColor;
        }

        public void winCapture()
        {
            var cntrl = tableLayoutPanel1; //there should be a control
            var saveFile = new SaveFileDialog();
            saveFile.Filter = "Images|*.png;*.bmp;*.jpg";
            ImageFormat format = ImageFormat.Png;
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(saveFile.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".png":
                        format = ImageFormat.Png;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }

                using (var bmp = new Bitmap(cntrl.Width, cntrl.Height))
                {
                    cntrl.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                    bmp.Save(saveFile.FileName, format);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            winCapture();
        }

        private void fontColorButton_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            cd.ShowDialog();
            fontColorFormInit(cd.Color);
            viewedCard.FontCardColor = cd.Color;
            //TODO: save of selected colour (add to init)
        }

        private void backColorButton_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            cd.ShowDialog();
            backColorFormInit(cd.Color);
            viewedCard.BackCardColor = cd.Color;
        }

        public void SetUpPreview(Card card)
        {
            //typeof(card)

            pictureBox1.Image = Image.FromFile(card.PicturePath);
            nameLabel.Text = card.Name;
            cardDescLabel.Text = card.Description;
            switch (card)
            {
                case ClassCard _:
                    rightBottomLabel.Text = "Class";
                    rightBottomLabel.Visible = true;
                    break;
                case CurseCard _:
                    nameLabel.Text = "Curse! \n" + card.Name;
                    break;
                case ModifierCard _:
                    monsterLvlOrRestrLabel.Text = ((ModifierCard)card).Sign + " " + ((ModifierCard)card).Modifier + " to the monster level";
                    if (((ModifierCard)card).Modifier != 0) monsterLvlOrRestrLabel.Visible = true;
                    break;
                case MonsterCard _:
                    if (((MonsterCard)card).Level != 0)
                    {
                        monsterLvlOrRestrLabel.Text = "Level " + ((MonsterCard)card).Level.ToString();
                        monsterLvlOrRestrLabel.Visible = true;
                    }
                    if (!string.IsNullOrEmpty(((MonsterCard)card).BadStuff))
                    {
                        cardDescLabel.Text += "\nBad stuff: " + ((MonsterCard)card).BadStuff;
                    }
                    leftBottomLabel.Text = ((MonsterCard)card).LevelReward.ToString() + (((MonsterCard)card).LevelReward > 1 ? " levels" : " level");
                    rightBottomLabel.Text = ((MonsterCard)card).TreasureReward.ToString() + (((MonsterCard)card).TreasureReward > 1 ? " levels" : " level");
                    if (((MonsterCard)card).LevelReward > 0) leftBottomLabel.Visible = true;
                    if (((MonsterCard)card).TreasureReward > 0) rightBottomLabel.Visible = true;
                    break;
                case RaceCard _:
                    rightBottomLabel.Text = "Race";
                    rightBottomLabel.Visible = true;
                    break;
                case GoUpALevelCard _:
                    oneShotTrOrLvlUpLabel.Text = "Go up a level";
                    oneShotTrOrLvlUpLabel.Visible = true;
                    break;
                case ItemCard _:
                    itemBonusLabel.Text = "Bonus " + ((ItemCard)card).Sign + " " + ((ItemCard)card).Modifier;
                    if (((ItemCard)card).Modifier != 0) itemBonusLabel.Visible = true;
                    rightBottomLabel.Text = ((ItemCard)card).Cost;
                    leftBottomLabel.Text = ((ItemCard)card).PartOfBody;
                    if (((ItemCard)card).IsBigItem == true) bigItemLabel.Visible = true;
                    if (!string.IsNullOrEmpty(((ItemCard)card).Restriction))
                    {
                        monsterLvlOrRestrLabel.Text = ((ItemCard)card).Restriction;
                        monsterLvlOrRestrLabel.Visible = true;
                    }
                    rightBottomLabel.Visible = true;
                    leftBottomLabel.Visible = true;
                    break;
                case OneShotTreasureCard _:
                    rightBottomLabel.Text = ((OneShotTreasureCard)card).Cost;
                    rightBottomLabel.Visible = true;
                    oneShotTrOrLvlUpLabel.Text = "One shot treasure";
                    oneShotTrOrLvlUpLabel.Visible = true;
                    break;
                case OtherCard _:
                    break;
                default:
                    break;
            }

        }

        private void saveDraftButton_Click(object sender, EventArgs e)
        {
            var saveFile = new SaveFileDialog();
            saveFile.Filter = "Json|*.json;";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(saveFile.FileName, JsonWorker.CardSerialize(viewedCard));
                }
                catch (Exception)
                {

                }
                MessageBox.Show("Draft saved");
            }
        }
    }

}
