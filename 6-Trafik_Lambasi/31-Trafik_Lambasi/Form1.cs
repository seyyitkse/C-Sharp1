namespace _31_Trafik_Lambasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void lightOnBtn_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            sayac++;
            label1.Text = sayac.ToString();
            if (sayac <= 30)
            {
                this.BackColor = Color.Red;
            }
            else if (sayac >= 31 && sayac <= 60)
            {
                this.BackColor = Color.Yellow;
            }
            else if (sayac >= 61 && sayac <= 100)
            {
                this.BackColor = Color.Green;
            }
            else
            {
                sayac = 0;
            }

        }

        private void lightOffBtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}