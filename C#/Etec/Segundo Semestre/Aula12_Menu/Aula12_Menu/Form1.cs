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
        }

        

       
    }
}
