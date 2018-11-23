using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula7_Operacoes_Prova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtValor1.Text == "")
                {
                    MessageBox.Show("Digite o 1º valor", "Atenção");
                    txtValor1.Focus();
                }
                else if (txtValor2.Text == "")
                {
                    MessageBox.Show("Digite o 2º valor", "Atenção");
                    txtValor2.Focus();
                }
                else
                {
                    double valor1, valor2, resultado;
                    valor1 = double.Parse(txtValor1.Text);
                    valor2 = double.Parse(txtValor2.Text);

                    //Se nenhuma operação for selecionada
                    if (radAdicao.Checked == false && radSubtracao.Checked == false && radMultiplicacao.Checked == false && radDivisao.Checked == false)
                    {
                        MessageBox.Show("Selecione uma operação", "Atenção");
                    }
                    else
                    {
                        //Adição
                        if (radAdicao.Checked == true)
                        {
                            resultado = valor1 + valor2;
                            MessageBox.Show(valor1 + " + " + valor2 + " = " + resultado);
                            pctOperacao.Image = Properties.Resources.adicao;
                        }
                        //Subtração
                        if (radSubtracao.Checked == true)
                        {
                            resultado = valor1 - valor2;
                            MessageBox.Show(valor1 + " - " + valor2 + " = " + resultado);
                            pctOperacao.Image = Properties.Resources.subtracao;
                        }
                        //Multiplicação
                        if (radMultiplicacao.Checked == true)
                        {
                            resultado = valor1 * valor2;
                            MessageBox.Show(valor1 + " x " + valor2 + " = " + resultado);
                            pctOperacao.Image = Properties.Resources.multiplicacao;
                        }
                        //Divisão
                        if (radDivisao.Checked == true)
                        {
                            if (valor2 == 0)
                            {
                                MessageBox.Show("Não é possível dividir por zero.", "Atenção");

                            }
                            else
                            {
                                resultado = valor1 / valor2;
                                MessageBox.Show(valor1 + " / " + valor2 + " = " + resultado.ToString("f2"));
                                pctOperacao.Image = Properties.Resources.divisao;
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor1.Clear();
            txtValor2.Clear();
            txtValor1.Focus();
            pctOperacao.Image = null;
            radAdicao.Checked = false;
            radDivisao.Checked = false;
            radSubtracao.Checked = false;
            radMultiplicacao.Checked = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Sair
            if (MessageBox.Show("Deseja fechar o programa?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

       
    }
}
