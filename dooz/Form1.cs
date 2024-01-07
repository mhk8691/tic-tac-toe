namespace dooz
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }



        private void two_player_Click(object sender, EventArgs e)
        {
            name name = new name();
            name.Show();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void play_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon...");
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Are you sure want to exit?",
                               "My First Application",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Information) == DialogResult.OK)
                    Environment.Exit(1);
                else
                    e.Cancel = true; // to don't close form is user change his mind
            }
        }

        private void Home_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
