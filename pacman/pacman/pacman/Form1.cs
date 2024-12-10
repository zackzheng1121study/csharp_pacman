namespace pacman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool up = false;
        bool down = false;
        bool left = false;
        bool right = false;
        bool[] iscoin = { false, false, false, false, false, false, false, false, false, false, false, false };
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 5;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            up = down = left = right = false;
            switch (e.KeyCode)
            {
                case Keys.Up:
                    up = true;
                    picman.Image = Image.FromFile("pacmanup.png");
                    break;

                case Keys.Down:
                    down = true;
                    picman.Image = Image.FromFile("pacmandown.png");
                    break;

                case Keys.Left:
                    left = true;
                    picman.Image = Image.FromFile("c.png");
                    break;

                case Keys.Right:
                    right = true;
                    picman.Image = Image.FromFile("pacman.png");
                    break;
            }
        }
        int score = 0;
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (up && picman.Location.Y > 59)
            {
                picman.Top -= 6;
            }
            else
            {
                up = false;
            }
            if (down && picman.Location.Y < 535)
            {
                picman.Top += 6;
            }
            else
            {
                down = false;
            }
            if (left && picman.Location.X > 32)
            {
                picman.Left -= 6;
            }
            else
            {
                left = false;
            }
            if (right && picman.Location.X < 928)
            {
                picman.Left += 6;
            }
            else
            {
                right = false;
            }




            if (picman.Bounds.IntersectsWith(con1.Bounds))
            {
                con1.Visible = false;
                if (!iscoin[0])
                {
                    score = score + 1;
                    iscoin[0] = true;
                }
            }
            if (picman.Bounds.IntersectsWith(con2.Bounds))
            {
                con2.Visible = false;
                if (!iscoin[1])
                {
                    score = score + 1;
                    iscoin[1] = true;
                }
            }
            if (picman.Bounds.IntersectsWith(con3.Bounds))
            {
                con3.Visible = false;
                if (!iscoin[2])
                {
                    score = score + 1;
                    iscoin[2] = true;
                }
            }
            if (picman.Bounds.IntersectsWith(con4.Bounds))
            {
                con4.Visible = false;
                if (!iscoin[3])
                {
                    score = score + 1;
                    iscoin[3] = true;
                }
            }
            if (picman.Bounds.IntersectsWith(con5.Bounds))
            {
                con5.Visible = false;
                if (!iscoin[4])
                {
                    score = score + 1;
                    iscoin[4] = true;
                }
            }
            if (picman.Bounds.IntersectsWith(con6.Bounds))
            {
                con6.Visible = false;
                if (!iscoin[5])
                {
                    score = score + 1;
                    iscoin[5] = true;
                }
            }
            if (picman.Bounds.IntersectsWith(con7.Bounds))
            {
                con7.Visible = false;
                if (!iscoin[6])
                {
                    score = score + 1;
                    iscoin[6] = true;
                }
            }
            if (picman.Bounds.IntersectsWith(con8.Bounds))
            {
                con8.Visible = false;
                if (!iscoin[7])
                {
                    score = score + 1;
                    iscoin[7] = true;
                }
                
            }
            if (picman.Bounds.IntersectsWith(con9.Bounds))
            {
                con9.Visible = false;
                if (!iscoin[8])
                {
                    score = score + 1;
                    iscoin[8] = true;
                }
            }
            if (picman.Bounds.IntersectsWith(con10.Bounds))
            {
                con10.Visible = false;
                if (!iscoin[9])
                {
                    score = score + 1;
                    iscoin[9] = true;
                }
            }
            if (picman.Bounds.IntersectsWith(con11.Bounds))
            {
                con11.Visible = false;
                if (!iscoin[10])
                {
                    score = score + 1;
                    iscoin[10] = true;
                }
            }
            if (picman.Bounds.IntersectsWith(con12.Bounds))
            {
                con12.Visible = false;
                if (!iscoin[11])
                {
                    score = score + 1;
                    iscoin[11] = true;
                }
            }
            label1.Text = "Score:" + score;
        }


    }
}