using DocumentFormat.OpenXml.Math;
using DocumentFormat.OpenXml;
using System;
using System.Drawing;
using System.IO;
using System.Reflection.Emit;
using System.Security.AccessControl;
using System.Windows.Forms;
using WMPLib;

namespace GameIn3Hours
{
    public partial class Form1 : Form
    {
       
        WindowsMediaPlayer backgroundSond;
        WindowsMediaPlayer weapondsSond;
        WindowsMediaPlayer fruitsExplodeSound;

        PictureBox[] stars;
        int backgroundSpeed;
        int ninjaSpeed;
        Random rnd;
        PictureBox imageControl;

        PictureBox[] weapons;
        int weaponsSpeed;

        PictureBox[] fruits;
        int fruitsSpeed;

        PictureBox fruitsShooter;
        int fruitsShooterSpeed;

        int score;
        int level;
        int dificulty;
        bool pause;
        bool gameOver;

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load1;
        }

        private void Form1_Load1(object sender, EventArgs e)
        {
                pause = false;
                gameOver = false;
                score = 0;
                level = 1;
                dificulty = 9;

                //fruits as enemies

                Image apple = Image.FromFile(@"C:\Users\pornc\Desktop\C\c#\GameIn3Hours\assets\apples.png");
                Image banana = Image.FromFile(@"C:\Users\pornc\Desktop\C\c#\GameIn3Hours\assets\banana.png");
                Image berry = Image.FromFile(@"C:\Users\pornc\Desktop\C\c#\GameIn3Hours\assets\berry.png");
                Image watermelon = Image.FromFile(@"C:\Users\pornc\Desktop\C\c#\GameIn3Hours\assets\watermelon.png");
                Image orange = Image.FromFile(@"C:\Users\pornc\Desktop\C\c#\GameIn3Hours\assets\orange.png");
                Image pear = Image.FromFile(@"C:\Users\pornc\Desktop\C\c#\GameIn3Hours\assets\pears.png");
                Image strawberry = Image.FromFile(@"C:\Users\pornc\Desktop\C\c#\GameIn3Hours\assets\strawsberry.png");
                Image peach = Image.FromFile(@"C:\Users\pornc\Desktop\C\c#\GameIn3Hours\assets\peach.png");
                Image pineapple = Image.FromFile(@"C:\Users\pornc\Desktop\C\c#\GameIn3Hours\assets\pineapple.png");
                Image kiwi = Image.FromFile(@"C:\Users\pornc\Desktop\C\c#\GameIn3Hours\assets\kiwi.png");
                Image bossChilly = Image.FromFile(@"C:\Users\pornc\Desktop\C\c#\GameIn3Hours\assets\chilly.png");
                Image bossGarlic = Image.FromFile(@"C:\Users\pornc\Desktop\C\c#\GameIn3Hours\assets\garlic.png");

                fruits = new PictureBox[12];
                fruitsSpeed = 5;

                for (int i = 0; i < fruits.Length; i++)
                {
                    fruits[i] = new PictureBox();
                    fruits[i].Size = new Size(35, 35);
                    fruits[i].SizeMode = PictureBoxSizeMode.Zoom;
                    fruits[i].BorderStyle = BorderStyle.None;
                    fruits[i].BackColor = Color.Transparent;
                    fruits[i].Visible = false;
                    this.Controls.Add(fruits[i]);
                    fruits[i].Location = new Point((i + 1) * 30, -30);
                }

                fruits[0].Image = apple;
                fruits[1].Image = banana;
                fruits[2].Image = berry;
                fruits[3].Image = watermelon;
                fruits[4].Image = orange;
                fruits[5].Image = pear;
                fruits[6].Image = strawberry;
                fruits[7].Image = peach;
                fruits[8].Image = pineapple;
                fruits[9].Image = kiwi;
                fruits[10].Image = bossChilly;
                fruits[11].Image = bossGarlic;

                //sound and SFX
                backgroundSond = new WindowsMediaPlayer();
                weapondsSond = new WindowsMediaPlayer();
                fruitsExplodeSound = new WindowsMediaPlayer();

                backgroundSond.URL = (@"C:\Users\pornc\Desktop\C\c#\GameIn3Hours\assets\BGmusic.mp3");
                weapondsSond.URL = (@"C:\Users\pornc\Desktop\C\c#\GameIn3Hours\assets\WeaponsMusic.mp3");
                fruitsExplodeSound.URL = (@"C:\Users\pornc\Desktop\C\c#\GameIn3Hours\assets\FruitsExplode.mp3");


                backgroundSond.settings.setMode("loop", true);
                backgroundSond.settings.volume = 10;
                weapondsSond.settings.volume = 4;
                fruitsExplodeSound.settings.volume = 6;

                backgroundSond.controls.play();

                //weapon of the ninja (I have a lot of typo on the weapons's function so beware!)
                weaponsSpeed = 30;
                weapons = new PictureBox[5];

                Image shuriken = Image.FromFile(@"C:\Users\pornc\Desktop\C\c#\GameIn3Hours\assets\shuriken.png");

                for (int i = 0; i < weapons.Length; i++)
                {
                    weapons[i] = new PictureBox();
                    weapons[i].Image = shuriken;
                    weapons[i].Size = new Size(20, 20);
                    weapons[i].SizeMode = PictureBoxSizeMode.Zoom;
                    weapons[i].BorderStyle = BorderStyle.None;
                    weapons[i].BackColor = Color.Transparent;
                    this.Controls.Add(weapons[i]);
                }

                //BG and stars
                backgroundSpeed = 4;
                ninjaSpeed = 8;
                stars = new PictureBox[15];
                rnd = new Random();

                for (int i = 0; i < stars.Length; i++)
                {
                    stars[i] = new PictureBox();
                    stars[i].BorderStyle = BorderStyle.None;
                    stars[i].Location = new Point(rnd.Next(20, 588), rnd.Next(-10, 400));

                    if (i % 3 == 1)
                    {
                        stars[i].Size = new Size(1, 1);
                        stars[i].BackColor = Color.White;

                    }
                    else
                    {
                        stars[i].Size = new Size(2, 2);
                        stars[i].BackColor = Color.Gray;
                    }
                    this.Controls.Add(stars[i]);
                }
                //fruits's weapons
                fruitsShooterSpeed = 5;
                fruitsShooter = new PictureBox();

                Image fruitShooter = Image.FromFile(@"C:\Users\pornc\Desktop\C\c#\GameIn3Hours\assets\FruitAmmo.png");

                for (int i = 0; i < 10; i++)
                {
                    fruitsShooter = new PictureBox();
                    fruitsShooter.Image = fruitShooter;
                    fruitsShooter.Size = new Size(12, 12);
                    fruitsShooter.SizeMode = PictureBoxSizeMode.Zoom;
                    fruitsShooter.BorderStyle = BorderStyle.None;
                    fruitsShooter.BackColor = Color.Transparent;
                    int x = rnd.Next(0, 10);
                    fruitsShooter.Location = new Point(fruits[x].Location.X + 12, fruits[x].Location.Y - 10);
                    this.Controls.Add(fruitsShooter);
                }

            }

