using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PIM
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        // Abaixo estamos chamado o form de cadastro do cliente (ou seja estamos voltando uma tela) 
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 novo = new Form3();
            novo.Show();
        }
        // Abaixo estamos validando se o usuário preencheu todos os campos, caso não tenha preenchido o sistema ira apresentar uma mensagem solicitando para preencher.
        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarForm())
            {
                MessageBox.Show("Cadastro realizado!");
            }
            else
                MessageBox.Show("Preencha todos os campos!");
        }
        private bool ValidarForm()

        {
            bool Formvali;
            if (textBox1.Text == "")
                Formvali = false;
            else if (textBox2.Text == "")
                Formvali = false;
            else if (textBox3.Text == "")
                Formvali = false;
            else
                Formvali = true;
            return Formvali;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

