using Foundation;
using System;
using UIKit;

namespace LifeCounter
{
    public partial class NavigationController : UINavigationController
    {
        public NavigationController (IntPtr handle) : base (handle)
        {
        }

        public override bool ShouldAutorotate()
        {
            if (VisibleViewController is MainMenuController) return false;
            else if (VisibleViewController is PlayerSettingsViewController) return false;
            else return true;
        }
    }
}