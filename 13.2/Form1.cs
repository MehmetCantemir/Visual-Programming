namespace _13._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string a;
            listBox1.Font = new Font("Courier New", 9, FontStyle.Regular);
            listBox1.Items.Add("Karakter Kodu :  Karaker");
            for (int i = 0; i < 255; i++)
            {
                a = i.ToString().PadLeft(4, ' ');

                a = a + "                 " + (char)i;
                switch (comboBox1.Text)
                {
                    case "Control":
                        if (Char.IsControl((char)i))
                            listBox1.Items.Add(a);
                        break;

                    case "Digit":
                        if (Char.IsDigit((char)i))
                            listBox1.Items.Add(a);
                        break;

                    case "Letter":
                        if (Char.IsLetter((char)i))
                            listBox1.Items.Add(a);
                        break;

                    case "LetterorDigit":
                        if (Char.IsLetterOrDigit((char)i))
                            listBox1.Items.Add(a);
                        break;

                    case "Lower":
                        if (Char.IsLower((char)i))
                            listBox1.Items.Add(a);
                        break;

                    case "Number":
                        if (Char.IsNumber((char)i))
                            listBox1.Items.Add(a);
                        break;

                    case "Punctuation":
                        if (Char.IsPunctuation((char)i))
                            listBox1.Items.Add(a);
                        break;

                    case "Seperator":
                        if (Char.IsSeparator((char)i))
                            listBox1.Items.Add(a);
                        break;

                    case "Surrogate":
                        if (Char.IsSurrogate((char)i))
                            listBox1.Items.Add(a);
                        break;

                    case "Symbol":
                        if (Char.IsSymbol((char)i))
                            listBox1.Items.Add(a);
                        break;

                    case "Upper":
                        if (Char.IsUpper((char)i))
                            listBox1.Items.Add(a);
                        break;

                    case "WhiteSpace":
                        if (Char.IsWhiteSpace((char)i))
                            listBox1.Items.Add(a);
                        break;
                }
            }
        }
    }
}