using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyFarmer
{
    class Settings
    {

        public int Score { get; set; }
        public int GameSpeed { get; set; }

        public Settings()
        {
            Score = 0;
            GameSpeed = 16;
        }

        public void TickScore()
        {
            Score++;
        }

    }
}
