using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula11_Quiz 
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string usuario = txtLogin.Text;
            string senha = txtSenha.Text;
            string sexo = "";

                 if (txtSenha.Text != txtRepetirSenha.Text)
                {
                    MessageBox.Show("Erro na senha", "Erro de senha");
                }
                else if (txtNome.Text == string.Empty || txtLogin.Text == string.Empty || txtSenha.Text == string.Empty || txtRepetirSenha.Text == string.Empty)
                {
                    MessageBox.Show("Erro ", "Erro");
                }

                 else if (radFemino.Checked == false && radMasculino.Checked == false)
                 {
                     MessageBox.Show("Selecione o Sexo", "Selecione o Sexo");
                 }
                else
                {
                       if (radMasculino.Checked == true)
                     {
                         sexo = "Bem vindo ";
                     }
                     else if (radFemino.Checked == true)
                     {
                         sexo = "Bem vinda ";
                     }
                    Form FrmLogin = new frmLogin(usuario, senha, nome, sexo);
                    FrmLogin.Show();
                    this.Hide();

                }
            }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        }
    }

