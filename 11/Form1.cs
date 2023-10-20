namespace _11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ifade;
            ifade = "Visual C# ile nesneye yönelik programlama";
            MessageBox.Show(ifade.IndexOf("yöne", 0).ToString());
        }
    }
}