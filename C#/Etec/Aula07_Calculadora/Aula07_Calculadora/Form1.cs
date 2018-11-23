using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula07_Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1 = 0, num2 = 0,resultado = 0;
             if (txtprimeironumero.Text == "")
            {
                MessageBox.Show("Digite o Primeiro Numero");
                txtprimeironumero.Focus();
            }
            else if (txtsegundonumero.Text == "")
            {
                MessageBox.Show("Digite o Segundo Numero");
                txtsegundonumero.Focus();
            }
             else
             {
                 num1 = Convert.ToDouble(txtprimeironumero.Text);
                 num2 = Convert.ToDouble(txtsegundonumero.Text);
                 if (radAdicao.Checked == true)
                 {
                     pictureBox1.Image = Properties.Resources.adição;
                     resultado = num1 + num2;
                     MessageBox.Show(num1 + " + " + num2 + " = " + resultado);
                 }
                 if (radSubtracao.Checked == true)
                 {
                     pictureBox1.Image = Properties.Resources.a_subtracao_uma_das_quatro_operacoes_matematicas_basicas_possui_um_sinal_especifico_para_seus_calculos_5a2985586bbf2;
                     resultado = num1 - num2;
                     MessageBox.Show(num1 + " - " + num2 + " = " + resultado);
                 }
                 if (radMultiplicacao.Checked == true)
                 {

                     pictureBox1.Image = Properties.Resources.multiply_303378_960_720;
                     resultado = num1 * num2;
                     MessageBox.Show(num1 + " * " + num2 + " = " + resultado);
                 } if (radDivisao.Checked == true)
                 {
                     resultado = num1 / num2;
                     if (num1 == 0 || num2 == 0)
                     {
                         MessageBox.Show("Impossivel Dividir por Zero");
                     }
                     else {
                         pictureBox1.Image = Properties.Resources._94115c1baec37f13a5d5aaad5f8770de;
                         MessageBox.Show(num1 + " / " + num2 + " = " + resultado);
                     }
                 }
             }
        }

        private void radAdicao_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radSubtracao_CheckedChanged(object sender, EventArgs e)
        {

         }

        private void radMultiplicacao_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radDivisao_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtprimeironumero.Text = string.Empty;
            txtsegundonumero.Text = string.Empty;
            txtprimeironumero.Focus();
            radAdicao.Checked = false;
            radSubtracao.Checked = false;
            radMultiplicacao.Checked = false;
            radDivisao.Checked = false;
            pictureBox1.Image = null;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o programa?","Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            { this.Close(); } 
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)) || (Char.IsPunctuation(e.KeyChar)) || (Char.IsSymbol(e.KeyChar)))
            {
                e.Handled = true; //Não deixa a ação ser concluida
                MessageBox.Show("Apenas Números", "Atenção");//Caixa de Aviso
            }
        }
    }
}
