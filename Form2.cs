using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PIM
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        // A baixo estamos chamado um form que no caso é o form de cadastrar cliente
        private void button1_Click(object sender, EventArgs e)
        {
            Form3 Consulta = new Form3();
            Consulta.ShowDialog();
           
        }
       

        private void novoForm(object? obj)
        {
            Application.Run(new Form3()); 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }
        // A baixo estamos chamado um form que no caso é o form  de menu (Ou seja estamos voltando ao form anterior)
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 novo = new Form1();
            novo.Show();
        }
        // A baixo estamos chamado um form que no caso é o form de consultar o veuculo
        private void button2_Click(object sender, EventArgs e)
        {
           
            Form4 Consulta = new Form4(); 
            Consulta.ShowDialog();
        }
        // A baixo estamos chamado um form que no caso é o form de cadastro de funcionario
        private void button4_Click(object sender, EventArgs e)
        {
            Form6 Consulta = new Form6();
            Consulta.ShowDialog();
        }
        // A baixo estamos chamado um form que no caso é o form de Registro de ocorrencia
        private void button5_Click(object sender, EventArgs e)
        {
            Form7 Consulta = new Form7();
            Consulta.ShowDialog();
        }
        // A baixo estamos chamado um form que no caso é o form de Cotaçãod de reparo
        private void button6_Click(object sender, EventArgs e)
        {
            Form8 Consulta = new Form8();
            Consulta.ShowDialog();
        }
    }
    }

