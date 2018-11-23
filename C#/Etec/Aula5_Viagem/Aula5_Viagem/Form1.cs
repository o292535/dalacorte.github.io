using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula5_Viagem
{
    public partial class FrmViagem : Form
    {
        public FrmViagem()
        {
            InitializeComponent();
        }

        private void FrmViagem_Load(object sender, EventArgs e)
        {
            this.Size = new Size(590, 408);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            chkTermos.Checked = false;
            string nome = txtNome.Text;
            int idade = int.Parse(txtIdade.Text);

            //se o usuario não selecionar sexo
            if (radMasculino.Checked == false && radFeminino.Checked == false)
            {
                //Caixa de mensagem
                MessageBox.Show("Por favor ensira um sexo","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else { 
            

            //Carrega imagem do sexo Mascolino Caso esteja checado(checked = true(verdadeiro) )
            if (radMasculino.Checked == true)
            {
                pctfoto.Image = Properties.Resources.masculino;
            }

            if (radFeminino.Checked == true) {
                pctfoto.Image = Properties.Resources.feminino;
            }


            if (idade <= 18)
            {
                chkTermos.Visible = true;
            }
            else {
                chkTermos.Visible = false;
                chkTermos.Checked = true;
            }
            }
            }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void chkTermos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTermos.Checked == true)
            {
                this.Size = new Size(930, 412);
                gpbTransporte.Visible = true;
            }
            else            {
                gpbTransporte.Visible = false;
                this.Size = new Size(581, 408);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Voce tem certeza de que quer sair?","Sair",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        
        private void radAquatico_CheckedChanged(object sender, EventArgs e)
        {
            pctVeiculo.Image = Properties.Resources.barco;
        }

        private void radTerrestre_CheckedChanged_1(object sender, EventArgs e)
        {

            pctVeiculo.Image = Properties.Resources.carro;
        }

        private void radAereo_CheckedChanged_1(object sender, EventArgs e)
        {
            pctVeiculo.Image = Properties.Resources.aereo;
        }

  

    }
}
