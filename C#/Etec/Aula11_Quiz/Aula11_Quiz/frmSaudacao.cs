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
    public partial class frmSaudacao : Form
    {
        string nome;
        string sexo;
        public frmSaudacao(string n,string s)
        {
            nome = n;
            sexo = s;
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            lblNome.Text = sexo+nome;
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            Form info = new frmInfo();
            info.Show();
            this.Close();
        }
    }
}
