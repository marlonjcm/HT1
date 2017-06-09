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

        private void button2_Click(object sender, EventArgs e)
        {
            String texto = entrada1.Text;

            char[] caracteres = texto.ToCharArray();

            
            int contador = 0;

            for(int i = 0; i<caracteres.Length; i++)
            {
                char actual = caracteres[i];
                if(actual=='a'||actual=='á'||actual=='A'||actual=='Á'|| actual == 'e' || actual == 'é' || actual == 'E' || actual == 'É'|| actual == 'i' || actual == 'í' || actual == 'I' || actual == 'Í'|| actual == 'o' || actual == 'ó' || actual == 'O' || actual == 'Ó'|| actual == 'u' || actual == 'ú' || actual == 'U' || actual == 'Ú')
                {
                    contador++;
                }
            }

            if (contador >= 5)
                resultado.Text = "CUMPLE";
            else
                resultado.Text = "NO CUMPLE";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String nombre = entrada1.Text;
            String apellido = entrada2.Text;

            char[] ncaracteres = nombre.ToCharArray();
            char[] napellido = apellido.ToCharArray();

            int no_n = ncaracteres.Length - 1;
            int no_a = napellido.Length - 1;

            string nombre_i ="", apellido_i="";

            for(int j=no_n; j >= 0; j--)
            {
                nombre_i += ncaracteres[j];
            }

            for (int h = no_a; h >= 0; h--)
            {
                apellido_i += napellido[h];
            }

            resultado.Text = nombre_i + " " + apellido_i;

        }
    }
}
