namespace _16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime son_odeme_tarihi, odendigi_tarih;
            double taksit_tutari = 0, fark = 0, ceza = 0;
            taksit_tutari = Convert.ToDouble(textBox1.Text);
            son_odeme_tarihi=DateTime.Parse(textBox2.Text);
            odendigi_tarih=DateTime.Parse(textBox3.Text);
            fark=(double)((odendigi_tarih.ToOADate())-son_odeme_tarihi.ToOADate());

            if(fark > 0 )
            {
                ceza = fark * taksit_tutari * 2 / 1000;
                textBox4.Text= ceza.ToString("#,#");
                double ara_hesap;
                ara_hesap = taksit_tutari + ceza;
                textBox5.Text = ara_hesap.ToString("#,#");
                MessageBox.Show(fark + "g�n ge� �dendi." + textBox4.Text + "TL ceza �denecektir.");
            }
            else if( fark == 0 ) {
                ceza = 0;
                textBox4.Text = "0";
                textBox5.Text = taksit_tutari.ToString("#,#");
                MessageBox.Show("Tam zaman�nda �dendi");
            
            }
            else
            {
                ceza = 5;
                textBox4.Text = ceza.ToString("#,#");
                double ara_hesap2;
                ara_hesap2=taksit_tutari - ceza;
                textBox5.Text = ara_hesap2.ToString("#,#");
                MessageBox.Show(fark + "g�n erken �dendi." + textBox4.Text + "TL indirimli�deyecektir..");

            }
        }   
    }
}