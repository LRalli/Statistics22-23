namespace WinFormsAppRandomTimer
{
    public partial class Form1 : Form
    {
        int n = 0;
        private Random r = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            n = 0;
            this.richTextBox1.Text = "";
            this.timer1.Stop();
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            n++;
            this.richTextBox1.BackColor = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
            this.richTextBox1.Text = ("Running on the " + n.ToString() + "th execution");
        }
    }
}