using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WF_TicTacToe
{
    public partial class SinglePlay : Form
    {
        string state = "";
        string winner = "";
        int counter = 1;
        public SinglePlay(string state)
        {
            InitializeComponent();
            this.state = state;
            pictureBox4.Visible = true;
            //mouseenter
            r1.MouseEnter += (sender, e) => hoverAll(sender, e, r1);
            r2.MouseEnter += (sender2, e2) => hoverAll(sender2, e2, r2);
            r3.MouseEnter += (sender2, e2) => hoverAll(sender2, e2, r3);
            r4.MouseEnter += (sender2, e2) => hoverAll(sender2, e2, r4);
            r5.MouseEnter += (sender2, e2) => hoverAll(sender2, e2, r5);
            r6.MouseEnter += (sender2, e2) => hoverAll(sender2, e2, r6);
            r7.MouseEnter += (sender2, e2) => hoverAll(sender2, e2, r7);
            r8.MouseEnter += (sender2, e2) => hoverAll(sender2, e2, r8);
            r9.MouseEnter += (sender2, e2) => hoverAll(sender2, e2, r9);
            //////mouseleave
            r1.MouseLeave += (sender, e) => leaveAll(sender, e, r1);
            r2.MouseLeave += (sender2, e2) => leaveAll(sender2, e2, r2);
            r3.MouseLeave += (sender2, e2) => leaveAll(sender2, e2, r3);
            r4.MouseLeave += (sender2, e2) => leaveAll(sender2, e2, r4);
            r5.MouseLeave += (sender2, e2) => leaveAll(sender2, e2, r5);
            r6.MouseLeave += (sender2, e2) => leaveAll(sender2, e2, r6);
            r7.MouseLeave += (sender2, e2) => leaveAll(sender2, e2, r7);
            r8.MouseLeave += (sender2, e2) => leaveAll(sender2, e2, r8);
            r9.MouseLeave += (sender2, e2) => leaveAll(sender2, e2, r9);
            ///mouseclick
            r1.MouseClick += (sender, e) => clickAll(sender, e, r1);
            r2.MouseClick += (sender2, e2) => clickAll(sender2, e2, r2);
            r3.MouseClick += (sender2, e2) => clickAll(sender2, e2, r3);
            r4.MouseClick += (sender2, e2) => clickAll(sender2, e2, r4);
            r5.MouseClick += (sender2, e2) => clickAll(sender2, e2, r5);
            r6.MouseClick += (sender2, e2) => clickAll(sender2, e2, r6);
            r7.MouseClick += (sender2, e2) => clickAll(sender2, e2, r7);
            r8.MouseClick += (sender2, e2) => clickAll(sender2, e2, r8);
            r9.MouseClick += (sender2, e2) => clickAll(sender2, e2, r9);


            PictureBox[] arr = { r1, r2, r3, r4, r5, r6, r7, r8, r9 };
            foreach (PictureBox i in arr)
            {

                i.Tag = "";

            }
        }
        private void easyLevel()
        {
            List<PictureBox> enabledpics = new List<PictureBox>();
            PictureBox[] arr = { r1, r2, r3, r4, r5, r6, r7, r8, r9 };
            foreach (PictureBox i in arr)
            {

                if (i.Enabled)
                {
                    enabledpics.Add(i);
                }
            }
            Random rand = new Random();
            int x = rand.Next(0, enabledpics.Count);
            Bitmap opimg = new Bitmap(WF_TicTacToe.Properties.Resources._734552);
            enabledpics.ElementAt(x).Image = opimg;
            enabledpics.ElementAt(x).Tag = "O";
            enabledpics.ElementAt(x).Enabled = false;
        }
        private void mediumLevel()
        {

            Random rand = new Random();
            int x = rand.Next(0, 2);
            if (x == 1)
            {

                hardLevel();
            }
            else
            {
                easyLevel();
            }

        }
        private void hardLevel()
        {
            List<PictureBox> enabledpics = new List<PictureBox>();
            PictureBox[] arr = { r1, r2, r3, r4, r5, r6, r7, r8, r9 };
            foreach (PictureBox i in arr)
            {

                if (i.Enabled)
                {
                    enabledpics.Add(i);
                }
            }
            int tries = 0;
            while (true)
            {
                tries++;
                if (tries > 2000)
                {
                    easyLevel(); break;
                }
                Random rand = new Random();
                int x = rand.Next(0, enabledpics.Count);
                Bitmap opimg = new Bitmap(WF_TicTacToe.Properties.Resources._734552);
                enabledpics.ElementAt(x).Tag = "x";

                if (winnerCheck())
                {
                    enabledpics.ElementAt(x).Image = opimg;
                    enabledpics.ElementAt(x).Tag = "O";
                    winner = "";

                }
                else
                {
                    enabledpics.ElementAt(x).Tag = "O";
                    if (winnerCheck())
                    {
                        enabledpics.ElementAt(x).Image = opimg;
                        enabledpics.ElementAt(x).Tag = "O";
                        winner = "O";
                        enabledpics.ElementAt(x).Enabled = false;
                        Bitmap lose = new Bitmap(WF_TicTacToe.Properties.Resources.fail_background);
                        pictureBox3.Image = lose;
                        pictureBox3.Visible = true;
                        button1.Visible = true;
                        return;
                    }

                    enabledpics.ElementAt(x).Tag = "";
                    continue;
                }

                enabledpics.ElementAt(x).Enabled = false;
                break;
            }


        }


        private void leaveAll(object sender, EventArgs e, PictureBox p)
        {
            if (p.Enabled) { p.Image = null; }

        }
        private bool winnerCheck()
        {

            if ((r1.Tag.ToString() == "O" && r2.Tag.ToString() == "O" && r3.Tag.ToString() == "O") ||
                (r4.Tag.ToString() == "O" && r5.Tag.ToString() == "O" && r6.Tag.ToString() == "O") ||
                 (r7.Tag.ToString() == "O" && r8.Tag.ToString() == "O" && r9.Tag.ToString() == "O") ||
                  (r1.Tag.ToString() == "O" && r4.Tag.ToString() == "O" && r7.Tag.ToString() == "O") ||
                   (r2.Tag.ToString() == "O" && r5.Tag.ToString() == "O" && r8.Tag.ToString() == "O") ||
                    (r3.Tag.ToString() == "O" && r6.Tag.ToString() == "O" && r9.Tag.ToString() == "O") ||
                (r3.Tag.ToString() == "O" && r5.Tag.ToString() == "O" && r7.Tag.ToString() == "O") ||
                (r1.Tag.ToString() == "O" && r5.Tag.ToString() == "O" && r9.Tag.ToString() == "O"))
            {
                winner = "O";
                return true;

            }
            else if ((r1.Tag.ToString() == "x" && r2.Tag.ToString() == "x" && r3.Tag.ToString() == "x") ||
                (r4.Tag.ToString() == "x" && r5.Tag.ToString() == "x" && r6.Tag.ToString() == "x") ||
                 (r7.Tag.ToString() == "x" && r8.Tag.ToString() == "x" && r9.Tag.ToString() == "x") ||
                  (r1.Tag.ToString() == "x" && r4.Tag.ToString() == "x" && r7.Tag.ToString() == "x") ||
                   (r2.Tag.ToString() == "x" && r5.Tag.ToString() == "x" && r8.Tag.ToString() == "x") ||
                    (r3.Tag.ToString() == "x" && r6.Tag.ToString() == "x" && r9.Tag.ToString() == "x") ||
                (r3.Tag.ToString() == "x" && r5.Tag.ToString() == "x" && r7.Tag.ToString() == "x") ||
                (r1.Tag.ToString() == "x" && r5.Tag.ToString() == "x" && r9.Tag.ToString() == "x"))
            {
                winner = "X";
                return true;

            }
            return false;
        }


        private void clickAll(object sender, EventArgs e, PictureBox p)
        {

            if (p.Enabled)
            {
                if (counter % 2 == 0)
                {
                    Bitmap opimg = new Bitmap(WF_TicTacToe.Properties.Resources._734552);
                    p.Image = opimg;
                    p.Tag = "O";

                }
                else
                {
                    Bitmap xopimg = new Bitmap(WF_TicTacToe.Properties.Resources._361px_Redx2_svg);
                    p.Image = xopimg;
                    p.Tag = "x";
                }
            }
            p.Enabled = false;

            if (winnerCheck())
            {
                pictureBox3.Visible = true;
                button1.Visible = true;
                return;
            }
            if (drawCheck())
            { return; }

            if (this.state == "easy")
            {
                easyLevel();
                if (winnerCheck())
                {
                    //need loser png pic if he lose
                    if (winner == "O")
                    {
                        Bitmap lose = new Bitmap(WF_TicTacToe.Properties.Resources.fail_background);
                        pictureBox3.Image = lose;
                        pictureBox3.Visible = true;
                        button1.Visible = true;
                        winner = "";
                        return;
                    }
                    pictureBox3.Visible = true;
                    button1.Visible = true;
                    return;
                }

            }
            else if (this.state == "medium")
            {

                mediumLevel();

                if (winnerCheck())
                {
                    if (winner == "O")
                    {
                        Bitmap lose = new Bitmap(WF_TicTacToe.Properties.Resources.fail_background);
                        pictureBox3.Image = lose;
                        pictureBox3.Visible = true;
                        button1.Visible = true;
                        winner = "";
                        return;
                    }
                    //need loser png pic if he lose
                    pictureBox3.Visible = true;
                    button1.Visible = true;
                    return;
                }
            }
            else if (this.state == "hard")
            {

                hardLevel();

                if (winnerCheck())
                {
                    if (winner == "O")
                    {
                        Bitmap lose = new Bitmap(WF_TicTacToe.Properties.Resources.fail_background);
                        pictureBox3.Image = lose;
                        pictureBox3.Visible = true;
                        button1.Visible = true;
                        winner = "";
                        return;
                    }
                    //need loser png pic if he lose
                    pictureBox3.Visible = true;
                    button1.Visible = true;
                    return;
                }
            }
            if (drawCheck())
            { return; }

        }
        private bool drawCheck()
        {
            List<PictureBox> enabledPics = new List<PictureBox>();
            PictureBox[] arr = { r1, r2, r3, r4, r5, r6, r7, r8, r9 };
            foreach (PictureBox i in arr)
            {

                if (i.Enabled)
                {
                    enabledPics.Add(i);
                }
            }
            if (enabledPics.Count == 0)
            {
                Bitmap drawimg = new Bitmap(WF_TicTacToe.Properties.Resources.source);
                pictureBox3.Image = drawimg;
                pictureBox3.Visible = true;
                button1.Visible = true;
                return true;


            }
            return false;
        }

        private void hoverAll(object sender, EventArgs e, PictureBox p)
        {

            if (p.Enabled)
            {
                if (counter % 2 == 0)
                {
                    Bitmap opimg = new Bitmap(WF_TicTacToe.Properties.Resources._734552_op);
                    p.Image = opimg;

                }
                else
                {
                    Bitmap xopimg = new Bitmap(WF_TicTacToe.Properties.Resources.x_op);
                    p.Image = xopimg;
                }
            }

        }

        private void SinglePlay_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            counter = 1;
            winner = "";
            Bitmap winnerPic = new Bitmap(WF_TicTacToe.Properties.Resources.big_win);

            pictureBox3.Image = winnerPic;

            PictureBox[] arr = { r1, r2, r3, r4, r5, r6, r7, r8, r9 };

            foreach (PictureBox i in arr)
            {
                i.Tag = "";
                i.Enabled = true;
                i.Image = null;
            }
            pictureBox3.Visible = false;

            button1.Visible = false;
        }
    }
}

