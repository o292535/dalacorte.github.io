using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula10_TrocarForm
{
    public partial class frmCadastro : Form
    {
        
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string usuario = txtLogin.Text;
            string senha = txtSenha.Text;

            if (txtSenha.Text != txtRepetirSenha.Text)
            {
                MessageBox.Show("Erro na senha", "Erro de senha");
            }
            else if (txtCadastro.Text == string.Empty || txtIdade.Text == string.Empty || txtLogin.Text == string.Empty || txtSenha.Text == string.Empty || txtRepetirSenha.Text == string.Empty) {
                MessageBox.Show("Erro ", "Erro");
            }
            else
            {
                Form FrmLogin = new frmLogin(usuario,senha);
                FrmLogin.Show();
                this.Hide();
            }
        }
    }
}
