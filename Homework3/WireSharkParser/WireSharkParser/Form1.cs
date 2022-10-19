using Microsoft.VisualBasic.FileIO;

namespace WireSharkParser
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

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                String fileName = System.IO.Path.GetFileName(ofd.FileName);
                MessageBox.Show(fileName + " successfully loaded!");
                CSVPath = ofd.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> ports = new Dictionary<string, int>();
            TextFieldParser parser = new TextFieldParser(CSVPath);
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(",");
            while (!parser.EndOfData)
            {
                string row = parser.ReadLine();

                int count = 0;
                int FirstDel = 0;
                int SecondDel = 0;
                for (int i = 0; i < row.Length; i++)
                {
                    if (row[i] == ',')
                    {
                        count++;
                        if (count == 3)
                        {
                            FirstDel = i + 1;
                        }
                        if (count == 4)
                        {
                            SecondDel = i;
                            break;
                        }
                    }
                }

                string PortNumber = row.Substring(FirstDel, SecondDel - FirstDel);

                if (ports.ContainsKey(PortNumber) == false)
                {
                    ports.Add(PortNumber, 1);

                }
                else
                {
                    ports[PortNumber] = ports[PortNumber] + 1;
                }

            }
            int total = 0;
            foreach (string key in ports.Keys)
            {
                total += ports[key];
            }
            foreach (string key in ports.Keys)
            {
                float x1 = ports[key];
                float x2 = total;
                float x = x1 / x2;
                this.richTextBox1.AppendText(key + " : " + ports[key] + " percentage frequency: " + x * 100 + "%" + "\n");
            }

        }
    }
}