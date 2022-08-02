using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace triangles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double l1, l2, l3;
            l1= Convert.ToDouble(tblado1.Text);
            l2 = Convert.ToDouble(tblado2.Text);
            l3 = Convert.ToDouble(tblado3.Text);
            
            if (l1 == l2 && l1==l3)
            {
                lblresult.Text = "Es un triangulo equilatero";
            }
            if (l1 == l2 && l1 != l3 )
            {
                lblresult.Text = "Es un triangulo isoceles";
            }

            if (l1 == l3 && l2 != l3)
            {
                lblresult.Text = "Es un triangulo isoceles";
            }

            if (l2 == l3 && l1 != l3)
            {
                lblresult.Text = "Es un triangulo isoceles";
            }

            if (l1 != l2 && l1 != l3 && l2 != l3)
            {
                lblresult.Text = "Es un triangulo escaleno";
            }
        }
    }
}
