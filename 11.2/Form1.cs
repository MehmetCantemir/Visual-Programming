namespace _11._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ifade = "Visual C# ile";
            string ifade2 = "nesneye yönelimli programlama";
            string ifade3;
            ifade3=String.Concat(ifade, ifade2);
            MessageBox.Show(ifade3);
        }
    }
}