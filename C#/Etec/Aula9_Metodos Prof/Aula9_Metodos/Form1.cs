using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula9_Metodos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Meus Métodos
        private void somar()
        {//O código do seu método aqui
            int n1, n2, s;
            n1 = int.Parse(txtValor1.Text);
            n2 = int.Parse(txtValor2.Text);
            s = n2 + n1;
            MessageBox.Show(n1 + " + " + n2 + " = " + s);
        }

        private void multiplicar(int fator1, int fator2)
        {
            int produto;
            fator1 = int.Parse(txtValor1.Text);
            fator2 = int.Parse(txtValor2.Text);
            produto = fator2 * fator1;
            MessageBox.Show(fator1 + " * " + fator2 + " = " + produto);
        }

        double c1, c2;
        //Teorema de Pitágoras
        private void pitagorar(double a, double b)
        {
            a = c1;
            b = c2;
            double h;
            h =Math.Sqrt (Math.Pow(a, 2) + Math.Pow(b,2));
            MessageBox.Show("h² ="+"a² + b² \n"+"h ="+h.ToString());
        }
        #endregion

        private void btnSomar_Click(object sender, EventArgs e)
        {
            //Chamando o método Somar
            somar();
        }
        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            //Chamando o método Multiplicar
            int f1 = int.Parse(txtValor1.Text), f2 = int.Parse(txtValor2.Text);
            multiplicar(f1,f2);
        }

        private void btnPitago_Click(object sender, EventArgs e)
        {
            //Botão Pitágoras
           
            c1 = double.Parse(txtValor1.Text);
            c2 = double.Parse(txtValor2.Text);
            pitagorar(c1,c2);
        }

        private void btnForca_Click(object sender, EventArgs e)
        {

            c1 = double.Parse(txtValor1.Text);
            c2 = double.Parse(txtValor2.Text);

            Forca calc = new Forca();
            calc.forcar(c1,c2);

            MessageBox.Show("F=m*a\n"+c1+" x "+c2+" =\n F="+ calc.f+" N");
           


        }


    }
}
