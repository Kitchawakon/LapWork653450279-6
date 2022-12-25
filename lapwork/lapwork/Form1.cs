namespace lapwork
{
    public partial class Form1 : Form
    {
        double input1 = 0;
        string operation = "";
        double input2 = 0;

         public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ans.Text = this.ans.Text + "8";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.ans.Text = this.ans.Text + "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.ans.Text = this.ans.Text + "1";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.ans.Text = this.ans.Text + "2";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.ans.Text = this.ans.Text + "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.ans.Text = this.ans.Text + "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.ans.Text = this.ans.Text + "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.ans.Text = this.ans.Text + "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ans.Text = this.ans.Text + "7";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.ans.Text = this.ans.Text + "9";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.input1 = Double.Parse(this.ans.Text);
            this.ans.Text = "";
            this.operation = "+";
            this.textBox1.Text = input1 + operation.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.input1 = Double.Parse(this.ans.Text);
            this.ans.Text = "";
            this.operation = "-";
            this.textBox1.Text = input1 + operation.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.input1 = Double.Parse(this.ans.Text);
            this.ans.Text = "";
            this.operation = "*";
            this.textBox1.Text = input1 + operation.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.input1 = Double.Parse(this.ans.Text);
            this.ans.Text = "";
            this.operation = "/";
            this.textBox1.Text = input1 + operation.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.ans.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            double input2 = Double.Parse(this.ans.Text);
            double result = 0;
            if (this.operation == "+")
            {
                result = input1 + input2;
                this.ans.Text = result.ToString("#,###.00");
            }
            else if (this.operation == "-")
            {
                result = input1 + input2;
                this.ans.Text = result.ToString("#,###.00");
            }
            else if (this.operation == "*")
            {
                result = input1 + input2;
                this.ans.Text = result.ToString("#,###.00");
            }
            else if (this.operation == "/")
            {
                result = input1 + input2;
                this.ans.Text = result.ToString("#,###.00");
            }
            this.textBox1.Text = input1 + operation + input2.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.ans.Text = this.ans.Text + ".";
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }
    }
}