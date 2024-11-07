using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_hxlProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int counter = 0;
        private void btnSayHello_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello");
            counter++;
            lblInfo.Text = string.Format("I has clicked {0} times ", counter);
        }

        private void textUserInput_TextChanged(object sender, EventArgs e)
        {
            var btn = (TextBox)sender;
            string text = btn.Name;
            lblInfo3.Text = string.Format("{0},show message{1} ", text, textUserInput.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (pgb.Value + 10 > pgb.Maximum)
            {
                pgb.Value = pgb.Maximum;
            }
            else
            {
                pgb.Value += 10;
            }


        }

        private void btndecrese_Click(object sender, EventArgs e)
        {
            if (pgb.Value - 10 < pgb.Minimum)
            {
                pgb.Value = pgb.Minimum;
            }
            else
            {
                pgb.Value -= 10;
            }
        }


        private void btnTimer_Click(object sender, EventArgs e)
        {
            timer1.Enabled=!timer1.Enabled;
            if (btnTimer.Enabled)
            {
                btnTimer.Image = Properties.Resources.pic1;
            }
            else
            {
                btnTimer.Image= Properties.Resources.pic2;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pgb.Value + 5 > pgb.Maximum)
            {
                pgb.Value = pgb.Minimum;
            }
            else
            {
                pgb.Value += 5;
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
