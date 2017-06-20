using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace LifeCounter
{
    static class Life
    {
        static private int[] lifeTab = new int[6];

        public static void IncrementLife(int index, int amount)
        {
            lifeTab[index] = lifeTab[index] + amount;
        }

        public static void DecrementLife(int index, int amount)
        {
            lifeTab[index] = lifeTab[index] - amount;
        }

        public static int GetALife(int index)
        {
            return lifeTab[index];
        }

        public static void SetALife(int index, int amount)
        {
            lifeTab[index] = amount;
        }
    }
}