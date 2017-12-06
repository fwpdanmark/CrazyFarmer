using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrazyFarmer
{
    public partial class MainPage : Form
    {
        
        private Settings GameSettings = new Settings();
        private Farmer farmer1 = new Farmer();
        private Graphics View;
        private Food food1;
      
        private bool right = false;
        private bool left = false;
        private bool up = false;
        private bool down = false;

        public MainPage()
        {

            InitializeComponent();
            MakeFoodObjects();
            StartGame();
            
        }

        public void StartGame()
        {
           
            ScoreINT.Text = GameSettings.Score.ToString();
            

       
        }

        private void FormMainPage_Paint(object sender, PaintEventArgs e)
        {
            View = e.Graphics;
            farmer1.DrawFarmer(View);
            food1.DrawFood(View);
        }

        private void MakeFoodObjects()
        {
            food1 = new Food();
        }

        private void CheckCollision()
        {
            if (farmer1.YPOS)
            {
                GameSettings.TickScore();
            }
        }

        private void FormMainPage_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Up)
            {
                up = true;
                left = false;
                right = false;
                down = false;
            }
            else if(e.KeyData == Keys.Down)
            {
                up = false;
                left = false;
                right = false;
                down = true;
            }
            else if (e.KeyData == Keys.Right)
            {
                up = false;
                left = false;
                right = true;
                down = false;
            }
            else if (e.KeyData == Keys.Left)
            {
                up = false;
                left = true;
                right = false;
                down = false;
            }

        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (up)
            {
                farmer1.MoveUp();

            }
            if (down)
            {
                farmer1.MoveDown();
            }
            if (left)
            {
                farmer1.MoveLeft();
            }
            if (right)
            {
                farmer1.MoveRight();
            }
            CheckCollision();
            ScoreINT.Text = GameSettings.Score.ToString();

            this.Invalidate();
        }

           

    }
}
