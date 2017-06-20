using System;
using System.Collections.Generic;
using System.Text;
using UIKit;

namespace LifeCounter
{
    class Player
    {
        public int life = 0;
        public string name;
        public string bgColor;
        public UIColor textColor;

        public Player(int life, string name, string bgColor, UIColor textColor)
        {
            this.life = life;
            this.name = name;
            this.bgColor = bgColor;
            this.textColor = textColor;
        }
    }
}
