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
            MessageBox.Show("Girilen tarih ile �imdiki tarih aras�daki toplam g�n say�s� = " + fark.TotalDays.ToString("N0") + "\r\n" +
                "Girilen tarih ile �imdiki tarih aras�daki toplam saat say�s� = " + fark.TotalHours.ToString("N0") + "\r\n" +
                "Girilen tarih ile �imdiki tarih aras�daki toplam dakika say�s� = " + fark.TotalMinutes.ToString("N0") + "\r\n" +
                "Girilen tarih ile �imdiki tarih aras�daki toplam saniye say�s� = " + fark.TotalSeconds.ToString("N0") + "\r\n" +
                "Girilen tarih ile �imdiki tarih aras�daki toplam milisaniye say�s� = " + fark.TotalMilliseconds.ToString("N0"));


        }
    }
}