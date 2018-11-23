using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula5Viagem
{
    public partial class frmViagem : Form
    {
        public frmViagem()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int idade = int.Parse(lblIdade.Text);
            string nome = txtNome.Text;
            if (btnM.Checked == true)
            {
                pctSexo.Image = Properties.Resources.W;
                pctSexo2.Image = null;
            }
            if (btnF.Checked == true)
            {
                pctSexo2.Image = Properties.Resources.W;
                pctSexo.Image = null;
            }
            if (idade < 18)
            {
                chkbox.Visible = true;
            }
            if (idade >= 18)
            {
                this.Size = new Size(971, 458);
                groupBox2.Visible = true;
            }
        }

        private void chkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbox.Checked == true)
            {
                this.Size = new Size(971, 458);
                groupBox2.Visible = true;
            }
        }

        private void confirmar_Click(object sender, EventArgs e)
        {
            pctViagem.Image = null;
            pctViagem.Image = null;
            pctViagem.Image = null;
        }

        private void onibus_CheckedChanged(object sender, EventArgs e)
        {
            if (onibus.Checked == true)
            {
                pctViagem.Image = Properties.Resources.W;
            }
        }

        private void navio_CheckedChanged(object sender, EventArgs e)
        {
            if (navio.Checked == true)
            {
                pctViagem.Image = Properties.Resources.W;
            }
        }

        private void aviao_CheckedChanged(object sender, EventArgs e)
        {
            if (aviao.Checked == true)
            {
                pctViagem.Image = Properties.Resources.W;
            }
        }

        private void limpar2_Click(object sender, EventArgs e)
        {
            pctSexo.Image = null;
            pctSexo2.Image = null;
            lblIdade.Text = null;
            lblNome.Text = null;
        }
    }
}
