namespace RandomNumberGessingGame
{
    public partial class Form1 : Form
    {
        int number;
        int attempt = 0;
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // or FormBorderStyle.FixedDialog
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.number == 0)
                {
                    Random rand = new Random();
                    number = rand.Next(1, 101);
                }
                int inputNumber = int.Parse(textBox1.Text);
                label2.Text = inputNumber.ToString();
                if (inputNumber > 100)
                {
                    attempt = attempt + 1;
                    label2.ForeColor = Color.Red;
                    label2.Text = "Should be in a range from 1 to 100";
                }
                else if (inputNumber > number)
                {
                    attempt = attempt + 1;
                    label2.ForeColor = Color.Red;
                    label2.Text = "Too high, try again";
                }
                else if (inputNumber < number)
                {
                    attempt = attempt + 1;
                    label2.ForeColor = Color.Red;
                    label2.Text = "Too low, try again";
                }
                else
                {
                    label2.ForeColor = Color.Green;
                    label2.Text = "Congratulation!";
                    attempt = attempt + 1;
                    this.number = 0;
                    label3.Text = "The number of attempts " + attempt.ToString();
                    this.attempt = 0;
                }

            }
            catch (Exception)
            {

                label2.Text = "Please input an intger number";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.number = 0;
            this.attempt = 0;
            textBox1.Text = "";
            label2.Text = "";
            label3.Text = "";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}