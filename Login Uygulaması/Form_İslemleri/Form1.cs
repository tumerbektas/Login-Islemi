namespace Form_İslemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void kodOlustur()
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(10000, 100000);
            TxtKod2.Text = sayi.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kodOlustur();
            timer1.Start();
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            if (TxtKullaniciAdi.Text == "admin" && TxtSifre.Text == "1234" && TxtKod1.Text == TxtKod2.Text)
            {
                Form2 frm = new Form2();
                frm.kullanici = TxtKullaniciAdi.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Bilgi Girişi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 frm2 = new Form3();
            frm2.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac % 2 == 0)
            {
                label3.ForeColor = Color.YellowGreen;
            }

            else
            {
                label3.ForeColor = Color.Red;
            }

            if (sayac == 10)
            {
                sayac = 0;
            }
        }
    }
}