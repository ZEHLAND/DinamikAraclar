using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dinamik_araçlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            Point konum = new Point(10,20);
            btn.Location=konum;
            btn.Name = "Button2";
            btn.Text = "tıkla";
            btn.BackColor = Color.Red;
            btn.Height = 50;
            btn.Width = 75;
            Label lbl = new Label();
            Point lblkonum = new Point(250,25);
            lbl.Location = lblkonum;
            lbl.Name = "label1";
            lbl.Text = "merhaba";
            lbl.BackColor = Color.Green;
            lbl.AutoSize = true;
          

            for(int i = 1; i <= 5; i++)
            {
                TextBox txt = new TextBox();
                Point txtKonum = new Point(350, i * 30);
                txt.Location = txtKonum;
                txt.Name = "Texbox" + i;
                txt.Text = i.ToString();
                this.Controls.Add(txt);
            }
            this.Controls.Add(btn);
            this.Controls.Add(lbl);


        }
    }
}
