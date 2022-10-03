namespace WinFormsAppHomeW1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(richTextBox4.BackColor == Color.White)
            {
                richTextBox1.BackColor = Color.Green;
                richTextBox4.BackColor = Color.Green;
                richTextBox2.BackColor = Color.White;
                richTextBox4.Text = "Green Light";
            }
            else if (richTextBox4.BackColor == Color.Red)
            {
                richTextBox1.BackColor = Color.Green;
                richTextBox4.BackColor = Color.Green;
                richTextBox3.BackColor = Color.White;
                richTextBox2.BackColor = Color.White;
                richTextBox4.Text = "Green Light";
            }

            else if (richTextBox4.BackColor == Color.Green)
            {
                richTextBox3.BackColor = Color.Red;
                richTextBox4.BackColor = Color.Red;
                richTextBox1.BackColor = Color.White;
                richTextBox2.BackColor = Color.White;
                richTextBox4.Text = "Red Light";
            }
        }

        private void Button1_MouseHover(object sender, EventArgs e)
        {
            if(richTextBox1.BackColor == Color.Green || richTextBox3.BackColor == Color.Red)
            {
                richTextBox2.BackColor = Color.Yellow;
                richTextBox1.BackColor = Color.White;
                richTextBox3.BackColor = Color.White;
            }
        }

        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            if(richTextBox2.BackColor == Color.Yellow)
            {
                richTextBox2.BackColor = Color.White;
                richTextBox1.BackColor = Color.White;
                richTextBox3.BackColor = Color.White;
                richTextBox4.BackColor = Color.White;
                richTextBox4.Text = "";
            }
        }
    }
}