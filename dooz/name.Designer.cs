namespace dooz
{
    partial class name
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            playerOne = new Guna.UI2.WinForms.Guna2TextBox();
            playerTwo = new Guna.UI2.WinForms.Guna2TextBox();
            play = new Guna.UI2.WinForms.Guna2Button();
            trackbar = new Guna.UI2.WinForms.Guna2TrackBar();
            count = new Label();
            SuspendLayout();
            // 
            // playerOne
            // 
            playerOne.Animated = true;
            playerOne.BorderColor = Color.FromArgb(22, 160, 133);
            playerOne.BorderRadius = 7;
            playerOne.BorderThickness = 3;
            playerOne.CustomizableEdges = customizableEdges1;
            playerOne.DefaultText = "";
            playerOne.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            playerOne.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            playerOne.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            playerOne.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            playerOne.FocusedState.BorderColor = Color.FromArgb(22, 160, 133);
            playerOne.Font = new Font("Segoe UI", 9F);
            playerOne.ForeColor = Color.Black;
            playerOne.HoverState.BorderColor = Color.FromArgb(22, 160, 133);
            playerOne.Location = new Point(40, 102);
            playerOne.Name = "playerOne";
            playerOne.PasswordChar = '\0';
            playerOne.PlaceholderForeColor = Color.Gray;
            playerOne.PlaceholderText = "بازیکن اول";
            playerOne.RightToLeft = RightToLeft.Yes;
            playerOne.SelectedText = "";
            playerOne.ShadowDecoration.CustomizableEdges = customizableEdges2;
            playerOne.Size = new Size(277, 45);
            playerOne.TabIndex = 0;
            playerOne.TextAlign = HorizontalAlignment.Right;
            // 
            // playerTwo
            // 
            playerTwo.Animated = true;
            playerTwo.BorderColor = Color.FromArgb(22, 160, 133);
            playerTwo.BorderRadius = 7;
            playerTwo.BorderThickness = 3;
            playerTwo.CustomizableEdges = customizableEdges3;
            playerTwo.DefaultText = "";
            playerTwo.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            playerTwo.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            playerTwo.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            playerTwo.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            playerTwo.FocusedState.BorderColor = Color.FromArgb(22, 160, 133);
            playerTwo.Font = new Font("Segoe UI", 9F);
            playerTwo.ForeColor = Color.Black;
            playerTwo.HoverState.BorderColor = Color.FromArgb(22, 160, 133);
            playerTwo.Location = new Point(40, 172);
            playerTwo.Name = "playerTwo";
            playerTwo.PasswordChar = '\0';
            playerTwo.PlaceholderForeColor = Color.Gray;
            playerTwo.PlaceholderText = "بازیکن دوم";
            playerTwo.RightToLeft = RightToLeft.Yes;
            playerTwo.SelectedText = "";
            playerTwo.ShadowDecoration.CustomizableEdges = customizableEdges4;
            playerTwo.Size = new Size(277, 45);
            playerTwo.TabIndex = 1;
            playerTwo.TextAlign = HorizontalAlignment.Right;
            // 
            // play
            // 
            play.Animated = true;
            play.BackColor = Color.Transparent;
            play.BorderColor = Color.FromArgb(22, 160, 133);
            play.BorderRadius = 7;
            play.BorderThickness = 3;
            play.Cursor = Cursors.Hand;
            play.CustomizableEdges = customizableEdges5;
            play.DisabledState.BorderColor = Color.DarkGray;
            play.DisabledState.CustomBorderColor = Color.DarkGray;
            play.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            play.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            play.FillColor = Color.FromArgb(22, 160, 133);
            play.Font = new Font("Arial Rounded MT Bold", 20.25F);
            play.ForeColor = Color.White;
            play.HoverState.BorderColor = Color.FromArgb(22, 160, 133);
            play.HoverState.FillColor = Color.White;
            play.HoverState.ForeColor = Color.FromArgb(22, 160, 133);
            play.Location = new Point(40, 322);
            play.Name = "play";
            play.ShadowDecoration.CustomizableEdges = customizableEdges6;
            play.Size = new Size(277, 46);
            play.TabIndex = 5;
            play.Text = "شروع";
            play.UseTransparentBackground = true;
            play.Click += play_Click;
            // 
            // trackbar
            // 
            trackbar.Location = new Point(40, 236);
            trackbar.Minimum = 1;
            trackbar.Name = "trackbar";
            trackbar.Size = new Size(277, 40);
            trackbar.TabIndex = 6;
            trackbar.ThumbColor = Color.FromArgb(160, 113, 255);
            trackbar.Value = 1;
            trackbar.Scroll += guna2TrackBar1_Scroll;
            // 
            // count
            // 
            count.AutoSize = true;
            count.Font = new Font("Century", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            count.ForeColor = Color.White;
            count.Location = new Point(40, 279);
            count.Name = "count";
            count.Size = new Size(31, 33);
            count.TabIndex = 7;
            count.Text = "1";
            // 
            // name
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 26, 28);
            ClientSize = new Size(356, 449);
            Controls.Add(count);
            Controls.Add(trackbar);
            Controls.Add(play);
            Controls.Add(playerTwo);
            Controls.Add(playerOne);
            Name = "name";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "name";
            FormClosing += name_FormClosing;
            Shown += name_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox playerOne;
        private Guna.UI2.WinForms.Guna2TextBox playerTwo;
        private Guna.UI2.WinForms.Guna2Button play;
        private Guna.UI2.WinForms.Guna2TrackBar trackbar;
        private Label count;
    }
}