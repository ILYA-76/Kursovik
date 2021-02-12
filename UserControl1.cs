using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Security;
namespace AppCSharp
{
    public partial class UserControl1 : UserControl
    {
        public bool g = true;
        public int i = 0,u;
        private int score1 = 0, score2 = 0;
        private int z = 1;

        private Button[,] buttons = new Button[3, 3];
        private int player, bot;
        public UserControl1()
        {

            InitializeComponent();
            this.Height = 850;
            this.Width = 1050;
            player = 1;

            label2.Text = ($"Противник: {score1}");
            label3.Text = ($"Вы: {score2}");
            for (int i = 0; i < buttons.Length / 3; i++)
            {
                for (int j = 0; j < buttons.Length / 3; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Size = new Size(250, 250);
                }
            }
            setButtons();

        }

        private void Bot()
        {
            if (buttons[0, 0].Text == buttons[0, 1].Text && buttons[0, 1].Text != "" && buttons[0, 2].Text != "x" && buttons[0, 2].Text != "o")
            {
                buttons[0, 2].Enabled = false; buttons[0, 2].Text = "o";
            }
            else
            {


                if (buttons[1, 0].Text == buttons[1, 1].Text && buttons[1, 0].Text != "" && buttons[1, 2].Text != "x" && buttons[1, 2].Text != "o")
                {
                    buttons[1, 2].Enabled = false; buttons[1, 2].Text = "o";
                }
                else
                {


                    if (buttons[2, 0].Text == buttons[2, 1].Text && buttons[2, 0].Text != "" && buttons[2, 2].Text != "x" && buttons[2, 2].Text != "o")
                    {
                        buttons[2, 2].Enabled = false; buttons[2, 2].Text = "o";
                    }
                    else
                    {


                        if (buttons[0, 0].Text == buttons[1, 0].Text && buttons[0, 0].Text != "" && buttons[2, 0].Text != "x" && buttons[2, 0].Text != "o")
                        {
                            buttons[2, 0].Enabled = false; buttons[2, 0].Text = "o";
                        }
                        else
                        {


                            if (buttons[0, 1].Text == buttons[1, 1].Text && buttons[0, 1].Text != "" && buttons[2, 1].Text != "x" && buttons[2, 1].Text != "o")
                            {
                                buttons[2, 1].Enabled = false; buttons[2, 1].Text = "o";
                            }
                            else
                            {


                                if (buttons[0, 2].Text == buttons[1, 2].Text && buttons[0, 2].Text != "" && buttons[2, 2].Text != "x" && buttons[2, 2].Text != "o")
                                {
                                    buttons[2, 2].Enabled = false; buttons[2, 2].Text = "o";
                                }
                                else
                                {


                                    if (buttons[0, 0].Text == buttons[1, 1].Text && buttons[0, 0].Text != "" && buttons[2, 2].Text != "x" && buttons[2, 2].Text != "o")
                                    {
                                        buttons[2, 2].Enabled = false; buttons[2, 2].Text = "o";
                                    }
                                    else
                                    {


                                        if (buttons[2, 0].Text == buttons[1, 1].Text && buttons[2, 0].Text != "" && buttons[0, 2].Text != "x" && buttons[0, 2].Text != "o")
                                        {
                                            buttons[0, 2].Enabled = false; buttons[0, 2].Text = "o";
                                        }
                                        else
                                        {



                                            if (buttons[0, 1].Text == buttons[0, 2].Text && buttons[0, 1].Text != "" && buttons[0, 0].Text != "x" && buttons[0, 0].Text != "o")
                                            {
                                                buttons[0, 0].Enabled = false; buttons[0, 0].Text = "o";
                                            }
                                            else
                                            {


                                                if (buttons[1, 1].Text == buttons[1, 2].Text && buttons[1, 1].Text != "" && buttons[1, 0].Text != "x" && buttons[1, 0].Text != "o")
                                                {
                                                    buttons[1, 0].Enabled = false; buttons[1, 0].Text = "o";
                                                }
                                                else
                                                {
                                                    if (buttons[2, 1].Text == buttons[2, 2].Text && buttons[2, 1].Text != "" && buttons[2, 0].Text != "x" && buttons[2, 0].Text != "o")
                                                    {
                                                        buttons[2, 0].Enabled = false; buttons[2, 0].Text = "o";
                                                    }
                                                    else
                                                    {
                                                        if (buttons[1, 0].Text == buttons[2, 0].Text && buttons[1, 0].Text != "" && buttons[0, 0].Text != "x" && buttons[0, 0].Text != "o")
                                                        {
                                                            buttons[0, 0].Enabled = false; buttons[0, 0].Text = "o";
                                                        }
                                                        else
                                                        {
                                                            if (buttons[1, 1].Text == buttons[2, 1].Text && buttons[1, 1].Text != "" && buttons[0, 1].Text != "x" && buttons[0, 1].Text != "o")
                                                            {
                                                                buttons[0, 1].Enabled = false; buttons[0, 1].Text = "o";
                                                            }
                                                            else
                                                            {
                                                                if (buttons[1, 2].Text == buttons[2, 2].Text && buttons[1, 2].Text != "" && buttons[0, 2].Text != "x" && buttons[0, 2].Text != "o")
                                                                {
                                                                    buttons[0, 2].Enabled = false; buttons[0, 2].Text = "o";
                                                                }
                                                                else
                                                                {
                                                                    if (buttons[1, 1].Text == buttons[2, 2].Text && buttons[1, 1].Text != "" && buttons[0, 0].Text != "x" && buttons[0, 0].Text != "o")
                                                                    {
                                                                        buttons[0, 0].Enabled = false; buttons[0, 0].Text = "o";
                                                                    }
                                                                    else
                                                                    {
                                                                        if (buttons[1, 1].Text == buttons[0, 2].Text && buttons[1, 1].Text != "" && buttons[2, 0].Text != "x" && buttons[2, 0].Text != "o")
                                                                        {
                                                                            buttons[2, 0].Enabled = false; buttons[2, 0].Text = "o";
                                                                        }
                                                                        else
                                                                        {



                                                                            if (buttons[0, 0].Text == buttons[0, 2].Text && buttons[0, 0].Text != "" && buttons[0, 1].Text != "x" && buttons[0, 1].Text != "o")
                                                                            {
                                                                                buttons[0, 1].Enabled = false; buttons[0, 1].Text = "o";
                                                                            }
                                                                            else
                                                                            {

                                                                                if (buttons[1, 0].Text == buttons[1, 2].Text && buttons[1, 0].Text != "" && buttons[1, 1].Text != "x" && buttons[1, 1].Text != "o")
                                                                                {
                                                                                    buttons[1, 1].Enabled = false; buttons[1, 1].Text = "o";
                                                                                }
                                                                                else
                                                                                {

                                                                                    if (buttons[2, 0].Text == buttons[2, 2].Text && buttons[2, 0].Text != "" && buttons[2, 1].Text != "x" && buttons[2, 1].Text != "o")
                                                                                    {
                                                                                        buttons[2, 1].Enabled = false; buttons[2, 1].Text = "o";
                                                                                    }
                                                                                    else
                                                                                    {

                                                                                        if (buttons[0, 0].Text == buttons[2, 0].Text && buttons[0, 0].Text != "" && buttons[1, 0].Text != "x" && buttons[1, 0].Text != "o")
                                                                                        {
                                                                                            buttons[1, 0].Enabled = false; buttons[1, 0].Text = "o";
                                                                                        }
                                                                                        else
                                                                                        {

                                                                                            if (buttons[0, 1].Text == buttons[2, 1].Text && buttons[0, 1].Text != "" && buttons[1, 1].Text != "x" && buttons[1, 1].Text != "o")
                                                                                            {
                                                                                                buttons[1, 1].Enabled = false; buttons[1, 1].Text = "o";
                                                                                            }
                                                                                            else
                                                                                            {

                                                                                                if (buttons[0, 2].Text == buttons[2, 2].Text && buttons[0, 2].Text != "" && buttons[1, 2].Text != "x" && buttons[1, 2].Text != "o")
                                                                                                {
                                                                                                    buttons[1, 2].Enabled = false; buttons[1, 2].Text = "o";
                                                                                                }
                                                                                                else
                                                                                                {

                                                                                                    if (buttons[0, 0].Text == buttons[2, 2].Text && buttons[0, 0].Text != "" && buttons[1, 1].Text != "x" && buttons[1, 1].Text != "o")
                                                                                                    {
                                                                                                        buttons[1, 1].Enabled = false; buttons[1, 1].Text = "o";
                                                                                                    }
                                                                                                    else
                                                                                                    {

                                                                                                        if (buttons[2, 0].Text == buttons[0, 2].Text && buttons[2, 0].Text != "" && buttons[1, 1].Text != "x" && buttons[1, 1].Text != "o")
                                                                                                        {
                                                                                                            buttons[1, 1].Enabled = false; buttons[1, 1].Text = "o";
                                                                                                        }
                                                                                                        else
                                                                                                        {






                                                                                                            if (buttons[1, 1].Text == "")
                                                                                                            {
                                                                                                                buttons[1, 1].Enabled = false; buttons[1, 1].Text = "o";
                                                                                                            }
                                                                                                            else
                                                                                                            {

                                                                                                                if (buttons[0, 0].Text == "")
                                                                                                                {
                                                                                                                    buttons[0, 0].Enabled = false; buttons[0, 0].Text = "o";
                                                                                                                }
                                                                                                                else
                                                                                                                {
                                                                                                                    if (buttons[0, 2].Text != "x" && buttons[0, 2].Text != "o")
                                                                                                                    {
                                                                                                                        buttons[0, 2].Enabled = false; buttons[0, 2].Text = "o";
                                                                                                                    }
                                                                                                                    else
                                                                                                                    {
                                                                                                                        if (buttons[2, 2].Text == "")
                                                                                                                        {
                                                                                                                            buttons[2, 2].Enabled = false; buttons[2, 2].Text = "o";
                                                                                                                        }
                                                                                                                        else
                                                                                                                        {
                                                                                                                            if (buttons[2, 0].Text != "x" && buttons[2, 0].Text != "o")
                                                                                                                            {
                                                                                                                                buttons[2, 0].Enabled = false; buttons[2, 0].Text = "o";
                                                                                                                            }
                                                                                                                            else
                                                                                                                            {
                                                                                                                                if (buttons[0, 1].Text == "")
                                                                                                                                {
                                                                                                                                    buttons[0, 1].Enabled = false; buttons[0, 1].Text = "o";
                                                                                                                                }
                                                                                                                                else
                                                                                                                                {
                                                                                                                                    if (buttons[1, 2].Text != "x" && buttons[1, 2].Text != "o")
                                                                                                                                    {
                                                                                                                                        buttons[1, 2].Enabled = false; buttons[1, 2].Text = "o";
                                                                                                                                    }
                                                                                                                                    else
                                                                                                                                    {
                                                                                                                                        if (buttons[2, 1].Text != "x" && buttons[2, 1].Text != "o")
                                                                                                                                        {
                                                                                                                                            buttons[2, 1].Enabled = false; buttons[2, 1].Text = "o";
                                                                                                                                        }
                                                                                                                                        else
                                                                                                                                        {
                                                                                                                                            if (buttons[1, 0].Text == "")
                                                                                                                                            {
                                                                                                                                                buttons[1, 0].Enabled = false; buttons[1, 0].Text = "o";
                                                                                                                                            }
                                                                                                                                            else
                                                                                                                                            {

                                                                                                                                            }
                                                                                                                                        }
                                                                                                                                    }
                                                                                                                                }
                                                                                                                            }
                                                                                                                        }
                                                                                                                    }
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void setButtons()
        {

            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        buttons[i, j].Location = new Point(12 + 248 * j, 12 + 248 * i);
                        buttons[i, j].Click += buttonbot_Click;
                        buttons[i, j].Font = new Font(new FontFamily("Microsoft Sans Serif"), 138);
                        buttons[i, j].Text = "";
                        this.Controls.Add(buttons[i, j]);
                    }
                }
            }
        }







        private void buttonbot_Click(object sender, EventArgs e)
        {
          
                sender.GetType().GetProperty("Text").SetValue(sender, "x");
                Bot();
            
            sender.GetType().GetProperty("Enabled").SetValue(sender, false);
                checkWin();
            return;


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkWin()
        {

            if (buttons[0, 0].Text == buttons[0, 1].Text && buttons[0, 1].Text == buttons[0, 2].Text)
            {
                if (buttons[0, 0].Text != "")
                {
                    MessageBox.Show($"Победил противник");
                    Scores();
                    return;
                }
            }
            if (buttons[1, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[1, 2].Text)
            {
                if (buttons[1, 0].Text != "")
                {
                    MessageBox.Show($"Победил противник");
                    Scores();
                    return;
                }
            }
            if (buttons[2, 0].Text == buttons[2, 1].Text && buttons[2, 1].Text == buttons[2, 2].Text)
            {
                if (buttons[2, 0].Text != "")
                {
                    MessageBox.Show($"Победил противник");
                    Scores();
                    return;
                }
            }
            if (buttons[0, 0].Text == buttons[1, 0].Text && buttons[1, 0].Text == buttons[2, 0].Text)
            {
                if (buttons[0, 0].Text != "")
                {
                    MessageBox.Show($"Победил противник");
                    Scores();
                    return;
                }
            }
            if (buttons[0, 1].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 1].Text)
            {
                if (buttons[0, 1].Text != "")
                {
                    MessageBox.Show($"Победил противник");
                    Scores();
                    return;
                }
            }
            if (buttons[0, 2].Text == buttons[1, 2].Text && buttons[1, 2].Text == buttons[2, 2].Text)
            {
                if (buttons[0, 2].Text != "")
                {
                    MessageBox.Show($"Победил противник");
                    Scores();
                    return;
                }
            }
            if (buttons[0, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 2].Text)
            {
                if (buttons[0, 0].Text != "")
                {
                    MessageBox.Show($"Победил противник");
                    Scores();
                    return;
                }
            }
            if (buttons[2, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[0, 2].Text)
            {
                if (buttons[2, 0].Text != "")
                {
                    MessageBox.Show($"Победил противник");
                    Scores();

                    return;
                }
            }


        }



       
        private void Scores()
        {
            if (z == 1)
                score1 += 1;
            if (z == 2)
                score2 += 1;
            label2.Text = ($"Противник: {score1}");
            label3.Text = ($"Вы: {score2}");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j].Enabled = false;

                }
            }
            
        }
        


        private void button1_Click_1(object sender, EventArgs e)
        {
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        buttons[i, j].Location = new Point(12 + 248 * j, 12 + 248 * i);

                        buttons[i, j].Font = new Font(new FontFamily("Microsoft Sans Serif"), 138);
                        buttons[i, j].Text = "";
                        this.Controls.Add(buttons[i, j]);
                        buttons[i, j].Enabled = true;
                    }
                }
            }
          

        }

    }

    }