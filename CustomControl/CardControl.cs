using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControl
{
    public partial class CardControl : Panel
    {
        PictureBox picture;
        public CardControl()
        {
            InitializeComponent();
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            Location = new System.Drawing.Point(10, 10);
            Name = "pane1";
            Size = new System.Drawing.Size(200, 300);
            TabIndex = 1;
            new PictureBox();
            this.Controls.Add(picture);
        }
        [Category("Custom")]
        [Browsable(true)]
        [Editor(typeof(System.Windows.Forms.Design.WindowsFormsComponentEditor), typeof(System.Drawing.Design.UITypeEditor))]
        protected override void OnPaint(PaintEventArgs pe)
        {
            Random rnd = new Random();
            int type = rnd.Next(1, 5);
            int num = rnd.Next(1, 14);
            base.OnPaint(pe);
            pe.Graphics.FillRectangle(Brushes.White, new Rectangle(0, 0, 600, 600));
            pe.Graphics.DrawRectangle(Pens.White, new Rectangle(0, 0, 40, 40));
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            if (type == 1)
            {
                drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
                pe.Graphics.DrawImage(Image.FromFile("C:\\Users\\Thai Vinh\\Downloads\\clubs.png"), new Rectangle((this.Width-50)/2, (this.Height-50)/2, 50, 50));
            }
            if (type == 2)
            {
                drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
                pe.Graphics.DrawImage(Image.FromFile("C:\\Users\\Thai Vinh\\Downloads\\hearts.png"), new Rectangle((this.Width - 50) / 2, (this.Height - 50) / 2, 50, 50));
            }
            if (type == 3)
            {
                drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
                pe.Graphics.DrawImage(Image.FromFile("C:\\Users\\Thai Vinh\\Downloads\\spades.png"), new Rectangle((this.Width - 50) / 2, (this.Height - 50) / 2, 50, 50));
            }
            if (type == 4)
            {
                drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
                pe.Graphics.DrawImage(Image.FromFile("C:\\Users\\Thai Vinh\\Downloads\\diamonds.png"), new Rectangle((this.Width - 50) / 2, (this.Height - 50) / 2, 50, 50)); 
            }
            System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 16);
            float x = 0.0F;
            float y = 0.0F;
            string str = "";
            if (num > 1 && num < 11)
                str = num.ToString();
            if (num == 1)
                str = "A";
            if (num == 11)
                str = "J";
            if (num == 12)
                str = "Q";
            if (num == 13)
                str = "K";
            System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
            pe.Graphics.DrawString(str, drawFont, drawBrush, x, y, drawFormat);
            pe.Graphics.DrawString(str, drawFont, drawBrush,this.Width - str.Length*16 - 4, this.Height - 24, drawFormat);

        }
    }
}
