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
    public partial class frmLogin : Form
    {
        string usuario;
        string senha;
        public frmLogin()
        {
            InitializeComponent();
        }
        public frmLogin(string u,string s)
        {
            usuario = u;
            senha = s;
            InitializeComponent();
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == usuario && txtSenha.Text == senha)
            {
                Form Inicio = new frmInicio();
                Inicio.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Erro de Login","Erro de Login");
            }
        }
    }
}
