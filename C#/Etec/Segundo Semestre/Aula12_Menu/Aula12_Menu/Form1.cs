using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula12_Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Menu_Sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente Sair", "Encerrando..", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Menu_Abrir_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName,RichTextBoxStreamType.PlainText);
            }
        }

        private void toolFonte_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK){
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK){
                richTextBox1.SelectionColor = colorDialog1.Color;
                }
        }

        private void Menu_Salvar_Click(object sender, EventArgs e)
        {
                saveFileDialog1.Filter = "Arquivo de Texto|*.txt";
                saveFileDialog1.Title = "Salve Seu Arquivo de Texto"; 
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName,RichTextBoxStreamType.PlainText);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToLongDateString();
            lblCaracter.Text = "Sem caracteres.";
        }

        private void Menu_Novo_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String myText = richTextBox1.Text;
            richTextBox1.Clear();
            richTextBox1.Text = myText;
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.SelectedText);
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String myText = Clipboard.GetText();
            richTextBox1.Text = richTextBox1.Text + myText;
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = string.Empty;
        }

        private void recortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.SelectedText);
            richTextBox1.SelectedText = string.Empty;
        }

        private void selecionarTudoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.Focus();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            foreach (char item in richTextBox1.Text)
            {
                lblCaracter.Text = "Existem " + richTextBox1.TextLength + " Caracteres.";
            }
        }

        

       
    }
}
