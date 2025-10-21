namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1, s2, sonuc;
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            sonuc = s1 + s2;
            textBox3.Text = sonuc.ToString();

            listBox1.Items.Add($"{s1} + {s2} = {sonuc}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int s1, s2, sonuc;
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            sonuc = s1 - s2;
            textBox3.Text = sonuc.ToString();

            listBox1.Items.Add($"{s1} - {s2} = {sonuc}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double s1, s2, sonuc;
            s1 = Convert.ToDouble(textBox1.Text);
            s2 = Convert.ToDouble(textBox2.Text);
            sonuc = s1 * s2;
            textBox3.Text = sonuc.ToString();

            listBox1.Items.Add($"{s1} x {s2} = {sonuc}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double s1, s2, sonuc;
            s1 = Convert.ToDouble(textBox1.Text);
            s2 = Convert.ToDouble(textBox2.Text);
            sonuc = s1 / s2;
            textBox3.Text = sonuc.ToString();

            listBox1.Items.Add($"{s1} / {s2} = {sonuc}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double s1, sonuc;
            s1 = Convert.ToDouble(textBox1.Text);
            sonuc = Math.Sqrt(s1);
            textBox3.Text = sonuc.ToString();

            listBox1.Items.Add($"√{s1} = {sonuc}");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double s1, s2, sonuc;
            s1 = Convert.ToDouble(textBox1.Text);
            s2 = Convert.ToDouble(textBox2.Text);
            sonuc = Math.Pow(s1, s2);
            textBox3.Text = sonuc.ToString();

            listBox1.Items.Add($"{s1} ^ {s2} = {sonuc}");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double s1, s2, sonuc;
            s1 = Convert.ToDouble(textBox1.Text);
            s2 = Convert.ToDouble(textBox2.Text);
            sonuc = (s1 * s2) / 100;
            textBox3.Text = sonuc.ToString();

            listBox1.Items.Add($"{s1} % {s2} = {sonuc}");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
