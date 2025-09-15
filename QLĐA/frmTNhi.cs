using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLĐA
{
    public partial class frmTNhi : Form
    {
        double  a, b, c, d, x1,x2;
        public frmTNhi()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmTNhi_Load(object sender, EventArgs e)
        {

        }

        private void btnend_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            a=Convert.ToDouble(txta.Text);
            b=Convert.ToDouble(txtb.Text);
            c=Convert.ToDouble(txtc.Text);
            d = b * b - 4 * a * c;
            if (d < 0)
                lblkq.Text = "phương trình vô nghiệm";
            //  MessageBox.Show("Phương trình vô nghiệm");
            else if (d == 0)
            {
                x1 = -b / (2 * a);
                lblkq.Text = "Phương trình có nghiệm kép: x1=x2=" + Math.Round(x1, 1);
                // MessageBox.Show("Phương trình có nghiệm kép: x1=x2=" + x1);
            }
            else
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                lblkq.Text = "Phương trình có 2 nghiệm phân biệt: x1=" + Math.Round(x1, 1) + ", x2=" + Math.Round(x2, 1);
                // MessageBox.Show("Phương trình có 2 nghiệm phân biệt: x1=" + x1 + ", x2=" + x2);
            }

        }
    }
}
