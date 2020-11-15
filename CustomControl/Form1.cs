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
    public partial class Form1 : Form
    {
        CardControl card = new CardControl();
        int CX = 0;
        int StartW = 850;
        int StartH = 800;
        public Form1()
        {   
            InitializeComponent();
            card.Location = new Point(180, 50);
            this.CenterToScreen();
            Controls.Add(card);
        }

        private void btnAddCard_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(card);
            card = new CardControl();
            Controls.Add(card);
            card.Location = new Point(180, 50);

        }

        private void Form1_Resize(object sender, EventArgs e)
        {

        }
    }
}
