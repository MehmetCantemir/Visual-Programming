namespace _8._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 32; i<255;i++)
            {
                listBox1.Items.Add(i.ToString()+"="+(char)i);
            }
        }
    }
}