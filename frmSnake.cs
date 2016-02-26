using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Atesat_v._1._1
{
    public partial class frmSnake : Form
    {
        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();

        public frmSnake()
        {
            InitializeComponent();

            //Set setings to default.
            new Settings();

            //Set game speed and start timer.
            gameTimer.Enabled = true;
            gameTimer.Interval = 1000 / Settings.Speed;
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();

            //Start new game
            StartGame();
        }

        private void StartGame()
        {
            pbCanvas.Visible = true;

            label1.Visible = true;
            lbScore.Visible = true;

            lbMonedeObt.Visible = false;
            lbMonedeTot.Visible = false;

            pbOk.Visible = false;
            pbMess.Visible = false;

            //Set setings to default.
            new Settings();

            //Create new player object.
            Snake.Clear();
            Circle head = new Circle();
            head.X = 12;
            head.Y = 3;
            Snake.Add(head);

            lbScore.Text = Settings.Score.ToString();
            GenerateFood();
        }

        //Place a random food object.
        private void GenerateFood()
        {
            int maxXPos = pbCanvas.Size.Width / Settings.Width;
            int maxYPos = pbCanvas.Size.Height / Settings.Height;

            Random random = new Random();
            food = new Circle();
            food.X = random.Next(0, maxXPos);
            food.Y = random.Next(0, maxYPos);
        }

        private void UpdateScreen(object sender, EventArgs e)
        {
            //Check for Game Over.
            if (Settings.GameOver == true)
            {
                //Check if Enter is pressed.
                if (Input.KeyPressed(Keys.Space))
                {
                    Input.ChangeState(Keys.Space, false);
                    if (Utilizator.bani >= 10)
                    {
                        Utilizator.bani -= 10;
                        StartGame();
                    }
                    else
                    {
                        MessageBox.Show("Nu aveti destule jetoane.");
                        this.Close();
                    }
                }
                else if (Input.KeyPressed(Keys.Escape))
                {
                    Input.ChangeState(Keys.Escape, false);
                    this.Close();
                }
            }
            else
            {
                if (Input.KeyPressed(Keys.Right) && Settings.direction != Direction.Left)
                    Settings.direction = Direction.Right;
                else if (Input.KeyPressed(Keys.Left) && Settings.direction != Direction.Right)
                    Settings.direction = Direction.Left;
                else if (Input.KeyPressed(Keys.Up) && Settings.direction != Direction.Down)
                    Settings.direction = Direction.Up;
                else if (Input.KeyPressed(Keys.Down) && Settings.direction != Direction.Up)
                    Settings.direction = Direction.Down;

                MovePlayer();
            }

            pbCanvas.Invalidate();
        }

        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            if (Settings.GameOver == false)
            {
                //Set color of snake.
                Brush snakeColor;

                //Draw snake.
                for (int i = 0; i < Snake.Count; i++)
                {
                    //Draw head.
                    if (i == 0)
                        snakeColor = Brushes.Black; //Head
                    else
                        snakeColor = Brushes.Green; //Rest of body

                    //Draw snake
                    canvas.FillRectangle(snakeColor,
                        new Rectangle(Snake[i].X * Settings.Width,
                                      Snake[i].Y * Settings.Height,
                                      Settings.Width, Settings.Height));

                    //Draw food
                    canvas.FillEllipse(Brushes.Red,
                        new Rectangle(food.X * Settings.Width,
                                      food.Y * Settings.Height,
                                      Settings.Height, Settings.Width));
                }
            }
            else
            {
                Utilizator.bani += Settings.Score;

                pbCanvas.Visible = false;
                label1.Visible = false;
                lbScore.Visible = false;

                lbMonedeObt.Visible = true;
                lbMonedeObt.Text = "Ati primit: " + Convert.ToString(Settings.Score);
                if (Settings.Score == 1) lbMonedeObt.Text += " moneda";
                else lbMonedeObt.Text += " monede";

                lbMonedeTot.Visible = true;
                lbMonedeTot.Text = "Credit nou: " + Convert.ToString(Utilizator.bani);
                if (Utilizator.bani == 1) lbMonedeTot.Text += " moneda";
                else lbMonedeTot.Text += " monede";

                pbOk.Visible = true;
                pbOk.Enabled = true;
            }
        }

        private void MovePlayer()
        {
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                //Move head
                if (i == 0)
                {
                    switch (Settings.direction)
                    {
                        case Direction.Right:
                            Snake[i].X++;
                            break;
                        case Direction.Left:
                            Snake[i].X--;
                            break;
                        case Direction.Up:
                            Snake[i].Y--;
                            break;
                        case Direction.Down:
                            Snake[i].Y++;
                            break;
                    }

                    //Get maximum X and Y Pos
                    int maxXPos = pbCanvas.Size.Width / Settings.Width;
                    int maxYPos = pbCanvas.Size.Height / Settings.Height;

                    //Detect collision with game borders
                    if (Snake[i].X < 0 || Snake[i].X >= maxXPos ||
                        Snake[i].Y < 0 || Snake[i].Y >= maxYPos)
                    {
                        Die();
                    }

                    //Detect collision with body
                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[0].X == Snake[j].X &&
                            Snake[0].Y == Snake[j].Y)
                        {
                            Die();
                            break;
                        }

                    }

                    //Detect collision with food
                    if (Snake[0].X == food.X && Snake[0].Y == food.Y)
                    {
                        Eat();
                    }
                }
                else
                {
                    //Move body
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
        }

        private void Eat()
        {
            //Add circle to body
            Circle food = new Circle();
            food.X = Snake[Snake.Count - 1].X;
            food.Y = Snake[Snake.Count - 1].Y;

            Snake.Add(food);

            //Update score and speed
            Settings.Score += Settings.Points;
            lbScore.Text = Settings.Score.ToString();

            GenerateFood();
        }

        private void Die()
        {
            Settings.GameOver = true;
        }

        private void frmSnake_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }

        private void frmSnake_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }

        private void pbOk_Click(object sender, EventArgs e)
        {
            lbMonedeObt.Visible = false;
            lbMonedeTot.Visible = false;
            pbOk.Visible = false;
            pbOk.Enabled = false;

            pbMess.Visible = true;
        }
    }
}
