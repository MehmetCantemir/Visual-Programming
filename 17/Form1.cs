namespace _17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double toplam = 0.0, sure;
            sure = DateTime.Now.Ticks;
            for(int i=0;i<500000000;i++)
            {
                toplam = toplam + i;
            }

            sure = DateTime.Now.Ticks - sure;
            MessageBox.Show("for döngüsü" + (sure / 100000000) + "saniye sürmüþtür");
        }
    }
}