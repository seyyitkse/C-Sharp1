namespace _17_Proje1_Sinema_Bufe_Satis_Uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int toplam_ucret=0;
        int kasa = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, su, cay, bilet;
            misir=Convert.ToInt16(textBox1.Text);
            su=Convert.ToInt16(textBox2.Text);
            cay=Convert.ToInt16(textBox3.Text);
            bilet=Convert.ToInt16(textBox4.Text);
            toplam_ucret=(misir*4)+(su*1)+(cay*2)+(bilet*15);
            label10.Text="Toplam:"+toplam_ucret+" TL";
            kasa += toplam_ucret;
            label11.Text = "Kasada Toplam:" + kasa + " TL";
        }
    }
}