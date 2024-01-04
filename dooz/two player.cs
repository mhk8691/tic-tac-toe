using Guna.UI2.WinForms;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dooz
{
    public partial class two_player : Form
    {
        public static two_player Instance;
        public Label lbl;
        public Label lbl2;
        public Label lbl3;
        public Label lbl4;

        public two_player()
        {
            InitializeComponent();
            Instance = this;
            lbl = player_one;
            lbl2 = player_two;



        }
        int count = 0;
        int player1 = 0;
        int player2 = 0;
        string player_is_won = "";
        int round_final;


        public void click(Control name)
        {
            if (name.Text == "")
            {

                if (count % 2 == 0)
                {
                    name.Text = "X";
                    name.ForeColor = Color.Red;
                    player_is_won = "X";
                    turn.Text = player_two.Text + ":";
                    turn2.Text = "O";
                    turn.ForeColor = Color.Yellow;
                    turn2.ForeColor = Color.Yellow;

                }
                else
                {
                    name.Text = "O";
                    name.ForeColor = Color.Yellow;
                    player_is_won = "O";
                    turn.Text = player_one.Text + ":";
                    turn2.Text = "X";
                    turn.ForeColor = Color.Red;
                    turn2.ForeColor = Color.Red;
                }
                count++;
            }


        }

        public void clear()
        {
            timer1.Stop();
            count = 0;
            one.Text = "";
            two.Text = "";
            three.Text = "";
            fuor.Text = "";
            five.Text = "";
            six.Text = "";
            seven.Text = "";
            eight.Text = "";
            nine.Text = "";
            one.BorderColor = Color.White;
            two.BorderColor = Color.White;
            three.BorderColor = Color.White;
            fuor.BorderColor = Color.White;
            five.BorderColor = Color.White;
            six.BorderColor = Color.White;
            seven.BorderColor = Color.White;
            eight.BorderColor = Color.White;
            nine.BorderColor = Color.White;
            turn.Text = player_one.Text + ":";
            turn2.Text = "X";
            turn.ForeColor = Color.Red;
            turn2.ForeColor = Color.Red;
        }

        public void win()
        {
            if (player_is_won == "X")
            {
                player1++;
                playerone_point.Text = player1.ToString();


            }
            else if (player_is_won == "O")
            {
                player2++;
                playertwo_point.Text = player2.ToString();


            }


        }



        public void HowIsWin()
        {
            if (one.Text == player_is_won && two.Text == player_is_won && three.Text == player_is_won)
            {
                if (player_is_won == "X")
                {
                    player1++;
                    playerone_point.Text = player1.ToString();
                    one.BorderColor = Color.Red;
                    two.BorderColor = Color.Red;
                    three.BorderColor = Color.Red;
                    turn.Text = "";
                    turn2.Text = "";

                }
                else if (player_is_won == "O")
                {
                    player2++;
                    playertwo_point.Text = player2.ToString();
                    one.BorderColor = Color.Yellow;
                    two.BorderColor = Color.Yellow;
                    three.BorderColor = Color.Yellow;
                    turn.Text = "";
                    turn2.Text = "";

                }
                timer1.Start();

            }
            else if (fuor.Text == player_is_won && five.Text == player_is_won && six.Text == player_is_won)
            {
                if (player_is_won == "X")
                {
                    player1++;
                    playerone_point.Text = player1.ToString();
                    fuor.BorderColor = Color.Red;
                    five.BorderColor = Color.Red;
                    six.BorderColor = Color.Red;
                    turn.Text = "";
                    turn2.Text = "";

                }
                else if (player_is_won == "O")
                {
                    player2++;
                    playertwo_point.Text = player2.ToString();
                    fuor.BorderColor = Color.Yellow;
                    five.BorderColor = Color.Yellow;
                    six.BorderColor = Color.Yellow;
                    turn.Text = "";
                    turn2.Text = "";

                }
                timer1.Start();
            }
            else if (seven.Text == player_is_won && eight.Text == player_is_won && nine.Text == player_is_won)
            {
                if (player_is_won == "X")
                {
                    player1++;
                    playerone_point.Text = player1.ToString();
                    seven.BorderColor = Color.Red;
                    eight.BorderColor = Color.Red;
                    nine.BorderColor = Color.Red;
                    turn.Text = "";
                    turn2.Text = "";

                }
                else if (player_is_won == "O")
                {
                    player2++;
                    playertwo_point.Text = player2.ToString();
                    seven.BorderColor = Color.Yellow;
                    eight.BorderColor = Color.Yellow;
                    nine.BorderColor = Color.Yellow;
                    turn.Text = "";
                    turn2.Text = "";

                }
                timer1.Start();
            }
            else if (one.Text == player_is_won && fuor.Text == player_is_won && seven.Text == player_is_won)
            {
                if (player_is_won == "X")
                {
                    player1++;
                    playerone_point.Text = player1.ToString();
                    one.BorderColor = Color.Red;
                    fuor.BorderColor = Color.Red;
                    seven.BorderColor = Color.Red;
                    turn.Text = "";
                    turn2.Text = "";

                }
                else if (player_is_won == "O")
                {
                    player2++;
                    playertwo_point.Text = player2.ToString();
                    one.BorderColor = Color.Yellow;
                    fuor.BorderColor = Color.Yellow;
                    seven.BorderColor = Color.Yellow;
                    turn.Text = "";
                    turn2.Text = "";

                }
                timer1.Start();
            }
            else if (two.Text == player_is_won && five.Text == player_is_won && eight.Text == player_is_won)
            {
                if (player_is_won == "X")
                {
                    player1++;
                    playerone_point.Text = player1.ToString();
                    two.BorderColor = Color.Red;
                    five.BorderColor = Color.Red;
                    eight.BorderColor = Color.Red;
                    turn.Text = "";
                    turn2.Text = "";

                }
                else if (player_is_won == "O")
                {
                    player2++;
                    playertwo_point.Text = player2.ToString();
                    two.BorderColor = Color.Yellow;
                    five.BorderColor = Color.Yellow;
                    eight.BorderColor = Color.Yellow;
                    turn.Text = "";
                    turn2.Text = "";

                }
                timer1.Start();
            }
            else if (three.Text == player_is_won && six.Text == player_is_won && nine.Text == player_is_won)
            {
                if (player_is_won == "X")
                {
                    player1++;
                    playerone_point.Text = player1.ToString();
                    three.BorderColor = Color.Red;
                    six.BorderColor = Color.Red;
                    nine.BorderColor = Color.Red;
                    turn.Text = "";
                    turn2.Text = "";

                }
                else if (player_is_won == "O")
                {
                    player2++;
                    playertwo_point.Text = player2.ToString();
                    three.BorderColor = Color.Yellow;
                    six.BorderColor = Color.Yellow;
                    nine.BorderColor = Color.Yellow;
                    turn.Text = "";
                    turn2.Text = "";

                }
                timer1.Start();
            }
            else if (one.Text == player_is_won && five.Text == player_is_won && nine.Text == player_is_won)
            {
                if (player_is_won == "X")
                {
                    player1++;
                    playerone_point.Text = player1.ToString();
                    one.BorderColor = Color.Red;
                    five.BorderColor = Color.Red;
                    nine.BorderColor = Color.Red;
                    turn.Text = "";
                    turn2.Text = "";

                }
                else if (player_is_won == "O")
                {
                    player2++;
                    playertwo_point.Text = player2.ToString();
                    one.BorderColor = Color.Yellow;
                    five.BorderColor = Color.Yellow;
                    nine.BorderColor = Color.Yellow;
                    turn.Text = "";
                    turn2.Text = "";

                }
                timer1.Start();
            }
            else if (three.Text == player_is_won && five.Text == player_is_won && seven.Text == player_is_won)
            {
                if (player_is_won == "X")
                {
                    player1++;
                    playerone_point.Text = player1.ToString();
                    three.BorderColor = Color.Red;
                    five.BorderColor = Color.Red;
                    seven.BorderColor = Color.Red;
                    turn.Text = "";
                    turn2.Text = "";

                }
                else if (player_is_won == "O")
                {
                    player2++;
                    playertwo_point.Text = player2.ToString();
                    three.BorderColor = Color.Yellow;
                    five.BorderColor = Color.Yellow;
                    seven.BorderColor = Color.Yellow;
                    turn.Text = "";
                    turn2.Text = "";

                }
                timer1.Start();
            }
            else if (one.Text != "" && two.Text != "" && three.Text != "" && fuor.Text != "" && five.Text != "" && six.Text != "" && seven.Text != "" && eight.Text != "" && nine.Text != "")
            {
                one.BorderColor = Color.Green;
                two.BorderColor = Color.Green;
                three.BorderColor = Color.Green;
                fuor.BorderColor = Color.Green;
                five.BorderColor = Color.Green;
                six.BorderColor = Color.Green;
                seven.BorderColor = Color.Green;
                eight.BorderColor = Color.Green;
                nine.BorderColor = Color.Green;
                turn.Text = "";
                turn2.Text = "";
                timer1.Start();

            }
            final_win();

        }

        public void clear_all()
        {
            clear();
            player1 = 0;
            player2 = 0;
            playerone_point.Text = player1.ToString();
            playertwo_point.Text = player2.ToString();
            count = 0;
        }

        public void final_win()
        {
            string fileName = "round.txt";
            string path2 = Path.Combine(Application.StartupPath, fileName);
            string round = File.ReadAllText(path2);
            round_final = Convert.ToInt32(round);

            name name = new name();
            if (player1 == round_final)
            {

                MessageBox.Show(player_one.Text + " won the game!");
                clear_all();
            }
            else if (player2 == round_final)
            {
                MessageBox.Show(player_one.Text + " won the game!");
                clear_all();
            }
        }

        private void one_Click(object sender, EventArgs e)
        {

            click(one);
            HowIsWin();
        }

        private void two_Click(object sender, EventArgs e)
        {
            click(two);
            HowIsWin();
        }

        private void three_Click(object sender, EventArgs e)
        {
            click(three);
            HowIsWin();
        }

        private void fuor_Click(object sender, EventArgs e)
        {
            click(fuor);
            HowIsWin();

        }

        private void five_Click(object sender, EventArgs e)
        {
            click(five);
            HowIsWin();

        }

        private void six_Click(object sender, EventArgs e)
        {
            click(six);
            HowIsWin();
        }

        private void seven_Click(object sender, EventArgs e)
        {
            click(seven);
            HowIsWin();
        }

        private void eight_Click(object sender, EventArgs e)
        {
            click(eight);
            HowIsWin();
        }

        private void nine_Click(object sender, EventArgs e)
        {
            click(nine);
            HowIsWin();
        }

        private void back_Click(object sender, EventArgs e)
        {
            name name = new name();
            name.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            clear();
        }



        private void two_player_Shown(object sender, EventArgs e)
        {
            turn.Text = player_one.Text + ":";
            turn2.Text = "X";
            turn.ForeColor = Color.Red;
            turn2.ForeColor = Color.Red;
        }

        private void two_player_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
