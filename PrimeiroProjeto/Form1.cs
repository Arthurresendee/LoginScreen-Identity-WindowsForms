namespace PrimeiroProjeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            MessageBox.Show($"o texto � {nome}");
        }
    }
}