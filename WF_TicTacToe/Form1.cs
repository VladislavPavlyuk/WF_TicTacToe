namespace WF_TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.button1.ForeColor = Color.Gold;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.ForeColor = Color.GhostWhite;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(WF_TicTacToe.Properties.Resources.icons8_Shutdown_52px_4);
            Bitmap imgHover = new Bitmap(WF_TicTacToe.Properties.Resources.icons8_Shutdown_52px_2);

            this.pictureBox2.Image = imgHover;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(WF_TicTacToe.Properties.Resources.icons8_Shutdown_52px_4);
            Bitmap imgHover = new Bitmap(WF_TicTacToe.Properties.Resources.icons8_Shutdown_52px_2);
            this.pictureBox2.Image = img;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            button3.Visible = true;
            button1.Visible = false;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            this.button2.ForeColor = Color.Teal;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.button2.ForeColor = Color.Black;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            this.button3.ForeColor = Color.Teal;

        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            this.button3.ForeColor = Color.Black;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SinglePlay frm = new SinglePlay("easy");
            frm.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SinglePlay frm = new SinglePlay("medium");
            frm.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            Game frm = new Game();
            frm.Show();
            this.Hide();

        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.ForeColor = Color.OrangeRed;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.ForeColor = Color.Peru;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.ForeColor = Color.OrangeRed;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.ForeColor = Color.Peru;

        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.ForeColor = Color.OrangeRed;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.ForeColor = Color.Peru;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SinglePlay frm = new SinglePlay("hard");
            frm.Show();
            Hide();
        }
    }
}