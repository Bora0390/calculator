namespace calculator
{
    public partial class Form1 : Form
    {
        char islem;
        bool temizleme;
        double ilkSayi;
        double sonuc = 0;
        public Form1()
        {
            InitializeComponent();

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter || keyData == Keys.Return)
            {
                button15_Click(this, EventArgs.Empty); 
                return true; 
            }
            else if (keyData == Keys.Escape)
            {
                button14_Click(this, EventArgs.Empty); 
                return true; 
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (temizleme)
            {
                label1.Text = "";
                temizleme = false;
            }

            if (label1.Text == "0")
            {
                label1.Text = "";
            }

            label1.Text += "3";
        }

        private void btn1_Click(object sender, EventArgs e)
        {

            if (temizleme)
            {
                label1.Text = "";
                temizleme = false;
            }

            if (label1.Text == "0")
            {
                label1.Text = "";
            }

            label1.Text += "1";

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (temizleme)
            {
                label1.Text = "";
                temizleme = false;
            }

            if (label1.Text == "0")
            {
                label1.Text = "";
            }

            label1.Text += "2";
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (temizleme)
            {
                label1.Text = "";
                temizleme = false;
            }

            if (label1.Text == "0")
            {
                label1.Text = "";
            }

            label1.Text += "4";
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (temizleme)
            {
                label1.Text = "";
                temizleme = false;
            }

            if (label1.Text == "0")
            {
                label1.Text = "";
            }

            label1.Text += "5";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (temizleme)
            {
                label1.Text = "";
                temizleme = false;
            }

            if (label1.Text == "0")
            {
                label1.Text = "";
            }

            label1.Text += "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (temizleme)
            {
                label1.Text = "";
                temizleme = false;
            }

            if (label1.Text == "0")
            {
                label1.Text = "";
            }

            label1.Text += "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (temizleme)
            {
                label1.Text = "";
                temizleme = false;
            }

            if (label1.Text == "0")
            {
                label1.Text = "";
            }

            label1.Text += "8";
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (temizleme)
            {
                label1.Text = "";
                temizleme = false;
            }

            if (label1.Text == "0")
            {
                label1.Text = "";
            }

            label1.Text += "9";
        }

        private void button13_Click(object sender, EventArgs e)
        {

            if (temizleme)
            {
                label1.Text = "";
                temizleme = false;
            }

            if (label1.Text == "0")
            {
                label1.Text = "";
            }

            label1.Text += "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            islem = '+';
            temizleme = true;
            ilkSayi = Convert.ToDouble(label1.Text);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double ikinciSayi = Convert.ToDouble(label1.Text);


            switch (islem)
            {
                case '+':
                    sonuc = ilkSayi + ikinciSayi;
                    label1.Text = Convert.ToString(sonuc);
                    break;
                case '-':
                    sonuc = ilkSayi - ikinciSayi;
                    label1.Text = Convert.ToString(sonuc);
                    break;
                case '*':
                    sonuc = ilkSayi * ikinciSayi;
                    label1.Text = Convert.ToString(sonuc);
                    break;
                case '/':
                    sonuc = ilkSayi / ikinciSayi;
                    label1.Text = Convert.ToString(sonuc);
                    break;
            }
            label1.Text = sonuc.ToString("#,##0.#########");

            temizleme = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            islem = '-';
            temizleme = true;
            ilkSayi = Convert.ToDouble(label1.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            islem = '*';
            temizleme = true;
            ilkSayi = Convert.ToDouble(label1.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            islem = '/';
            temizleme = true;
            ilkSayi = Convert.ToDouble(label1.Text);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length > 0)
            {
                label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);
            }


        }

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1) btn1_Click(sender, e);
            else if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2) button1_Click(sender, e);
            else if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3) btn3_Click(sender, e);
            else if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4) button5_Click(sender, e);
            else if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5) button4_Click(sender, e);
            else if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6) button3_Click(sender, e);
            else if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7) button8_Click(sender, e);
            else if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8) button7_Click(sender, e);
            else if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9) button6_Click(sender, e);
            else if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0) button13_Click(sender, e);

            else if (e.KeyCode == Keys.Add) button9_Click(sender, e); // (+)
            else if (e.KeyCode == Keys.Subtract || e.KeyCode == Keys.OemMinus) button12_Click(sender, e); // (-)
            else if (e.KeyCode == Keys.Multiply) button11_Click(sender, e); // (*)
            else if (e.KeyCode == Keys.Divide || e.KeyCode == Keys.OemQuestion) button10_Click(sender, e); // (/)
            else if (e.KeyCode == Keys.Back) button2_Click(sender, e);


        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                e.IsInputKey = true;
                button15_Click(sender, e);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (temizleme)
            {
                label1.Text = "0";
                temizleme = false;
            }

            // Sistemin ondalık ayırıcısını al (Türkiye'de ",")
            string ayirici = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;

            // Ekranda zaten ayırıcı yoksa ekle
            if (!label1.Text.Contains(ayirici))
            {
                label1.Text += ayirici;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',') button16_Click(sender, e);
        }
        private void FontuAyarla()
        {
            if (label1.Text.Length > 26 )
            {
                label1.Font = new Font(label1.Font.FontFamily, 8, FontStyle.Regular); 
            }
            else if(label1.Text.Length > 16)
            {
                label1.Font = new Font(label1.Font.FontFamily, 10, FontStyle.Regular);
            }
            else
            {
                label1.Font = new Font(label1.Font.FontFamily, 20, FontStyle.Regular); 
            }
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            FontuAyarla();
        }
    }
}
