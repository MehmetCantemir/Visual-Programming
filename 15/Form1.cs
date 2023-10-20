namespace _15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            DateTime baslangic_tarihi, bitis_tarihi;
            int gun_sayisi;

            baslangic_tarihi=DateTime.Parse(textBox1.Text);
            gun_sayisi=Convert.ToInt32(textBox2.Text);
            bitis_tarihi = baslangic_tarihi.AddDays(gun_sayisi);
            label4.Text = bitis_tarihi.ToLongDateString();
        }
    }
}