using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMCForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Declarar Variável:
            double peso, altura, imc;

            try
            {
                //Declarar valor da variável:
                altura = double.Parse(txbAltura.Text);
                peso = double.Parse(txbPeso.Text);

                //Efetuar a operação:
                txbImc.Text = ((peso / (altura * altura)).ToString());
                imc = double.Parse(txbImc.Text);

                if (imc <= 18.5)
                {
                    lblStatus.Text = "Abaixo do peso";

                }
                else if (imc >= 18.5 && imc <= 24.9)
                {
                    lblStatus.Text = "Peso Ideal (Parabéns!!)";

                }
                else if (imc >= 25.0 && imc <= 29.9)
                {
                    lblStatus.Text = "Levemente acima do peso";

                }
                else if (imc >= 30.0 && imc <= 34.9)
                {
                    lblStatus.Text = "Obesidade grau I";

                }
                else if (imc >= 35.0 && imc <= 39.9)
                {
                    lblStatus.Text = "Obesidade grau II(Severa)";

                }
                else if (imc >= 40.0)
                {
                    lblStatus.Text = "Obesidade grau III(Mórbida)";

                }
            }
            catch
            {
                MessageBox.Show("Dados Invalidos Informados!!!");
                //Limpar txb's
                txbAltura.Clear();
                txbPeso.Clear();
                txbImc.Clear();
            }

        }
    }
}
