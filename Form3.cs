using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        // Abaixo estamos configurando a textbox para receber apenas letras.
        private void txtchar_Keypress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                MessageBox.Show("Apenas letras!");
            }
        }
        // Abaixo estamos configurando a textbox para receber apenas números.
        private void txtnun_Keypress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("Apenas Números!");
            }
        }
        // Abaixo estamos configurando a textbox para receber apenas letras e números.
        private void txtSim_Keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar))
            {
                MessageBox.Show("Apenas letras e Números!");
            }
        }
        // A baixo estamos validando se todos os dados estão preenchidos, caso esteja o sistema ira para o form 5 que é o de tipo de plano, caso falte algum campo aparecera uma mensagem solicitando ao usuário que preencha.
        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarForm())
            {
                Form5 Outroform = new Form5();
                Outroform.ShowDialog();
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
            else if (textBox7.Text == "")
                Formvali = false;
            else if (textBox8.Text == "")
                Formvali = false;
            else if (textBox9.Text == "")
                Formvali = false;
            else if (textBox10.Text == "")
                Formvali = false;
            else if (textBox11.Text == "")
                Formvali = false;
            else if (textBox12.Text == "")
                Formvali = false;
            else if (textBox13.Text == "")
                Formvali = false;
            else if (textBox14.Text == "")
                Formvali = false;
            else if (textBox15.Text == "")
                Formvali = false;
            else if (textBox16.Text == "")
                Formvali = false;
            else if (textBox17.Text == "")
                Formvali = false;
            else if (textBox18.Text == "")
                Formvali = false;
            else if (textBox19.Text == "")
                Formvali = false;
            else
                Formvali = true;
            return Formvali;
        }
        // Abaixo estamos chamando o form de menu. (Voltando a tela anterior) 
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 novo = new Form2();
            novo.Show();

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


        
    



    
    

