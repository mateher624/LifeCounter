using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace LifeCounter
{
    static class Style
    {
        static public int activePlayerId;

        static public Player[] playersArray = new Player[6];
        //static public string[] bgColor = new string[6];
        //static public UIColor[] textColor = new UIColor[6];

        static Style()
        {
            for (int i = 0; i < 6; i++)
            {
                Player player = new Player(0, "Player " + (i + 1).ToString(), "white2", UIColor.Black);
                playersArray[i] = player;
            }
        }
    }
}