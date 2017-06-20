using Foundation;
using System;
using UIKit;

namespace LifeCounter
{
    public partial class PlayerSettingsViewController : UIViewController
    {
        //int playerIndex;
        public PlayerSettingsViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            BarsReset();
            if (Style.playersArray[Style.activePlayerId].bgColor == "black") BlackButton.SetBackgroundImage(UIImage.FromBundle("Assets/Bars/bar_blank.png"), UIControlState.Normal);
            else if (Style.playersArray[Style.activePlayerId].bgColor == "blue") BlueButton.SetBackgroundImage(UIImage.FromBundle("Assets/Bars/bar_blank.png"), UIControlState.Normal);
            else if (Style.playersArray[Style.activePlayerId].bgColor == "green") GreenButton.SetBackgroundImage(UIImage.FromBundle("Assets/Bars/bar_blank.png"), UIControlState.Normal);
            else if (Style.playersArray[Style.activePlayerId].bgColor == "pink") PinkButton.SetBackgroundImage(UIImage.FromBundle("Assets/Bars/bar_blank.png"), UIControlState.Normal);
            else if (Style.playersArray[Style.activePlayerId].bgColor == "red") RedButton.SetBackgroundImage(UIImage.FromBundle("Assets/Bars/bar_blank.png"), UIControlState.Normal);
            else if (Style.playersArray[Style.activePlayerId].bgColor == "violet") VioletButton.SetBackgroundImage(UIImage.FromBundle("Assets/Bars/bar_blank.png"), UIControlState.Normal);
            else if (Style.playersArray[Style.activePlayerId].bgColor == "white") WhiteButton.SetBackgroundImage(UIImage.FromBundle("Assets/Bars/bar_blank.png"), UIControlState.Normal);
            else if (Style.playersArray[Style.activePlayerId].bgColor == "yellow") YellowButton.SetBackgroundImage(UIImage.FromBundle("Assets/Bars/bar_blank.png"), UIControlState.Normal);
            else if (Style.playersArray[Style.activePlayerId].bgColor == "white2") TransButton.SetBackgroundImage(UIImage.FromBundle("Assets/Bars/bar_blank.png"), UIControlState.Normal);
            else if (Style.playersArray[Style.activePlayerId].bgColor == "island") IslandButton.SetBackgroundImage(UIImage.FromBundle("Assets/Bars/bar_blank.png"), UIControlState.Normal);
            else if (Style.playersArray[Style.activePlayerId].bgColor == "swamp") SwampButton.SetBackgroundImage(UIImage.FromBundle("Assets/Bars/bar_blank.png"), UIControlState.Normal);
            else if (Style.playersArray[Style.activePlayerId].bgColor == "mountain") MountainButton.SetBackgroundImage(UIImage.FromBundle("Assets/Bars/bar_blank.png"), UIControlState.Normal);
            else if (Style.playersArray[Style.activePlayerId].bgColor == "plains") PlainsButton.SetBackgroundImage(UIImage.FromBundle("Assets/Bars/bar_blank.png"), UIControlState.Normal);
            else if (Style.playersArray[Style.activePlayerId].bgColor == "forest") ForestButton.SetBackgroundImage(UIImage.FromBundle("Assets/Bars/bar_blank.png"), UIControlState.Normal);
            else if (Style.playersArray[Style.activePlayerId].bgColor == "bolas") BolasButton.SetBackgroundImage(UIImage.FromBundle("Assets/Bars/bar_blank.png"), UIControlState.Normal);
        }

        public void BarsReset()
        {
            BlackButton.SetBackgroundImage(UIImage.FromBundle("Assets/Bars/bar_black.png"), UIControlState.Normal);
            BlueButton.SetBackgroundImage(UIImage.FromBundle("Assets/Bars/bar_blue.png"), UIControlState.Normal);
            GreenButton.SetBackgroundImage(UIImage.FromBundle("Assets/Bars/bar_green.png"), UIControlState.Normal);
            PinkButton.SetBackgroundImage(UIImage.FromBundle("Assets/Bars/bar_pink.png"), UIControlState.Normal);
            RedButton.SetBackgroundImage(UIImage.FromBundle("Assets/Bars/bar_red.png"), UIControlState.Normal);
            VioletButton.SetBackgroundImage(UIImage.FromBundle("Assets/Bars/bar_violet.png"), UIControlState.Normal);
            WhiteButton.SetBackgroundImage(UIImage.FromBundle("Assets/Bars/bar_white.png"), UIControlState.Normal);
            YellowButton.SetBackgroundImage(UIImage.FromBundle("Assets/Bars/bar_yellow.png"), UIControlState.Normal);
            TransButton.SetBackgroundImage(UIImage.FromBundle("Assets/Bars/bar_trans.png"), UIControlState.Normal);
            IslandButton.SetBackgroundImage(UIImage.FromBundle("Assets/Bars/bar_island.png"), UIControlState.Normal);
            SwampButton.SetBackgroundImage(UIImage.FromBundle("Assets/Bars/bar_swamp.png"), UIControlState.Normal);
            MountainButton.SetBackgroundImage(UIImage.FromBundle("Assets/Bars/bar_mountain.png"), UIControlState.Normal);
            PlainsButton.SetBackgroundImage(UIImage.FromBundle("Assets/Bars/bar_plains.png"), UIControlState.Normal);
            ForestButton.SetBackgroundImage(UIImage.FromBundle("Assets/Bars/bar_forest.png"), UIControlState.Normal);
            BolasButton.SetBackgroundImage(UIImage.FromBundle("Assets/Bars/bar_bolas.png"), UIControlState.Normal);
        }

