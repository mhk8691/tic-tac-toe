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
    }
}
