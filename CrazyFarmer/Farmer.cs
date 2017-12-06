using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyFarmer
{
   public class Farmer
    {
        public Rectangle FarmerShape { get; set; }
        public int FarmerWidth { get; set; }
        public int  FarmerHeigth { get; set; }
        public Brush FarmerColor { get; set; }
        public int XPOS { get; set; }
        public int YPOS { get; set; }

        public Farmer()
        {
            FarmerWidth = 50;
            FarmerHeigth = 25;
            FarmerColor = Brushes.Crimson;
            XPOS = 150;
            YPOS = 150;
            FarmerShape = new Rectangle(XPOS,YPOS,FarmerWidth,FarmerHeigth);
        }

        public void DrawFarmer(Graphics g)
        {
            g.FillRectangle(FarmerColor,FarmerShape);
        }

     

        public void MoveUp()
        {
            YPOS = YPOS -= 10;
            FarmerShape = new Rectangle(XPOS, YPOS, FarmerWidth, FarmerHeigth);
        }

        public void MoveDown()
        {
            YPOS = YPOS += 10;
            FarmerShape = new Rectangle(XPOS, YPOS, FarmerWidth, FarmerHeigth);
            
        }

        public void MoveLeft()
        {
            XPOS = XPOS -= 10;
            FarmerShape = new Rectangle(XPOS, YPOS, FarmerWidth, FarmerHeigth);
        }

        public void MoveRight()
        {
            XPOS = XPOS += 10;
            FarmerShape = new Rectangle(XPOS, YPOS, FarmerWidth, FarmerHeigth);
        }
    }
}
