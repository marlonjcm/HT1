using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HojaTrabajo1
{
    public partial class HT1 : Form
    {
        public HT1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void op1_Click(object sender, EventArgs e)
        {
            double a, b, h, result;
            a = float.Parse(entrada1.Text);
            b = float.Parse(entrada2.Text);
            h = float.Parse(entrada3.Text);

            result = Math.Sqrt((Math.Pow(a, 2)) + (Math.Pow(b, 2)));
            resultado.Text = result.ToString();
        }
    }
}
