using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reprobadooaprobado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_CalcularPromedio_Click(object sender, EventArgs e)
        {
            double P1 = Convert.ToDouble(label1.Text);
            double P2 = Convert.ToDouble(label2.Text);
            double P3 = Convert.ToDouble(label3.Text);
            double P4 = Convert.ToDouble(label4.Text);

            double Promedio = (P1 + P2 + P3 + P4) / 4;

            lbl_Promedio.Text = Promedio.ToString();

            
            if (Promedio >= 70)
            {
                lbl_Situacion.Text = "Aprobado";
                lbl_Situacion.ForeColor = Color.Green;

                txt_notacompletiva.Enabled = false;
                btn_CalcularCompletivo.Enabled = false;
            }
            else
            {
                lbl_Situacion.Text = "Reprobado";
                lbl_Situacion.ForeColor = Color.Red;

                txt_notacompletiva.Enabled = true;
                btn_CalcularCompletivo.Enabled = true;

            }




            }

            private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_P1.Clear();
            txt_P2.Clear();
            txt_P3.Clear();
            txt_P4.Clear();
            txt_Promedio.Clear();
            txt_Situacion.Clear();
            txt_notacompletiva.Clear();
            txt_pruebacompletiva.Clear();
            txt_situacione.Clear();
            txt_promediocompletivo.Clear();
            txt_Situacion.Clear();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_CalcularPromedio_Click_1(object sender, EventArgs e)
        {
            double P1 = Convert.ToDouble(txt_P1.Text);
            double P2 = Convert.ToDouble(txt_P2.Text);
            double P3 = Convert.ToDouble(txt_P3.Text);
            double P4 = Convert.ToDouble(txt_P4.Text);

            double Promedio = (P1 + P2 + P3 + P4) / 4;

            txt_Promedio.Text = Promedio.ToString();

            if (Promedio >= 70)
            {
                txt_Situacion.Text = "Aprobado";
                txt_Situacion.ForeColor = Color.Green;
                txt_pruebacompletiva.Enabled = false;
                txt_situacione.Enabled = false;
                txt_notacompletiva.Enabled = false;
                txt_promediocompletivo.Enabled = false;
                btn_CalcularCompletivo.Enabled = false;
            }
            else
            {
                txt_Situacion.Text = "Reprobado";
                txt_Situacion.ForeColor = Color.Red;
                txt_pruebacompletiva.Enabled = true;
                txt_situacione.Enabled = true;
                txt_notacompletiva.Enabled = true;
                txt_promediocompletivo .Enabled = true;
                btn_CalcularCompletivo.Enabled = true;


            }
        }

        private void btn_CalcularCompletivo_Click(object sender, EventArgs e)
        {
            double NotaCompletiva = Convert.ToDouble(txt_notacompletiva.Text);
            double PruebaCompletiva = 100;

            double PorcientoPruebaCompletiva = 0.5;
            double PorcientoNotaCompletiva = 0.5;

            double PromedioFinal = (NotaCompletiva * PorcientoNotaCompletiva) + (PruebaCompletiva * PorcientoPruebaCompletiva);

            txt_pruebacompletiva.Text = PruebaCompletiva.ToString();
            txt_promediocompletivo.Text = PromedioFinal.ToString();

            if (PromedioFinal >=70)
            {
                txt_situacione.Text = "Aprobado";
                txt_situacione.ForeColor = Color.Green;
            }
            else
            {
                txt_situacione.Text = "Reprobado";
                txt_situacione.ForeColor = Color.Red;
            }
            
        }
    }
}
