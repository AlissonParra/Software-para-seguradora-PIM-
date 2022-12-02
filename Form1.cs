using System.Xml;

namespace PIM


{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }
        // Abaixo temos a validação de login 
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Unip" && textBox2.Text == "12345")
            {
                this.Close();
                Thread nt = new Thread(novoForm);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start(); 
            }
            else
            {
                MessageBox.Show("Loguin ou senha invalidos!");
            }
        }

        private void novoForm(object? obj)
        {
            Application.Run(new Form2());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        public void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}