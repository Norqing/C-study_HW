namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        static int change = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (change == 0)
            {

                CalBox1.Text += btn.Text;
            }
            else
            {
                CalBox2.Text += btn.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (change == 0)
            {

                CalBox1.Text += btn.Text;
            }
            else
            {
                CalBox2.Text += btn.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (change == 0)
            {

                CalBox1.Text += btn.Text;
            }
            else
            {
                CalBox2.Text += btn.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (change == 0)
            {

                CalBox1.Text += btn.Text;
            }
            else
            {
                CalBox2.Text += btn.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (change == 0)
            {

                CalBox1.Text += btn.Text;
            }
            else
            {
                CalBox2.Text += btn.Text;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (change == 0)
            {

                CalBox1.Text += btn.Text;
            }
            else
            {
                CalBox2.Text += btn.Text;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (change == 0)
            {

                CalBox1.Text += btn.Text;
            }
            else
            {
                CalBox2.Text += btn.Text;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (change == 0)
            {

                CalBox1.Text += btn.Text;
            }
            else
            {
                CalBox2.Text += btn.Text;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (change == 0)
            {

                CalBox1.Text += btn.Text;
            }
            else
            {
                CalBox2.Text += btn.Text;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (change == 0)
            {

                CalBox1.Text += btn.Text;
            }
            else
            {
                CalBox2.Text += btn.Text;
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            OpBox.Text = btn.Text;
            change = 1;
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            OpBox.Text = btn.Text;
            change = 1;
        }

        private void Mul_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            OpBox.Text = btn.Text;
            change = 1;
        }

        private void Div_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            OpBox.Text = btn.Text;
            change = 1;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (change == 0)
            {

                CalBox1.Text += btn.Text;
            }
            else
            {
                CalBox2.Text += btn.Text;
            }
        }

        private void result_Click(object sender, EventArgs e)
        {
            Single result;
            string t = CalBox1.Text;
            string t2 = CalBox2.Text;
            char op = Convert.ToChar(OpBox.Text);
            Single arg1 = Convert.ToSingle(t);
            Single arg2 = Convert.ToSingle(t2);

            switch (op)
            {
                case '+':
                    result = arg1 + arg2;
                    break;
                case '-':
                    result = arg1 - arg2;
                    break;
                case '*':
                    result = arg1 * arg2;
                    break;
                case '/':
                    if (arg2 == 0)
                    {
                        throw new ApplicationException();
                    }
                    else
                    {
                        result = arg1 / arg2;
                        break;
                    }
                default:
                    throw new ApplicationException();
            }
            resultBox.Text = result.ToString();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            CalBox1.Text = "";
            CalBox2.Text = "";
            OpBox.Text = "";
            resultBox.Text = "";
            change = 0;
        }
    }
}