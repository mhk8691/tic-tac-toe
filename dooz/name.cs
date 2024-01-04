using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dooz
{
    public partial class name : Form
    {
        public name()
        {
            InitializeComponent();
        }
        int round = 1;

        private void play_Click(object sender, EventArgs e)
        {
            string fileName = "round.txt";
            string path2 = Path.Combine(Application.StartupPath, fileName);
            two_player two_Player = new two_player();
            if (playerOne.Text != "" && playerTwo.Text != "")
            {

                two_player.Instance.lbl.Text = playerOne.Text;

                two_player.Instance.lbl2.Text = playerTwo.Text;

                File.WriteAllText(path2, round + "");
                two_Player.Show();
                this.Hide();



            }
            else
            {
                File.WriteAllText(path2, round + "");

                two_Player.Show();
                this.Hide();


            }

        }

        private void name_Shown(object sender, EventArgs e)
        {

        }

        private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            count.Text = trackbar.Value.ToString();
            round = trackbar.Value;
        }

        private void name_FormClosing(object sender, FormClosingEventArgs e)
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

        private void back_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
