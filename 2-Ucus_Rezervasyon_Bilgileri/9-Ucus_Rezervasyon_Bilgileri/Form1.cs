namespace _9_Ucus_Rezervasyon_Bilgileri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox1.Text+" "+comboBox2.Text+" "+dateTimePicker1.Text+" "+maskedTextBox1.Text);
            listBox1.Items.Add(textBox1.Text + " " + maskedTextBox2.Text + " " + maskedTextBox3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sehir1,sehir2;
            sehir1=comboBox1.Text;
            sehir2 = comboBox2.Text;
            comboBox1.Text=sehir2;
            comboBox2.Text = sehir1;
        }
    }
}