namespace _11._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ifade = "Visual C# ile";
            string ifade2 = " nesneye yönelik programlama";
            string ifade3;
            ifade=ifade.Insert(1, "Hello");

            MessageBox.Show(ifade);
        }
    }
}