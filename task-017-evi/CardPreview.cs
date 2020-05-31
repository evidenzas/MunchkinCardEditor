using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
            modifierLabel.Parent = tableLayoutPanel1;

            nameLabel.BackColor = Color.Transparent;
            cardDescLabel.BackColor = Color.Transparent;
            modifierLabel.BackColor = Color.Transparent;
            leftBottomLabel.BackColor = Color.Transparent;
            rightBottomLabel.BackColor = Color.Transparent;

            nameLabel.TextAlign = ContentAlignment.MiddleCenter;
            cardDescLabel.TextAlign = ContentAlignment.MiddleCenter;
            //cardDescLabel.MaximumSize = new Size(100, 0);
            nameLabel.AutoSize = true;
            cardDescLabel.AutoSize = true;
            modifierLabel.AutoSize = true;
            leftBottomLabel.AutoSize = true;
            rightBottomLabel.AutoSize = true;

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
            modifierLabel.ForeColor = fontColor;
            rightBottomLabel.ForeColor = fontColor;
            leftBottomLabel.ForeColor = fontColor;
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
            var cntrl = tableLayoutPanel1; //there shouldd be a control
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
            pictureBox1.Image = card.PicturePath;
            nameLabel.Text = card.Name;
            cardDescLabel.Text = card.Description;
            switch (card)
            {
                case ClassCard _:
                    break;
                case CurseCard _:
                    nameLabel.Text = "Curse! \n" + card.Name;
                    break;
                case ModifierCard _:
                    modifierLabel.Text = ((ModifierCard)card).Sign + " " + ((ModifierCard)card).Modifier + " to the monster level";
                    if (((ModifierCard)card).Modifier != 0) modifierLabel.Visible = true;
                    break;
                case MonsterCard _:
                    break;
                case RaceCard _:
                    break;
                case GoUpALevelCard _:
                    break;
                case ItemCard _:
                    modifierLabel.Text = "Bonus " + ((ItemCard)card).Sign + " " + ((ItemCard)card).Modifier;
                    if (((ItemCard)card).Modifier != 0) modifierLabel.Visible = true;
                    rightBottomLabel.Text = ((ItemCard)card).Cost;
                    leftBottomLabel.Text = ((ItemCard)card).PartOfBody;
                    if (((ItemCard)card).IsBigItem) leftBottomLabel.Text += " \n Big";
                    rightBottomLabel.Visible = true;
                    leftBottomLabel.Visible = true;
                    break;
                case OneShotTreasureCard _:
                    rightBottomLabel.Text = ((OneShotTreasureCard)card).Cost;
                    rightBottomLabel.Visible = true;
                    break;
                case OtherCard _:
                    break;
                default:
                    break;
            }

        }
    }

}
