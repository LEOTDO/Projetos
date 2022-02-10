using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversaodeTemperatura
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btConverte_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(txtValor.Text);

            if (rbCelsius1.Checked == true)
            {
                if (rbKelvin2.Checked == true)
                {
                    txtResultado.Text = (valor + 273) + "K";
                }

                else
                    if (rbFahrenheit2.Checked == true)
                {
                    txtResultado.Text = (valor * 1.8 + 32) + "°F";
                }

                else
                {
                    txtResultado.Text = valor + "°C";
                }
            }
            else
                if (rbKelvin1.Checked == true)
            {
                if (rbCelsius2.Checked == true)
                {
                    txtResultado.Text = (valor - 273) + "°C";
                }
                else
                    if (rbFahrenheit2.Checked == true)
                {
                    txtResultado.Text = (valor * 1.8 - 459.67) + "°F";
                        }
                else
                {
                    txtResultado.Text = valor + "K";
                }
            }
            else
                if (rbFahrenheit1.Checked == true) //verifica se a opção Fahrenheit do GroupBox Entrada esta selecionada
            {
                if (rbCelsius2.Checked == true)
                {
                    txtResultado.Text = ((valor - 32) / 1.8) + "°C";
                }

                else
                    if (rbKelvin2.Checked == true)
                {
                    txtResultado.Text = ((valor + 459.67) / 108) + "K";
                }

                else // se todas as opções retornarem falso
                {
                    txtResultado.Text = valor + "°F";
                }
            }
        }

        private void rbCelsius2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtValor.Text = "";
            txtResultado.Clear();

            foreach (Control Componente in gbEntrada.Controls)
            {
                (Componente as RadioButton).Checked = false;
            }

            foreach (Control Componente in gbSaida.Controls)
            {
                (Componente as RadioButton).Checked = false;
            }


        }
    }
}
