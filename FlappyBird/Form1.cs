using System;
using System.Threading;
using System.Windows.Forms;


namespace Flappy_Bird_Window_Form
{
    public partial class Form1 : Form
    {

        int pipeSpeed = 8;
        int gravitiy = 5;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
            //player.URL = "flappybirdmusic.mp3";
            //player.controls.play();

        }

        public void gameTimerEvent(object sender, EventArgs e)
        {

            flappyBird.Top += gravitiy;
            pipeButtom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreText.Text = "Score :  " + score;


            if (pipeButtom.Left < -50)
            {
                pipeButtom.Left = 800;
                score++;
            }

            if (pipeTop.Left < -180)
            {
                pipeTop.Left = 950;
                score++;
            }

            // If it overlaps each other , so end the game !!!
            if (flappyBird.Bounds.IntersectsWith(pipeButtom.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds) || flappyBird.Top < -25)
            {
                EndGame();
                //while (true)
                //{
                //    if (Console.ReadKey().Key == ConsoleKey.Spacebar)
                //    {
                //        Restart();
                //    }
                //}
            }

            if (score > 5)
            {
                pipeSpeed = 16;
            }


        }

        public void gameKeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravitiy = -15;

                if(!gameTimer.Enabled)
                {
                    Restart();
                }
            }

        }

        public void gameKeyIsUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                gravitiy = 15;

            }

        }




        public void EndGame()
        {
            gameTimer.Stop();
            scoreText.Text += "      Game Over !!!";

        }

        public void Restart()
        {


            //Dispose();

            //Thread.Sleep(2000);
            System.Windows.Forms.Application.Restart();

        }



    }
}
