using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula09_Metodos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
     

        private void btnSomar_Click(object sender, EventArgs e)
        {
            Somar();
        }

        private void BtnMulti_Click(object sender, EventArgs e)
        {  //Chamando o metodo multiplicar[
            int f1, f2;
            f1 = 0; f2 = 0;
            Multiplicar(f1,f2);
        }
        

        private void btnPitagoras_Click(object sender, EventArgs e)
        {
            int n1, n2;
            n1 = 0;
            n2 = 0;
            Pitagora(n1,n2);
        }

        private void btnBhaskara_Click(object sender, EventArgs e)
        {

        }


        private void BtnForçã_Click(object sender, EventArgs e)
        {
            double Massa = double.Parse(textBox2.Text);
            double Altura = double.Parse(textBox1.Text);
            Forca c = new Forca();
            c.Forcar(Massa,Altura);
            MessageBox.Show(Massa + " * " + Altura + " = " + c.f+"N");
        }

        #region Metodos

        private void Bhaskara()
        {

        }

        private void Somar()
        {
            //Codigo do Método aqui
            int n1, n2, s;
            n1 = int.Parse(textBox2.Text);
            n2 = int.Parse(textBox1.Text);
            s = n1 + n2;
            MessageBox.Show(n1 + " + " + n2 + " = " + s);
        }

        private void Multiplicar(int f1, int f2)
        {
            f1 = int.Parse(textBox2.Text);
            f2 = int.Parse(textBox1.Text);
            int r = f1 * f2;
            MessageBox.Show(f1 + " * " + f2 + " = " + r);
        }

        private void Pitagora (double n1,double n2)
        {
            n1 = double.Parse(textBox2.Text);
            n2 = double.Parse(textBox1.Text);
            double r = Math.Sqrt((Math.Pow(n1,2) + Math.Pow(n2,2)));
             MessageBox.Show("h² = "+"a² "+"b² \n"+"h = "+r.ToString());
        }
        #endregion


        
    }
}
