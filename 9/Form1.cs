namespace _9
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
            int sonuc;
            ifade = textBox1.Text;
            sonuc = string.Compare("Evet", ifade);
            if(sonuc == 0)
            {
                MessageBox.Show("Burs isteminde bulunamazs�n");
            }
            else
            {
                MessageBox.Show("Burs i�lemleri i�in devam ediniz");
            }
        }
    }
}