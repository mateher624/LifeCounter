using Foundation;
using System;
using UIKit;

namespace LifeCounter
{
    public partial class MainMenuController : UIViewController
    {
        public MainMenuController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            //ButtonPlayers1.Select(this);
            UnsetModeButtons();
            ButtonPlayers1.SetBackgroundImage(UIImage.FromBundle("Assets/button_bg_2x2.png"), UIControlState.Normal);
            ButtonPlayers1.SetTitleColor(UIColor.White, UIControlState.Normal);
            Mode.SetPlayersMode(1);
        
            UnsetLifeButtons();
            ButtonLife20.SetBackgroundImage(UIImage.FromBundle("Assets/button_bg_3x2.png"), UIControlState.Normal);
            ButtonLife20.SetTitleColor(UIColor.White, UIControlState.Normal);
            Mode.SetStartingLife(20);  
        }

        public override bool ShouldAutorotate()
        {
            return false;
        }

        void UnsetModeButtons()
        {
            ButtonPlayers1.SetBackgroundImage(UIImage.FromBundle("Assets/button_bg_inactive_2x2.png"), UIControlState.Normal);
            ButtonPlayers1.SetTitleColor(UIColor.DarkGray, UIControlState.Normal);
            ButtonPlayers2.SetBackgroundImage(UIImage.FromBundle("Assets/button_bg_inactive_2x2.png"), UIControlState.Normal);
            ButtonPlayers2.SetTitleColor(UIColor.DarkGray, UIControlState.Normal);
            ButtonPlayers3.SetBackgroundImage(UIImage.FromBundle("Assets/button_bg_inactive_2x2.png"), UIControlState.Normal);
            ButtonPlayers3.SetTitleColor(UIColor.DarkGray, UIControlState.Normal);
            ButtonPlayers4.SetBackgroundImage(UIImage.FromBundle("Assets/button_bg_inactive_2x2.png"), UIControlState.Normal);
            ButtonPlayers4.SetTitleColor(UIColor.DarkGray, UIControlState.Normal);
            ButtonPlayers6.SetBackgroundImage(UIImage.FromBundle("Assets/button_bg_inactive_2x2.png"), UIControlState.Normal);
            ButtonPlayers6.SetTitleColor(UIColor.DarkGray, UIControlState.Normal);
            ButtonPlayersA.SetBackgroundImage(UIImage.FromBundle("Assets/button_bg_inactive_10x2.png"), UIControlState.Normal);
            ButtonPlayersA.SetTitleColor(UIColor.DarkGray, UIControlState.Normal);
        }

        void UnsetLifeButtons()
        {
            ButtonLife20.SetBackgroundImage(UIImage.FromBundle("Assets/button_bg_inactive_3x2.png"), UIControlState.Normal);
            ButtonLife20.SetTitleColor(UIColor.DarkGray, UIControlState.Normal);
            ButtonLife30.SetBackgroundImage(UIImage.FromBundle("Assets/button_bg_inactive_3x2.png"), UIControlState.Normal);
            ButtonLife30.SetTitleColor(UIColor.DarkGray, UIControlState.Normal);
            ButtonLife40.SetBackgroundImage(UIImage.FromBundle("Assets/button_bg_inactive_3x2.png"), UIControlState.Normal);
            ButtonLife40.SetTitleColor(UIColor.DarkGray, UIControlState.Normal);
            ButtonLifeCustom.SetBackgroundImage(UIImage.FromBundle("Assets/button_bg_inactive_3x2.png"), UIControlState.Normal);
            ButtonLifeCustom.SetTitleColor(UIColor.DarkGray, UIControlState.Normal);
        }

        partial void ButtonPlayers1_TouchUpInside(UIButton sender)
        {
            UnsetModeButtons();
            ButtonPlayers1.SetBackgroundImage(UIImage.FromBundle("Assets/button_bg_2x2.png"), UIControlState.Normal);
            ButtonPlayers1.SetTitleColor(UIColor.White, UIControlState.Normal);
            Mode.SetPlayersMode(1);
        }

        partial void ButtonPlayers2_TouchUpInside(UIButton sender)
        {
            UnsetModeButtons();
            ButtonPlayers2.SetBackgroundImage(UIImage.FromBundle("Assets/button_bg_2x2.png"), UIControlState.Normal);
            ButtonPlayers2.SetTitleColor(UIColor.White, UIControlState.Normal);
            Mode.SetPlayersMode(2);
        }

        partial void ButtonPlayers3_TouchUpInside(UIButton sender)
        {
            UnsetModeButtons();
            ButtonPlayers3.SetBackgroundImage(UIImage.FromBundle("Assets/button_bg_2x2.png"), UIControlState.Normal);
            ButtonPlayers3.SetTitleColor(UIColor.White, UIControlState.Normal);
            Mode.SetPlayersMode(3);
        }

        partial void ButtonPlayers4_TouchUpInside(UIButton sender)
        {
            UnsetModeButtons();
            ButtonPlayers4.SetBackgroundImage(UIImage.FromBundle("Assets/button_bg_2x2.png"), UIControlState.Normal);
            ButtonPlayers4.SetTitleColor(UIColor.White, UIControlState.Normal);
            Mode.SetPlayersMode(4);
        }

        partial void ButtonPlayers6_TouchUpInside(UIButton sender)
        {
            UnsetModeButtons();
            ButtonPlayers6.SetBackgroundImage(UIImage.FromBundle("Assets/button_bg_2x2.png"), UIControlState.Normal);
            ButtonPlayers6.SetTitleColor(UIColor.White, UIControlState.Normal);
            Mode.SetPlayersMode(6);
        }

        partial void ButtonPlayersA_TouchUpInside(UIButton sender)
        {
            UnsetModeButtons();
            ButtonPlayersA.SetBackgroundImage(UIImage.FromBundle("Assets/button_bg_10x2.png"), UIControlState.Normal);
            ButtonPlayersA.SetTitleColor(UIColor.White, UIControlState.Normal);
            Mode.SetPlayersMode(100);
        }

        partial void ButtonLife20_TouchUpInside(UIButton sender)
        {
            UnsetLifeButtons();
            ButtonLife20.SetBackgroundImage(UIImage.FromBundle("Assets/button_bg_3x2.png"), UIControlState.Normal);
            ButtonLife20.SetTitleColor(UIColor.White, UIControlState.Normal);
            Mode.SetStartingLife(20);
        }

        partial void ButtonLife30_TouchUpInside(UIButton sender)
        {
            UnsetLifeButtons();
            ButtonLife30.SetBackgroundImage(UIImage.FromBundle("Assets/button_bg_3x2.png"), UIControlState.Normal);
            ButtonLife30.SetTitleColor(UIColor.White, UIControlState.Normal);
            Mode.SetStartingLife(30);
        }

        partial void ButtonLife40_TouchUpInside(UIButton sender)
        {
            UnsetLifeButtons();
            ButtonLife40.SetBackgroundImage(UIImage.FromBundle("Assets/button_bg_3x2.png"), UIControlState.Normal);
            ButtonLife40.SetTitleColor(UIColor.White, UIControlState.Normal);
            Mode.SetStartingLife(40);
        }

        partial void ButtonLifeCustom_TouchUpInside(UIButton sender)
        {
            UnsetLifeButtons();
            ButtonLifeCustom.SetBackgroundImage(UIImage.FromBundle("Assets/button_bg_3x2.png"), UIControlState.Normal);
            ButtonLifeCustom.SetTitleColor(UIColor.White, UIControlState.Normal);
            Mode.SetStartingLife(0);
        }

    }
}