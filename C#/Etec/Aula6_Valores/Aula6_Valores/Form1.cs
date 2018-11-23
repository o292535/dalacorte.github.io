using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula6_Valores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, num3;
            int maior = 0; int menor = 0; 
            if (txtprimeiro.Text == "")
            {
                lblResp.Text = "Digite o Primeiro Valor";
            }
            else if (txtsegundo.Text == "")
            {
                lblResp.Text = "Digite o Segundo Valor";
            }
            else if (txtterceiro.Text == "")
            {
                lblResp.Text = "Digite o Terceiro valor";
            }

            else
            {
                num1 = Convert.ToInt32(txtprimeiro.Text);
                num2 = Convert.ToInt32(txtsegundo.Text);
                num3 = Convert.ToInt32(txtterceiro.Text);
                if (num1 > num2 && num1 > num3)
                {
                    maior = num1;
                }
                else if (num2 > num1 && num2 > num3)
                {
                    maior = num2;
                }
                else
                {
                    maior = num3;
                    if (num1 == num2 && num1 != num3)
                    {
                        maior = num1;
                    }

                }
                if (num1 < num2 && num1 < num3)
                {
                    menor = num1;
                }
                else if (num2 < num1 && num2 < num3)
                {
                    menor = num2;
                }
                else
                {
                    menor = num3;

                }
                lblResp.Text = "O menor numero é o: " + menor + " o maior numero é o: " + maior;
                if (num1 == num2 && num1 == num3 )//|| num2 == num3 && num2 == num1 || num3 == num1 && num3 == num2)
                {
                    lblResp.Text = "Todos os numeros são identicos!";
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtprimeiro_KeyPress(object sender, KeyPressEventArgs e)
        {


          
        }

        private void txtsegundo_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void txtterceiro_KeyPress(object sender, KeyPressEventArgs e)
        {
            
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
