using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Security.Cryptography;


namespace CrazyFarmer
{
    public class Food
    {
        Random rand = new Random();
        public Rectangle ShapeFood { get; set; }
        public Brush FoodColor{ get; set; }
        public int XPOS { get; set; }
        public int YPOS { get; set; }
        public int FoodWidth { get; set; }
        public int Foodheight { get; set; }


        public Food()
        {
             XPOS = rand.Next(50, 950);
             YPOS = rand.Next(50, 950);
             FoodWidth = 10;
             Foodheight = 10;
             FoodColor = Brushes.Coral;
             ShapeFood = new Rectangle(XPOS,YPOS, FoodWidth, Foodheight);
        }

        public void DrawFood(Graphics g)
        {
            g.FillRectangle(FoodColor, ShapeFood);
        }
    }
}
