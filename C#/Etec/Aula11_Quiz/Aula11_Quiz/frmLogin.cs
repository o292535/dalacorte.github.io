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
    public partial class frmLogin : Form
    {
        string usuario;
        string senha;
        string nome;
        string sexo;

        public frmLogin(string u, string s,string n,string se)
        {
            usuario = u;
            senha = s;
            nome = n;
            sexo = se;
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == usuario && txtSenha.Text == senha)
            {
                Form Inicio = new frmSaudacao(nome,sexo);
                Inicio.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Erro de Login", "Erro de Login");
            }
        }
    }
}
