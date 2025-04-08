namespace calc1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string operation1 = "";

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(action.Text == "+" ) {
                int koker = int.Parse(textBox1.Text) + int.Parse(tB.Text);
                string koker1 = koker.ToString();
                tB.Text = koker1;
            }
            
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = tB.Text;
            action.Text = "+";
            tB.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            tB.Text = tB.Text + B1.Text;
        }

        private void B2_Click(object sender, EventArgs e)
        {
            tB.Text = tB.Text + B2.Text;
        }

        private void B3_Click(object sender, EventArgs e)
        {
            tB.Text = tB.Text + B3.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void action_TextChanged(object sender, EventArgs e)
        {

        }
    }
}