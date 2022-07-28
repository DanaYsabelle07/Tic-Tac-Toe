namespace Tic_Tac_Toe_Game
{
    public partial class board : Form
    {
        bool playerturn = true;
        int gameturn = 0;

        public board()
        {
            InitializeComponent();
        }

        private void box1_Click(object sender, EventArgs e)
        {
            if (playerturn)
            {
                box1.Text = "X";
            }
            else
            {
                box1.Text = "O";
            }
            
            box1.Enabled = false;
            playerturn = !playerturn;
            gameturn++;
            winner();
        }

        private void box2_Click(object sender, EventArgs e)
        {
            if (playerturn)
            {
                box2.Text = "X";
            }
            else
            {
                box2.Text = "O";
            }
            box2.Enabled = false;
            playerturn = !playerturn;
            gameturn++;
            winner();
        }

        private void box3_Click(object sender, EventArgs e)
        {
            if (playerturn)
            {
                box3.Text = "X";
            }
            else
            {
                box3.Text = "O";
            }
            box3.Enabled = false;
            playerturn = !playerturn;
            gameturn++;
            winner();
        }

        private void box4_Click(object sender, EventArgs e)
        {
            if (playerturn)
            {
                box4.Text = "X";
            }
            else
            {
                box4.Text = "O";
            }
            box4.Enabled = false;
            playerturn = !playerturn;
            gameturn++;
            winner();
        }

        private void box5_Click(object sender, EventArgs e)
        {
            if (playerturn)
            {
                box5.Text = "X";
            }
            else
            {
                box5.Text = "O";
            }
            box5.Enabled = false;
            playerturn = !playerturn;
            gameturn++;
            winner();
        }

        private void box6_Click(object sender, EventArgs e)
        {
            if (playerturn)
            {
                box6.Text = "X";
            }
            else
            {
                box6.Text = "O";
            }
            box6.Enabled = false;
            playerturn = !playerturn;
            gameturn++;
            winner();
        }

        private void box7_Click(object sender, EventArgs e)
        {
            if (playerturn)
            {
                box7.Text = "X";
            }
            else
            {
                box7.Text = "O";
            }
            box7.Enabled = false;
            playerturn = !playerturn;
            gameturn++;
            winner();
        }

        private void box8_Click(object sender, EventArgs e)
        {
            if (playerturn)
            {
                box8.Text = "X";
            }
            else
            {
                box8.Text = "O";
            }
            box8.Enabled = false;
            playerturn = !playerturn;
            gameturn++;
            winner();
        }

        private void box9_Click(object sender, EventArgs e)
        {
            if (playerturn)
            {
                box9.Text = "X";
            }
            else
            {
                box9.Text = "O";
            }
            box9.Enabled = false;
            playerturn = !playerturn;
            gameturn++;
            winner();
        }

        private void winner()
        {
            bool thewinner = false;

            if ((box1.Text == box2.Text) && (box1.Text == box3.Text) && (!box1.Enabled))
                thewinner = true;
            else if ((box4.Text == box5.Text) && (box4.Text == box6.Text) && (!box4.Enabled))
                thewinner = true;
            else if ((box7.Text == box8.Text) && (box7.Text == box9.Text) && (!box7.Enabled))
                thewinner = true;
            else if ((box1.Text == box4.Text) && (box1.Text == box7.Text) && (!box1.Enabled))
                thewinner = true;
            else if ((box2.Text == box5.Text) && (box2.Text == box8.Text) && (!box2.Enabled))
                thewinner = true;
            else if ((box3.Text == box4.Text) && (box3.Text == box9.Text) && (!box3.Enabled))
                thewinner = true;
            else if (   (box1.Text == box5.Text) && (box1.Text == box9.Text) && (!box1.Enabled))
                thewinner = true;
            else if ((box3.Text == box5.Text) && (box3.Text == box7.Text) && (!box3.Enabled))
                thewinner = true;

            if (thewinner)
            {
                String playerwinner = "";
                if (playerturn)
                {
                    playerwinner = "O";
                }
                else
                {
                    playerwinner = "X";
                }
                MessageBox.Show("Player " + playerwinner + " wins!");
            }
            else
            {
                if (gameturn == 9)
                {
                    MessageBox.Show("It's a draw!");
                }
            }
        }
    }
}