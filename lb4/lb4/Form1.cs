using System.Windows.Forms;

namespace lb4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Draw();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Tringle_Click(object sender, EventArgs e)
        {

        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(207, 272);

            Graphics graph = Graphics.FromImage(bmp);

            Pen pen1 = new Pen(Color.Blue, 2);

            graph.DrawLine(pen1, 103, 20, 20, 252);
            graph.DrawLine(pen1, 103, 20, 186, 252);
            graph.DrawLine(pen1, 20, 252, 186, 252);

            Font font = new Font("Arial", 10);
            Brush brush = Brushes.Black;

            graph.DrawString("a", font, brush, 10, 130);
            graph.DrawString("b", font, brush, 180, 130);
            graph.DrawString("c", font, brush, 100, 250);

            Tringle.Image = bmp;
        }
        private void run_Click(object sender, EventArgs e)
        {
            string astr, bstr, cstr;

            astr = aIn.Text;
            bstr = bIn.Text;
            cstr = cIn.Text;

            int a, b, c;

            if (int.TryParse(astr, out a) && int.TryParse(bstr, out b) && int.TryParse(cstr, out c))
            {
                if (a == b)
                {
                    result.Text = "��������� �������������";
                    resultStorona.Text = "a = b";
                    resultSize.Text = a.ToString();
                }
                else if (b == c)
                {
                    result.Text = "��������� �������������";
                    resultStorona.Text = "b = a";
                    resultSize.Text = b.ToString();
                }
                else if (c == a)
                {
                    result.Text = "��������� �������������";
                    resultStorona.Text = "c = a";
                    resultSize.Text = c.ToString();
                }
                else
                {
                    result.Text = "��������� �� �������������";
                }

            }
            else
            {
                MessageBox.Show("������ �����. ����������, ������� ������ �����.");
            }


        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�����  �������������  C#  ��������  ��������  �  ��������� �����������. \n���������  ������ �������� ������� ��������� ���������� � �������. \n������ � ��������� �������� ����� ����� ����������a, b �c.���������, �� � �� ������������. \n³������ ������� � ������ �����������. \n� ��� ������������ �������� �������� ����� �����5.\n������ ���� ��21");
        }
    }


}
