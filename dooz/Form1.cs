namespace dooz
{
    public partial class Form1 : Form
    {
        public Form1()
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

       
    }
}
