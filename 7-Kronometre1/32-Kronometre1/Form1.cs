using System.Reflection.Emit;

namespace _32_Kronometre1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label7.Visible = false;
            label8.Visible = false;
           
        }
        int saniye = 0;
        int dakika = 0;
        int saat = 0;
        int setMinute = 0;
        int setHour = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
               
               
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;   
            label3.Text = saniye.ToString();
            if (saniye == 59)
            {
                dakika++;
                label2.Text = dakika.ToString();
                saniye = 0;            
            }
            if (dakika==59)
            {
                saat++;
                label1.Text = saat.ToString();
                dakika = 0;
            }
            
        }

        private void EvetBtn_Click(object sender, EventArgs e)
        {
            EvetBtn.Visible = false;
            HayirBtn.Visible = false;
            label6.Visible = false;
            label7.Visible = true;
            label8.Visible = true;
        

            setHour = Convert.ToInt16(textBox1.Text);
            if (setHour<=24 )
            {
                saat = setHour;
            }
            else if (setMinute<=59)
            {
                dakika = setMinute;
            }
                   
                    

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}