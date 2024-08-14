using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Msg;
using System.Diagnostics.Eventing.Reader;

namespace CalculadoraIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtestatura.Text) && string.IsNullOrEmpty(txtpeso.Text))
            {
                MessageBox.Show("Faltan ambos datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiaCampos();
            }
            else if(string.IsNullOrEmpty(txtpeso.Text))
            {
                MessageBox.Show("Peso esta vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtpeso.Select();
                txtestatura.Enabled = false;
            }
            else if (string.IsNullOrEmpty(txtestatura.Text))
            {
                MessageBox.Show("Estatura esta vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtestatura.Select();
                txtpeso.Enabled = false;
            }
            else {
                //Leemos la propiedad del campo de texto estatura
                string estatura = txtestatura.Text;

                //Convertimos a numero
                float est = Convert.ToSingle(estatura);

                //Leemos la propiedad del campo de texto peso
                string pesito = txtpeso.Text;

                //Convertimos a numero
                float pesos = Convert.ToSingle(pesito);

                //variable que recupera el IMC
                float IMC = 0;

                IMC = (float)(pesos / Math.Pow(est, 2));

                //MessageBox.Show("Tu IMC es = " + IMC + "\n" + categoriaIMC(IMC), "IMC");
                //MsgBox m = new MsgBox("warning","Tu IMC es = " + IMC + "\n" + categoriaIMC(IMC));
                if (categoriaIMC(IMC) == "Tienes bajo peso")
                {
                    MsgBox m = new MsgBox("warning", "Tu IMC es = " + IMC + "\n" + categoriaIMC(IMC));
                    m.ShowDialog();
                }
                else if (categoriaIMC(IMC) == "Tienes Peso saludable")
                {
                    MsgBox m = new MsgBox("question", "Tu IMC es = " + IMC + "\n" + categoriaIMC(IMC));
                    m.ShowDialog();
                }
                else if (categoriaIMC(IMC) == "Tienes SobrePeso")
                {
                    MsgBox m = new MsgBox("warning", "Tu IMC es = " + IMC + "\n" + categoriaIMC(IMC));
                    m.ShowDialog();
                }
                else
                {
                    MsgBox m = new MsgBox("error", "Tu IMC es = " + IMC + "\n" + categoriaIMC(IMC));
                    m.ShowDialog();
                }
                txtestatura.Enabled = true;
                txtpeso.Enabled = true;
                LimpiaCampos();
            }
          }

        private string categoriaIMC(float IMC)
        {
            String ca = "0";
            if (IMC < 18.5)
            {
                ca = "Tienes bajo peso";
                //logo = "warning";
            }
            else if (IMC >= 18.5 && IMC <= 24.9) 
            { 
                ca = "Tienes Peso saludable";
                //logo = "question";
            }
            else if (IMC >= 25.0 && IMC <= 29.9) 
            { 
                ca = "Tienes SobrePeso";
                //logo = "warning";
            }
            else if (IMC > 30) 
            { 
                ca = "Tienes Obesidad";
                //logo = "error";
            }
            return ca;
        }

        private void LimpiaCampos()
        {
            txtestatura.Text = "";
            txtpeso.Text = "";
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnreiniciar_Click(object sender, EventArgs e)
        {
            LimpiaCampos();
            txtestatura.Enabled = true;
            txtpeso.Enabled = true;
        }
    }
}