        partial void BlackButton_TouchUpInside(UIButton sender)
        {
            BarsReset();
            Style.playersArray[Style.activePlayerId].bgColor = "black";
            Style.playersArray[Style.activePlayerId].textColor = UIColor.White;
            BlackButton.SetBackgroundImage(UIImage.FromBundle("Assets/Bars/bar_blank.png"), UIControlState.Normal);
        }

        partial void BlueButton_TouchUpInside(UIButton sender)
        {
            BarsReset();
            Style.playersArray[Style.activePlayerId].bgColor = "blue";
            Style.playersArray[Style.activePlayerId].textColor = UIColor.Black;
            BlueButton.SetBackgroundImage(UIImage.FromBundle("Assets/Bars/bar_blank.png"), UIControlState.Normal);
        }

        partial void GreenButton_TouchUpInside(UIButton sender)
        {
            BarsReset();
            Style.playersArray[Style.activePlayerId].bgColor = "green";
            Style.playersArray[Style.activePlayerId].textColor = UIColor.Black;
            GreenButton.SetBackgroundImage(UIImage.FromBundle("Assets/Bars/bar_blank.png"), UIControlState.Normal);
        }

        partial void RedButton_TouchUpInside(UIButton sender)
        {
            BarsReset();
            Style.playersArray[Style.activePlayerId].bgColor = "red";
            Style.playersArray[Style.activePlayerId].textColor = UIColor.Black;
            RedButton.SetBackgroundImage(UIImage.FromBundle("Assets/Bars/bar_blank.png"), UIControlState.Normal);
        }

        partial void WhiteButton_TouchUpInside(UIButton sender)
        {
            BarsReset();
            Style.playersArray[Style.activePlayerId].bgColor = "white";
            Style.playersArray[Style.activePlayerId].textColor = UIColor.Black;
            WhiteButton.SetBackgroundImage(UIImage.FromBundle("Assets/Bars/bar_blank.png"), UIControlState.Normal);
        }

        partial void VioletButton_TouchUpInside(UIButton sender)
        {
            BarsReset();
            Style.playersArray[Style.activePlayerId].bgColor = "violet";
            Style.playersArray[Style.activePlayerId].textColor = UIColor.White;
            VioletButton.SetBackgroundImage(UIImage.FromBundle("Assets/Bars/bar_blank.png"), UIControlState.Normal);
        }

        partial void YellowButton_TouchUpInside(UIButton sender)
        {
            BarsReset();
            Style.playersArray[Style.activePlayerId].bgColor = "yellow";
            Style.playersArray[Style.activePlayerId].textColor = UIColor.Black;
            YellowButton.SetBackgroundImage(UIImage.FromBundle("Assets/Bars/bar_blank.png"), UIControlState.Normal);
        }

        partial void PinkButton_TouchUpInside(UIButton sender)
        {
            BarsReset();
            Style.playersArray[Style.activePlayerId].bgColor = "pink";
            Style.playersArray[Style.activePlayerId].textColor = UIColor.Black;
            PinkButton.SetBackgroundImage(UIImage.FromBundle("Assets/Bars/bar_blank.png"), UIControlState.Normal);
        }

        partial void TransButton_TouchUpInside(UIButton sender)
        {
            BarsReset();
            Style.playersArray[Style.activePlayerId].bgColor = "white2";
            Style.playersArray[Style.activePlayerId].textColor = UIColor.Black;
            TransButton.SetBackgroundImage(UIImage.FromBundle("Assets/Bars/bar_blank.png"), UIControlState.Normal);
        }

        partial void IslandButton_TouchUpInside(UIButton sender)
        {
            BarsReset();
            Style.playersArray[Style.activePlayerId].bgColor = "island";
            Style.playersArray[Style.activePlayerId].textColor = UIColor.White;
            IslandButton.SetBackgroundImage(UIImage.FromBundle("Assets/Bars/bar_blank.png"), UIControlState.Normal);
        }

        partial void SwampButton_TouchUpInside(UIButton sender)
        {
            BarsReset();
            Style.playersArray[Style.activePlayerId].bgColor = "swamp";
            Style.playersArray[Style.activePlayerId].textColor = UIColor.White;
            SwampButton.SetBackgroundImage(UIImage.FromBundle("Assets/Bars/bar_blank.png"), UIControlState.Normal);
        }

        partial void MountainButton_TouchUpInside(UIButton sender)
        {
            BarsReset();
            Style.playersArray[Style.activePlayerId].bgColor = "mountain";
            Style.playersArray[Style.activePlayerId].textColor = UIColor.White;
            MountainButton.SetBackgroundImage(UIImage.FromBundle("Assets/Bars/bar_blank.png"), UIControlState.Normal);
        }

        partial void PlainsButton_TouchUpInside(UIButton sender)
        {
            BarsReset();
            Style.playersArray[Style.activePlayerId].bgColor = "plains";
            Style.playersArray[Style.activePlayerId].textColor = UIColor.White;
            PlainsButton.SetBackgroundImage(UIImage.FromBundle("Assets/Bars/bar_blank.png"), UIControlState.Normal);
        }

        partial void ForestButton_TouchUpInside(UIButton sender)
        {
            BarsReset();
            Style.playersArray[Style.activePlayerId].bgColor = "forest";
            Style.playersArray[Style.activePlayerId].textColor = UIColor.White;
            ForestButton.SetBackgroundImage(UIImage.FromBundle("Assets/Bars/bar_blank.png"), UIControlState.Normal);
        }

        partial void BolasButton_TouchUpInside(UIButton sender)
        {
            BarsReset();
            Style.playersArray[Style.activePlayerId].bgColor = "bolas";
            Style.playersArray[Style.activePlayerId].textColor = UIColor.White;
            BolasButton.SetBackgroundImage(UIImage.FromBundle("Assets/Bars/bar_blank.png"), UIControlState.Normal);
        }
    }
}