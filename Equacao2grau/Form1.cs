using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Equacao2grau
{
    public partial class frmbaskara : Form
    {
        public frmbaskara()
        {
            InitializeComponent();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txta_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txtc_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double a, b,c,delta, X1,X2;

            a = Convert.ToDouble(txta.Text);
            b = Convert.ToDouble(txtb.Text);
            c = Convert.ToDouble(txtc.Text);

            delta = (b * b) - (4 * a * c);

            this.txtdelta.Text = Convert.ToString(delta);

            if (delta < 0)
            {
                txtx1.Text = "Impossivel, delta menor que 0";
                txtx2.Text = "Impossivel, delta menor que 0";


            }

            else 
            {

                X1 = (-b + Math.Sqrt(delta)) / (2 * a);

                X2 = (-b - Math.Sqrt(delta)) / (2 * a);

                this.txtx1.Text = Convert.ToString(X1);
                this.txtx2.Text = Convert.ToString(X2);
            }


            




        }

      
    }
}
