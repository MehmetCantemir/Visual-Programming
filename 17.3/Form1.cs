namespace _17._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object a;
            a = 155;
            MessageBox.Show(a.ToString());
            a = "Serdar";
            MessageBox.Show(a.ToString());
            Color renk = Color.Black;
            a= renk;
            MessageBox.Show(a.ToString());

        }
    }
}