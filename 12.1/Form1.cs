namespace _12._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Font = new Font("Courier New", 10, FontStyle.Regular);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text.PadRight(15, '0')+" "+
                textBox2.Text.PadRight(20,'0')+" "+
                textBox3.Text.PadRight(15,'0')+" "+
                textBox4.Text.PadRight(6,' ')+" "+
                textBox5.Text        
                );
        }
    }
}