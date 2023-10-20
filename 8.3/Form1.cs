namespace _8._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ifade = " ";
            ifade = textBox1.Text;
            textBox2.Text = textBox1.Text.ToLower();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text.ToUpper();
        }
    }
}