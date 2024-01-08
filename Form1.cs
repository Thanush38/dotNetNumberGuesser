namespace Number_guesser
{
    public partial class Form1 : Form
    {
        public int number;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            changeNumber(sender, e);
        }
        private void changeNumber(object sender, EventArgs e)
        {
            Random random = new Random();
            number = random.Next(99) + 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String guessStr = textBox1.Text;
            int guess = 0;
            if (guessStr == "")
            {
                label1.Text = "Please enter a number";
            }
            else
                guess = int.Parse(guessStr);
            {

            }
            if (guess == number)
            {
                Form2 correct = new Form2();
                correct.Show();
                this.Hide();
                label1.Text = "Guess a number between 1-100";

            }
            else if (guess < number)
            {
                label1.Text = "Guess too low";
            }
            else if (guess > number)
            {
                label1.Text = "Guess too high";
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
