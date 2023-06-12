using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFprj
{
    public partial class WFERaa : Form
    {
        public WFERaa()
        {
            InitializeComponent();
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            tbxRNo.Text = null;
            tbxSName.Text = null;
            tbxM1.Text = null;
            tbxM2.Text = null;
            tbxTotal.Text = null;
            tbxAvg.Text = null;

            rdobtnPass.Checked = false;
            rdobtnFail.Checked = false;


        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            int rno = 0;

            int.TryParse(tbxRNo.Text, out rno);
            string sname = null;

            double m1 = 0;
            double m2 = 0;
            double total = 0;
            double avg = 0;
            bool result = false;

            double.TryParse(tbxM1.Text, out m1);
            double.TryParse(tbxM2.Text, out m2);

            total = m1 + m2;

            avg = (m1 + m2 / 2);

            result = m1 > 34.4 && m2 > 34.4;

            tbxTotal.Text = total + "";
            tbxAvg.Text = avg + "";

            if(result)
            {
                rdobtnPass.Checked = true;

            }
            else
            {
                rdobtnFail.Checked = true;
            }


        }
    }
}
