namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            int y = fib(num);
            MessageBox.Show(y.ToString());

            int fib(int num)
            {
                if (num <= 2)
                    return num - 1;
                else
                    return fib(num - 1) + fib(num - 2);
            }
        }

       
        

        
    }
}
