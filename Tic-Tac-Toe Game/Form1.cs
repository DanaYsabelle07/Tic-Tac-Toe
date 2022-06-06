namespace Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {
        string gameturn = "X";

        public Form1()
        {
            InitializeComponent();
        }

        private void box1_Click(object sender, EventArgs e)
        {
            box1.Text = gameturn;
            if (gameturn != "X")
            {
                gameturn = "X";
            }
            else
            {
                gameturn = "O";
            }
            box1.Enabled = false;
        }

        private void box2_Click(object sender, EventArgs e)
        {
            box2.Text = gameturn;
            if (gameturn != "X")
            {
                gameturn = "X";
            }
            else
            {
                gameturn = "O";
            }
        }

        private void box3_Click(object sender, EventArgs e)
        {
            box3.Text = gameturn;
            if (gameturn != "X")
            {
                gameturn = "X";
            }
            else
            {
                gameturn = "O";
            }
        }

        private void box4_Click(object sender, EventArgs e)
        {
            box4.Text = gameturn;
            if (gameturn != "X")
            {
                gameturn = "X";
            }
            else
            {
                gameturn = "O";
            }
        }

        private void box5_Click(object sender, EventArgs e)
        {
            box5.Text = gameturn;
            if (gameturn != "X")
            {
                gameturn = "X";
            }
            else
            {
                gameturn = "O";
            }
        }

        private void box6_Click(object sender, EventArgs e)
        {
            box6.Text = gameturn;
            if (gameturn != "X")
            {
                gameturn = "X";
            }
            else
            {
                gameturn = "O";
            }
        }

        private void box7_Click(object sender, EventArgs e)
        {
            box7.Text = gameturn;
            if (gameturn != "X")
            {
                gameturn = "X";
            }
            else
            {
                gameturn = "O";
            }
        }

        private void box8_Click(object sender, EventArgs e)
        {
            box8.Text = gameturn;
            if (gameturn != "X")
            {
                gameturn = "X";
            }
            else
            {
                gameturn = "O";
            }
        }

        private void box9_Click(object sender, EventArgs e)
        {
            box9.Text = gameturn;
            if (gameturn != "X")
            {
                gameturn = "X";
            }
            else
            {
                gameturn = "O";
            }
        }
    }
}