namespace _20_Karar_Yapilari_Kitapci_İndirim_Uygulamasi_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kitap_sayisi, normal, indirimli;
            kitap_sayisi=Convert.ToInt32(textBox1.Text);
            normal = kitap_sayisi * 8;
            label3.Text = "Normal Tutar: " + normal + "\n";
            if (kitap_sayisi<=20 && kitap_sayisi>0)
            {
                indirimli =normal- (normal * 20) / 100;
                label4.Text = "İndirimli Tutar: " + indirimli + " TL";
            }
            else if (kitap_sayisi>=21 && kitap_sayisi<=40)
            {
                indirimli = normal - (normal * 40) / 100;
                label4.Text = "İndirimli Tutar: " + indirimli + " TL";
            }
            else if(kitap_sayisi>=41)
            {
                indirimli = normal - (normal * 50) / 100;
                label4.Text = "İndirimli Tutar: " + indirimli + " TL";
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız.!!!");
            }
        }
    }
}