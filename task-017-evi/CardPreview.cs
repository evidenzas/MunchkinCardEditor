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

namespace task_017_evi
{
    public partial class CardPreview : Form
    {
        public CardPreview()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            
            //nameLabel.Parent = pictureBox1;
            //cardDescLabel.Parent = pictureBox1;
            nameLabel.Parent = tableLayoutPanel1;
            cardDescLabel.Parent = tableLayoutPanel1;

            nameLabel.BackColor = Color.Transparent;
            cardDescLabel.BackColor = Color.Transparent;

            nameLabel.TextAlign = ContentAlignment.MiddleCenter;

            //cardDescLabel.MaximumSize = new Size(100, 0);
            cardDescLabel.AutoSize = true;
            cardDescLabel.TextAlign = ContentAlignment.MiddleCenter;

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
            nameLabel.ForeColor = cd.Color;
            cardDescLabel.ForeColor = cd.Color;

        }

        private void backColorButton_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            cd.ShowDialog();
            this.BackColor = cd.Color;
            tableLayoutPanel1.BackColor = cd.Color;
            panel1.BackColor = cd.Color;
            pictureBox1.BackColor = cd.Color;
        }
    }


}
