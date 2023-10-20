namespace _17._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime girilen_tarih;
            TimeSpan fark;
            girilen_tarih = Convert.ToDateTime(textBox1.Text);
            fark=DateTime.Now.Subtract(girilen_tarih);
            MessageBox.Show("Girilen tarih ile þimdiki tarih arasýdaki toplam gün sayýsý = " + fark.TotalDays.ToString("N0") + "\r\n" +
                "Girilen tarih ile þimdiki tarih arasýdaki toplam saat sayýsý = " + fark.TotalHours.ToString("N0") + "\r\n" +
                "Girilen tarih ile þimdiki tarih arasýdaki toplam dakika sayýsý = " + fark.TotalMinutes.ToString("N0") + "\r\n" +
                "Girilen tarih ile þimdiki tarih arasýdaki toplam saniye sayýsý = " + fark.TotalSeconds.ToString("N0") + "\r\n" +
                "Girilen tarih ile þimdiki tarih arasýdaki toplam milisaniye sayýsý = " + fark.TotalMilliseconds.ToString("N0"));


        }
    }
}