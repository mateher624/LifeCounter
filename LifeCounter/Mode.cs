using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace LifeCounter
{
    static class Mode
    {
        static private int playersMode;
        static private int startingLife;

        static public void SetPlayersMode(int mode)
        {
            playersMode = mode;
        }

        static public void SetStartingLife(int life)
        {
            startingLife = life;
        }

        static public int GetPlayersMode()
        {
            return playersMode;
        }

        static public int GetStartingLife()
        {
            return startingLife;
        }
    }
}