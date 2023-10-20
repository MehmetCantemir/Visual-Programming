namespace _8._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean medeni_durumu;
            medeni_durumu=checkBox1.Checked;
            if(medeni_durumu==true)
            {
                MessageBox.Show("Personel Evlidir");
            }
            else {
                MessageBox.Show("Personel Bekardýr");
            }

        }
    }
}