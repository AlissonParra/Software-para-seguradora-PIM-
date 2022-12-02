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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        // Abaixo estamos chamado o form de menu. (Ou seja estamos voltando uma tela)
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 novo = new Form2();
            novo.Show();
        }
        // Abaixo estamos validando se o usuário preencheu todos os campos.Caso não tenha o sistema ira apresentar uma mensagem solicitando para o usuário preencher todos os campos.
        private void button1_Click(object sender, EventArgs e)
        {

            if (ValidarForm())
            {
                MessageBox.Show("Ocorrencia registrada!");
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
            else if (textBox4.Text == "")
                Formvali = false;
            else if (textBox5.Text == "")
                Formvali = false;
            else if (textBox6.Text == "")
                Formvali = false;

            else
            
                Formvali = true;
                return Formvali;
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