        private void Timer1_Tick(object sender, EventArgs e)
            {
                for (int i = 0; i < stars.Length / 2; i++)
                {
                    stars[i].Top += backgroundSpeed;
                    if (stars[i].Top >= this.Height)
                    {
                        stars[i].Top = stars[i].Height;
                    }
                    for (i = stars.Length / 2; i < stars.Length; i++)
                    {
                        stars[i].Top += backgroundSpeed;
                        if (stars[i].Top >= this.Height)
                        {
                            stars[i].Top = stars[i].Height;
                        }
                    }
                }
            }

            private void Uptimer_Tick(object sender, EventArgs e)
            {
                if (Ninja.Top > 10)
                {
                    Ninja.Top -= ninjaSpeed;
                }
            }

            private void DownTimer_Tick(object sender, EventArgs e)
            {
                if (Ninja.Top < 270)
                {
                    Ninja.Top += ninjaSpeed;
                }
            }

            private void LeftTimer_Tick(object sender, EventArgs e)
            {
                if (Ninja.Left > 10)
                {
                    Ninja.Left -= ninjaSpeed;
                }
            }

            private void RightTimer_Tick(object sender, EventArgs e)
            {
                if (Ninja.Right < 400)
                {
                    Ninja.Left += ninjaSpeed;
                }

            }

            private void Form1_KeyDown(object sender, KeyEventArgs e)
            {
                if (!pause)
                {
                    if (e.KeyCode == Keys.Up)
                    {
                        UpTimer.Start();
                    }
                    if (e.KeyCode == Keys.Down)
                    {
                        DownTimer.Start();
                    }
                    if (e.KeyCode == Keys.Left)
                    {
                        LeftTimer.Start();
                    }
                    if (e.KeyCode == Keys.Right)
                    {
                        RightTimer.Start();
                    }
                }
            }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            UpTimer.Stop();
            DownTimer.Stop();
            LeftTimer.Stop();
            RightTimer.Stop();

