using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double raio, altura, volume;/*globais*/
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

       
        private void TxtBoxAlt_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtBoxAlt.Text, out altura))
            {
                MessageBox.Show("Altura inválida!");
            }
            else
            {
                if (altura <= 0)
                {
                    MessageBox.Show("Altura não pode ser <= 0");
                }
            }
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            if((!double.TryParse(txtBoxRad.Text, out raio)) ||
               (!double.TryParse(txtBoxAlt.Text, out altura)))
            {
                MessageBox.Show("Valores inválidos");
            }
            else
            {
                if((altura<=0 || raio <= 0))
                {
                    MessageBox.Show("Valores não podem ser <= 0");
                }
                else
                {
                    volume = Math.PI * Math.Pow(raio, 2) * altura;
                    txtBoxVol.Text = volume.ToString("N2");
                }
            }
        }

       

        private void TxtBoxRad_Validated(object sender, EventArgs e)
        {
            if(!double.TryParse(txtBoxRad.Text, out raio))
            {
                MessageBox.Show("Raio inválido!");
            }
            else
            {
                if (raio <= 0)
                {
                    MessageBox.Show("Raio não pode ser <=0");
                }
            }
        }
    }
}
