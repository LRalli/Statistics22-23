using Microsoft.VisualBasic.FileIO;

namespace WinFormsAppCSVParser
{
    public partial class Form1 : Form
    {
        String CSVPath = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "Open CSV File",
                Filter = "csv files (*.csv)|*.csv",
                CheckFileExists = true,
                CheckPathExists = true,
            };

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                String fileName = System.IO.Path.GetFileName(ofd.FileName);
                MessageBox.Show(fileName + " successfully loaded!");
                CSVPath = ofd.FileName;
            }

            TextFieldParser parser = new TextFieldParser(CSVPath);
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(",");
            while (!parser.EndOfData)
            {
                string row = parser.ReadLine();
                this.richTextBox1.AppendText(row + "\n");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
        }

        string[] colours = { "brown", "blonde", "black", "red" };
        int[] amount = { 0, 0, 0, 0 };

        private void button3_Click(object sender, EventArgs e)
        {
            this.richTextBox2.AppendText("Calculating the univariate distribution of students' hair color: \n");
            using (TextFieldParser parser = new TextFieldParser(CSVPath))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                string[] attribute = parser.ReadFields();
                int index = 0;
                for (int i = 0; i < attribute.Length; i++)
                {
                    if (attribute[i] == "Hair_color")
                    {
                        index = i;
                    }
                }
                while (!parser.EndOfData)
                {
                    string[] values = parser.ReadFields();
                    for (int i = 0; i < colours.Length; i++)
                    {
                        if (colours[i] == values[index].ToLower())
                        {
                            amount[i]++;
                        }
                    }
                }
            }
            int total = 0;
            for (int i = 0; i < amount.Length; i++)
            {
                total = total + amount[i];
            }
            for (int i = 0; i < colours.Length; i++)
            {
                string color = colours[i];
                int number = amount[i];
                float x1 = number;
                float x2 = total;
                float x = x1 / x2;
                this.richTextBox2.AppendText(color + ": " + number.ToString() + "  " + "percentage frequency: " + x * 100 + "%" + "\n");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.richTextBox2.Text = "";
            Array.Clear(amount, 0, amount.Length);
        }
    }
}