            if (e.KeyCode == Keys.Space)
            {
                if (!gameOver)
                {
                    if (pause)
                    {
                        StartTimer();
                        GameOverLabel.Visible = false;
                        backgroundSond.controls.play();
                        pause = false;
                    }
                    else if (e.KeyCode == Keys.Space)
                    {
                        GameOverLabel.Visible = true;
                        GameOverLabel.Location = new Point(70, 90);
                        GameOverLabel.Text = "PAUSED";
                        backgroundSond.controls.pause();
                        StopTimer();
                        pause = true;
                    }

                }
            }
        }

            private void WepaonsMoveTimer_Tick(object sender, EventArgs e) //spelled wrong I know, I'm sorry
            {
                weapondsSond.controls.play();

                for (int i = 0; i < weapons.Length; i++)
                {
                    if (weapons[i].Top > 0)
                    {
                        weapons[i].Visible = true;
                        weapons[i].Top -= weaponsSpeed;

                        NinjaDamage();
                    }
                    else
                    {
                        weapons[i].Visible = false;
                        weapons[i].Location = new Point(Ninja.Location.X + 20, Ninja.Location.Y + 30);

                    }
                }

            }

            private void FruitsTimer_Tick(object sender, EventArgs e)
            {
                FruitsMove(fruits, fruitsSpeed);
            }
            private void FruitsMove(PictureBox[] array, int speed)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i].Visible = true;
                    array[i].Top += speed;

                    if (array[i].Top > this.Height)
                    {
                        array[i].Location = new Point((i + 1) * 50, -200);
                    }
                }
            }

            private void NinjaDamage()
            {
                for (int i = 0; i < fruits.Length; i++)
                {
                    if (weapons[0].Bounds.IntersectsWith(fruits[i].Bounds)
                     | weapons[1].Bounds.IntersectsWith(fruits[i].Bounds) || weapons[2].Bounds.IntersectsWith(fruits[i].Bounds))
                    {
                        fruitsExplodeSound.controls.play();

                        score += 1;
                        ShowScore.Text = (score < 10) ? "0" + score.ToString() : score.ToString();


                        if (score % 30 == 0)
                        {
                            level += 1;
                            ShowLevel.Text = (level < 10) ? "0" + level.ToString() : level.ToString();

                            if (fruitsSpeed <= 10 && fruitsShooterSpeed <= 10 && dificulty >= 0)
                            {
                                dificulty--;
                                fruitsSpeed++;
                                fruitsShooterSpeed++;
                            }
                            if (level == 20)
                            {
                                GameOver("You completed all the level! Well Done!");
                            }

                        }

                        fruits[i].Location = new Point((i + 1) * 50, -100);
                    }
                    if (Ninja.Bounds.IntersectsWith(fruits[i].Bounds))
                    {
                        fruitsExplodeSound.settings.volume = 6;
                        fruitsExplodeSound.controls.play();
                        Ninja.Visible = false;
                        weapondsSond.controls.stop();
                        GameOver("You Died");

                    }
                    if (Ninja.Bounds.IntersectsWith(fruitsShooter.Bounds))
                    {
                        FruitsDamage();
                    }
                }
            }

            private void GameOver(string str)
            {

                GameOverLabel.Text = str;
                GameOverLabel.Location = new Point(70, 90);
                GameOverLabel.Visible = true;
                Replay.Visible = true;
                Exit.Visible = true;

                backgroundSond.controls.stop();
                StopTimer();

            }
            private void StopTimer()
            {
                MoveBGTimer.Stop();
                FruitsTimer.Stop();
                WepaonsMoveTimer.Stop();
                FruitsShootTimer.Stop();
            }
            private void StartTimer()
            {
                MoveBGTimer.Start();
                FruitsTimer.Start();
                WepaonsMoveTimer.Start();
                FruitsShootTimer.Start();
            }

            private void FruitsShootTimer_Tick(object sender, EventArgs e)
            {
                for (int i = 0; i < 10 - dificulty; i++)
                {
                    if (fruitsShooter.Top < this.Height)
                    {
                        fruitsShooter.Visible = true;
                        fruitsShooter.Top += fruitsShooterSpeed;
                    }
                    else
                    {
                        fruitsShooter.Visible = false;
                        int x = rnd.Next(0, 10);
                        fruitsShooter.Location = new Point(fruits[x].Location.X + 20, fruits[x].Location.Y + 20);
                    }
                }
            }

            private void FruitsDamage()
            {
                bool died = false;
                int i = 10;
                if (Ninja.Visible)
                {
                    if (Ninja.Bounds.IntersectsWith(fruitsShooter.Bounds))
                    {
                        fruitsExplodeSound.settings.volume = 6;
                        fruitsExplodeSound.controls.play();
                        Ninja.Visible = false;
                        fruitsShooter.Visible = false;
                        weapondsSond.controls.stop();
                        GameOver("You Died");
                        died = true;
                    }

                }

            }

            private void Replay_Click(object sender, EventArgs e)
            {
                this.Controls.Clear();
                InitializeComponent();
                Form1_Load1(e, e);
            }

            private void Exit_Click(object sender, EventArgs e)
            {
                Environment.Exit(0);
            }
        }
    }


