using AudioToolbox;
using Foundation;
using System;

using UIKit;

namespace LifeCounter
{
    public partial class ViewController : UIViewController
    {
        PlayersSettingsTableSource settingsTableSource;
        string[] tableItems;
        string[] imageTable;

        NSUrl url;
        SystemSound systemSound;
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            // Perform any additional setup after loading the view, typically from a nib.
            //url = NSUrl.FromFilename();
            //systemSound = new SystemSound(url);

            base.ViewDidLoad();
            if (InterfaceOrientation == UIInterfaceOrientation.LandscapeLeft || InterfaceOrientation == UIInterfaceOrientation.LandscapeRight)
            {
                NavigationController.SetNavigationBarHidden(true, animated: false);
            }
            else NavigationController.SetNavigationBarHidden(false, animated: false);

            tableItems = new string[0];
            imageTable = new string[0];

            if (Style.playersArray == null) Style.playersArray = new Player[6];

            if (Mode.GetPlayersMode() < 10)
            {
                tableItems = new string[Mode.GetPlayersMode()];
                imageTable = new string[Mode.GetPlayersMode()];
                for (int i = 0; i < Mode.GetPlayersMode(); i++)
                {
                    Style.playersArray[i].name = "Player " + (i + 1).ToString();
                }
            }
            else if (Mode.GetPlayersMode() == 100)
            {
                tableItems = new string[4];
                imageTable = new string[4];
                for (int i = 0; i < 3; i++)
                {
                    Style.playersArray[i].name = "Player " + (i + 1).ToString();
                }
                Style.playersArray[3].name = "Archenemy";
            }

            for (int i = 0; i < tableItems.Length; i++)
            {
                tableItems[i] = Style.playersArray[i].name;
                imageTable[i] = Style.playersArray[i].bgColor;
            }

            //RotationInfo.ContentEdgeInsets = new UIEdgeInsets(0, padding, 0, padding);
            //RotationInfo.

            settingsTableSource = new PlayersSettingsTableSource(tableItems, imageTable, this);
            PlayerSettingsTable.Source = settingsTableSource;
            Add(PlayerSettingsTable);



            int lifeMemo = 0;
            lifeMemo = Life.GetALife(0);
            //p1label.Transform = CoreGraphics.CGAffineTransform.MakeRotation((nfloat)Math.PI);
            
            p1label.Text = lifeMemo.ToString();
            lifeMemo = Life.GetALife(1);
            //p2label.Transform = CoreGraphics.CGAffineTransform.MakeRotation((nfloat)Math.PI);
            p2label.Text = lifeMemo.ToString();
            lifeMemo = Life.GetALife(2);
            //p3label.Transform = CoreGraphics.CGAffineTransform.MakeRotation((nfloat)Math.PI);
            p3label.Text = lifeMemo.ToString();
            lifeMemo = Life.GetALife(3);
            p4label.Text = lifeMemo.ToString();
            lifeMemo = Life.GetALife(4);
            p5label.Text = lifeMemo.ToString();
            lifeMemo = Life.GetALife(5);
            p6label.Text = lifeMemo.ToString();

            SetupElements();
            SetupStyles();
            SetupLife();
        }

        public void SetupElements()
        {
            int padding = 15;
            nfloat fontSizeCounter = 70f;
            nfloat fontSizeIncDec = 40f;

            p1image.Transform = CoreGraphics.CGAffineTransform.MakeRotation(0);
            p2image.Transform = CoreGraphics.CGAffineTransform.MakeRotation(0);
            p3image.Transform = CoreGraphics.CGAffineTransform.MakeRotation(0);
            p4image.Transform = CoreGraphics.CGAffineTransform.MakeRotation(0);
            p5image.Transform = CoreGraphics.CGAffineTransform.MakeRotation(0);
            p6image.Transform = CoreGraphics.CGAffineTransform.MakeRotation(0);

            p1inc.ContentEdgeInsets = new UIEdgeInsets(0, padding, 0, padding);
            p1dec.ContentEdgeInsets = new UIEdgeInsets(0, padding, 0, padding);

            p2inc.ContentEdgeInsets = new UIEdgeInsets(0, padding, 0, padding);
            p2dec.ContentEdgeInsets = new UIEdgeInsets(0, padding, 0, padding);

            p3inc.ContentEdgeInsets = new UIEdgeInsets(0, padding, 0, padding);
            p3dec.ContentEdgeInsets = new UIEdgeInsets(0, padding, 0, padding);

            p4inc.ContentEdgeInsets = new UIEdgeInsets(0, padding, 0, padding);
            p4dec.ContentEdgeInsets = new UIEdgeInsets(0, padding, 0, padding);

            p5inc.ContentEdgeInsets = new UIEdgeInsets(0, padding, 0, padding);
            p5dec.ContentEdgeInsets = new UIEdgeInsets(0, padding, 0, padding);

            p6inc.ContentEdgeInsets = new UIEdgeInsets(0, padding, 0, padding);
            p6dec.ContentEdgeInsets = new UIEdgeInsets(0, padding, 0, padding);

            if (Mode.GetPlayersMode() == 1)
            {
                fontSizeCounter = 180f;
                fontSizeIncDec = 150f;
                p1image.Frame = new CoreGraphics.CGRect(0, 0, 568, 320);
                p1inc.Frame = new CoreGraphics.CGRect(0, 0, 284, 320);
                p1dec.Frame = new CoreGraphics.CGRect(284, 0, 284, 320);
                p1label.Frame = new CoreGraphics.CGRect(0, 0, 568, 320);

                //unused
                p2image.Frame = new CoreGraphics.CGRect(569, 0, 284, 320);
                p2dec.Frame = new CoreGraphics.CGRect(569, 0, 284, 160);
                p2inc.Frame = new CoreGraphics.CGRect(569, 160, 284, 160);
                p2label.Frame = new CoreGraphics.CGRect(569, 130, 120, 60);
               
                p3image.Frame = new CoreGraphics.CGRect(569, 160, 284, 160);
                p3dec.Frame = new CoreGraphics.CGRect(569, 160, 142, 160);
                p3inc.Frame = new CoreGraphics.CGRect(569, 160, 142, 160);
                p3label.Frame = new CoreGraphics.CGRect(569, 210, 120, 60);

                p4image.Frame = new CoreGraphics.CGRect(569, 160, 284, 160);
                p4dec.Frame = new CoreGraphics.CGRect(569, 160, 142, 160);
                p4inc.Frame = new CoreGraphics.CGRect(569, 160, 142, 160);
                p4label.Frame = new CoreGraphics.CGRect(569, 210, 120, 60);

                p5image.Frame = new CoreGraphics.CGRect(569, 160, 189, 160);
                p5dec.Frame = new CoreGraphics.CGRect(569, 160, 96, 160);
                p5inc.Frame = new CoreGraphics.CGRect(569, 160, 96, 160);
                p5label.Frame = new CoreGraphics.CGRect(569, 210, 120, 60);

                p6image.Frame = new CoreGraphics.CGRect(569, 160, 189, 160);
                p6dec.Frame = new CoreGraphics.CGRect(569, 160, 96, 160);
                p6inc.Frame = new CoreGraphics.CGRect(569, 160, 96, 160);
                p6label.Frame = new CoreGraphics.CGRect(569, 210, 120, 60);
            }
            else if (Mode.GetPlayersMode() == 2)
            {
                fontSizeCounter = 150f;
                fontSizeIncDec = 80f;
                p1image.Transform = CoreGraphics.CGAffineTransform.MakeRotation((nfloat)Math.PI / 2);
                p1image.Frame = new CoreGraphics.CGRect(0, 0, 284, 320);
                p1inc.Transform = CoreGraphics.CGAffineTransform.MakeRotation((nfloat)Math.PI / 2);
                p1inc.Frame = new CoreGraphics.CGRect(0, 0, 284, 160);
                p1dec.Transform = CoreGraphics.CGAffineTransform.MakeRotation((nfloat)Math.PI / 2);
                p1dec.Frame = new CoreGraphics.CGRect(0, 160, 284, 160);
                p1label.Frame = new CoreGraphics.CGRect(0, 0, 284, 320);
                p1label.Transform = CoreGraphics.CGAffineTransform.MakeRotation((nfloat)Math.PI / 2);

                p2image.Transform = CoreGraphics.CGAffineTransform.MakeRotation(-(nfloat)Math.PI / 2);
                p2image.Frame = new CoreGraphics.CGRect(284, 0, 284, 320);
                p2dec.Transform = CoreGraphics.CGAffineTransform.MakeRotation(-(nfloat)Math.PI / 2);
                p2dec.Frame = new CoreGraphics.CGRect(284, 0, 284, 160);
                p2inc.Transform = CoreGraphics.CGAffineTransform.MakeRotation(-(nfloat)Math.PI / 2);
                p2inc.Frame = new CoreGraphics.CGRect(284, 160, 284, 160);
                p2label.Frame = new CoreGraphics.CGRect(284, 0, 284, 320);
                p2label.Transform = CoreGraphics.CGAffineTransform.MakeRotation(-(nfloat)Math.PI / 2);
                //p2dec.HorizontalAlignment = UIControlContentHorizontalAlignment.Left;
                //p2inc.HorizontalAlignment = UIControlContentHorizontalAlignment.Right;

                //unused
                p3image.Frame = new CoreGraphics.CGRect(569, 160, 284, 160);
                p3dec.Frame = new CoreGraphics.CGRect(569, 160, 142, 160);
                p3inc.Frame = new CoreGraphics.CGRect(569, 160, 142, 160);
                p3label.Frame = new CoreGraphics.CGRect(569, 210, 120, 60);
     
                p4image.Frame = new CoreGraphics.CGRect(569, 160, 284, 160);
                p4dec.Frame = new CoreGraphics.CGRect(569, 160, 142, 160);
                p4inc.Frame = new CoreGraphics.CGRect(569, 160, 142, 160);
                p4label.Frame = new CoreGraphics.CGRect(569, 210, 120, 60);

                p5image.Frame = new CoreGraphics.CGRect(569, 160, 189, 160);
                p5dec.Frame = new CoreGraphics.CGRect(569, 160, 96, 160);
                p5inc.Frame = new CoreGraphics.CGRect(569, 160, 96, 160);
                p5label.Frame = new CoreGraphics.CGRect(569, 210, 120, 60);

                p6image.Frame = new CoreGraphics.CGRect(569, 160, 189, 160);
                p6dec.Frame = new CoreGraphics.CGRect(569, 160, 96, 160);
                p6inc.Frame = new CoreGraphics.CGRect(569, 160, 96, 160);
                p6label.Frame = new CoreGraphics.CGRect(569, 210, 120, 60);
            }
            else if (Mode.GetPlayersMode() == 3)
            {
                fontSizeCounter = 90f;
                fontSizeIncDec = 60f;
                p1image.Frame = new CoreGraphics.CGRect(0, 0, 284, 160);
                p1inc.Frame = new CoreGraphics.CGRect(0, 0, 142, 160);
                p1dec.Frame = new CoreGraphics.CGRect(142, 0, 142, 160);
                p1label.Frame = new CoreGraphics.CGRect(0, 0, 284, 160);
                p1label.Transform = CoreGraphics.CGAffineTransform.MakeRotation((nfloat)Math.PI);

                p2image.Frame = new CoreGraphics.CGRect(284, 0, 284, 160);
                p2inc.Frame = new CoreGraphics.CGRect(284, 0, 142, 160);
                p2dec.Frame = new CoreGraphics.CGRect(426, 0, 142, 160);
                p2label.Frame = new CoreGraphics.CGRect(284, 0, 284, 160);
                p2label.Transform = CoreGraphics.CGAffineTransform.MakeRotation((nfloat)Math.PI);

                p3image.Frame = new CoreGraphics.CGRect(142, 160, 284, 160);
                p3dec.Frame = new CoreGraphics.CGRect(142, 160, 142, 160);
                p3inc.Frame = new CoreGraphics.CGRect(284, 160, 142, 160);
                p3label.Frame = new CoreGraphics.CGRect(142, 160, 284, 160);
                p3label.Transform = CoreGraphics.CGAffineTransform.MakeRotation(0);
                p3dec.HorizontalAlignment = UIControlContentHorizontalAlignment.Left;
                p3inc.HorizontalAlignment = UIControlContentHorizontalAlignment.Right;

                //unused
                p4image.Frame = new CoreGraphics.CGRect(569, 160, 284, 160);
                p4dec.Frame = new CoreGraphics.CGRect(569, 160, 142, 160);
                p4inc.Frame = new CoreGraphics.CGRect(569, 160, 142, 160);
                p4label.Frame = new CoreGraphics.CGRect(569, 210, 120, 60);

                p5image.Frame = new CoreGraphics.CGRect(569, 160, 189, 160);
                p5dec.Frame = new CoreGraphics.CGRect(569, 160, 96, 160);
                p5inc.Frame = new CoreGraphics.CGRect(569, 160, 96, 160);
                p5label.Frame = new CoreGraphics.CGRect(569, 210, 120, 60);

                p6image.Frame = new CoreGraphics.CGRect(569, 160, 189, 160);
                p6dec.Frame = new CoreGraphics.CGRect(569, 160, 96, 160);
                p6inc.Frame = new CoreGraphics.CGRect(569, 160, 96, 160);
                p6label.Frame = new CoreGraphics.CGRect(569, 210, 120, 60);
            }
            else if (Mode.GetPlayersMode() == 4)
            {
                fontSizeCounter = 90f;
                fontSizeIncDec = 60f;
                p1label.Transform = CoreGraphics.CGAffineTransform.MakeRotation((nfloat)Math.PI);
                p1image.Frame = new CoreGraphics.CGRect(0, 0, 284, 160);
                p1inc.Frame = new CoreGraphics.CGRect(0, 0, 142, 160);
                p1dec.Frame = new CoreGraphics.CGRect(142, 0, 142, 160);
                p1label.Frame = new CoreGraphics.CGRect(0, 0, 284, 160);


                p2label.Transform = CoreGraphics.CGAffineTransform.MakeRotation((nfloat)Math.PI);
                p2image.Frame = new CoreGraphics.CGRect(284, 0, 284, 160);
                p2inc.Frame = new CoreGraphics.CGRect(284, 0, 142, 160);
                p2dec.Frame = new CoreGraphics.CGRect(426, 0, 142, 160);
                p2label.Frame = new CoreGraphics.CGRect(284, 0, 284, 160);

                p3label.Transform = CoreGraphics.CGAffineTransform.MakeRotation(0);
                p3image.Frame = new CoreGraphics.CGRect(0, 160, 284, 160);
                p3dec.Frame = new CoreGraphics.CGRect(0, 160, 142, 160);
                p3inc.Frame = new CoreGraphics.CGRect(142, 160, 142, 160);
                p3label.Frame = new CoreGraphics.CGRect(0, 160, 284, 160);
                p3dec.HorizontalAlignment = UIControlContentHorizontalAlignment.Left;
                p3inc.HorizontalAlignment = UIControlContentHorizontalAlignment.Right;

                p4label.Transform = CoreGraphics.CGAffineTransform.MakeRotation(0);
                p4image.Frame = new CoreGraphics.CGRect(284, 160, 284, 160);
                p4dec.Frame = new CoreGraphics.CGRect(284, 160, 142, 160);
                p4inc.Frame = new CoreGraphics.CGRect(426, 160, 142, 160);
                p4label.Frame = new CoreGraphics.CGRect(284, 160, 284, 160);


                //unused
                p5image.Frame = new CoreGraphics.CGRect(569, 160, 189, 160);
                p5dec.Frame = new CoreGraphics.CGRect(569, 160, 96, 160);
                p5inc.Frame = new CoreGraphics.CGRect(569, 160, 96, 160);
                p5label.Frame = new CoreGraphics.CGRect(569, 210, 120, 60);

                p6image.Frame = new CoreGraphics.CGRect(569, 160, 189, 160);
                p6dec.Frame = new CoreGraphics.CGRect(569, 160, 96, 160);
                p6inc.Frame = new CoreGraphics.CGRect(569, 160, 96, 160);
                p6label.Frame = new CoreGraphics.CGRect(569, 210, 120, 60);
            }
            else if (Mode.GetPlayersMode() == 6)
            {
                fontSizeCounter = 70f;
                fontSizeIncDec = 40f;
                p1image.Frame = new CoreGraphics.CGRect(0, 0, 189, 160);
                p1inc.Frame = new CoreGraphics.CGRect(0, 0, 96, 160);
                p1dec.Frame = new CoreGraphics.CGRect(96, 0, 96, 160);
                p1label.Frame = new CoreGraphics.CGRect(0, 0, 189, 160);
                p1label.Transform = CoreGraphics.CGAffineTransform.MakeRotation((nfloat)Math.PI);

                p2image.Frame = new CoreGraphics.CGRect(189, 0, 189, 160);
                p2inc.Frame = new CoreGraphics.CGRect(189, 0, 96, 160);
                p2dec.Frame = new CoreGraphics.CGRect(285, 0, 96, 160);
                p2label.Frame = new CoreGraphics.CGRect(189, 0, 189, 160);
                p2label.Transform = CoreGraphics.CGAffineTransform.MakeRotation((nfloat)Math.PI);

                p3image.Frame = new CoreGraphics.CGRect(378, 0, 189, 160);
                p3inc.Frame = new CoreGraphics.CGRect(378, 0, 96, 160);
                p3dec.Frame = new CoreGraphics.CGRect(473, 0, 96, 160);
                p3label.Frame = new CoreGraphics.CGRect(378, 0, 189, 160);
                p3label.Transform = CoreGraphics.CGAffineTransform.MakeRotation((nfloat)Math.PI);
                p3dec.HorizontalAlignment = UIControlContentHorizontalAlignment.Right;
                p3inc.HorizontalAlignment = UIControlContentHorizontalAlignment.Left;

                p4image.Frame = new CoreGraphics.CGRect(0, 160, 189, 160);
                p4dec.Frame = new CoreGraphics.CGRect(0, 160, 96, 160);
                p4inc.Frame = new CoreGraphics.CGRect(96, 160, 96, 160);
                p4label.Frame = new CoreGraphics.CGRect(0, 160, 189, 160);
                p4label.Transform = CoreGraphics.CGAffineTransform.MakeRotation(0);

                p5image.Frame = new CoreGraphics.CGRect(189, 160, 189, 160);
                p5dec.Frame = new CoreGraphics.CGRect(189, 160, 96, 160);
                p5inc.Frame = new CoreGraphics.CGRect(284, 160, 96, 160);
                p5label.Frame = new CoreGraphics.CGRect(189, 160, 189, 160);
                p5label.Transform = CoreGraphics.CGAffineTransform.MakeRotation(0);

                p6image.Frame = new CoreGraphics.CGRect(378, 160, 189, 160);
                p6dec.Frame = new CoreGraphics.CGRect(378, 160, 96, 160);
                p6inc.Frame = new CoreGraphics.CGRect(473, 160, 96, 160);
                p6label.Frame = new CoreGraphics.CGRect(378, 160, 189, 160);
                p6label.Transform = CoreGraphics.CGAffineTransform.MakeRotation(0);

            }
            else if (Mode.GetPlayersMode() == 100)
            {
                fontSizeCounter = 70f;
                fontSizeIncDec = 40f;
                p1image.Frame = new CoreGraphics.CGRect(0, 0, 189, 160);
                p1inc.Frame = new CoreGraphics.CGRect(0, 0, 96, 160);
                p1dec.Frame = new CoreGraphics.CGRect(96, 0, 96, 160);
                p1label.Frame = new CoreGraphics.CGRect(0, 0, 189, 160);
                p1label.Transform = CoreGraphics.CGAffineTransform.MakeRotation((nfloat)Math.PI);

                p2image.Frame = new CoreGraphics.CGRect(189, 0, 189, 160);
                p2inc.Frame = new CoreGraphics.CGRect(189, 0, 96, 160);
                p2dec.Frame = new CoreGraphics.CGRect(285, 0, 96, 160);
                p2label.Frame = new CoreGraphics.CGRect(189, 0, 189, 160);
                p2label.Transform = CoreGraphics.CGAffineTransform.MakeRotation((nfloat)Math.PI);

                p3image.Frame = new CoreGraphics.CGRect(378, 0, 189, 160);
                p3inc.Frame = new CoreGraphics.CGRect(378, 0, 96, 160);
                p3dec.Frame = new CoreGraphics.CGRect(473, 0, 96, 160);
                p3label.Frame = new CoreGraphics.CGRect(378, 0, 189, 160);
                p3label.Transform = CoreGraphics.CGAffineTransform.MakeRotation((nfloat)Math.PI);
                p3dec.HorizontalAlignment = UIControlContentHorizontalAlignment.Right;
                p3inc.HorizontalAlignment = UIControlContentHorizontalAlignment.Left;

                p4image.Frame = new CoreGraphics.CGRect(189, 160, 189, 160);
                p4dec.Frame = new CoreGraphics.CGRect(189, 160, 96, 160);
                p4inc.Frame = new CoreGraphics.CGRect(284, 160, 96, 160);
                p4label.Frame = new CoreGraphics.CGRect(189, 160, 189, 160);
                p4label.Transform = CoreGraphics.CGAffineTransform.MakeRotation(0);

                //unused
                p5image.Frame = new CoreGraphics.CGRect(569, 160, 189, 160);
                p5dec.Frame = new CoreGraphics.CGRect(569, 160, 96, 160);
                p5inc.Frame = new CoreGraphics.CGRect(569, 160, 96, 160);
                p5label.Frame = new CoreGraphics.CGRect(569, 210, 120, 60);

                p6image.Frame = new CoreGraphics.CGRect(569, 160, 189, 160);
                p6dec.Frame = new CoreGraphics.CGRect(569, 160, 96, 160);
                p6inc.Frame = new CoreGraphics.CGRect(569, 160, 96, 160);
                p6label.Frame = new CoreGraphics.CGRect(569, 210, 120, 60);
            }

            p1label.Font = UIFont.FromName("beleren-bold", fontSizeCounter);
            p2label.Font = UIFont.FromName("beleren-bold", fontSizeCounter);
            p3label.Font = UIFont.FromName("beleren-bold", fontSizeCounter);
            p4label.Font = UIFont.FromName("beleren-bold", fontSizeCounter);
            p5label.Font = UIFont.FromName("beleren-bold", fontSizeCounter);
            p6label.Font = UIFont.FromName("beleren-bold", fontSizeCounter);

            p1inc.Font = UIFont.FromName("beleren-bold", fontSizeIncDec);
            p2inc.Font = UIFont.FromName("beleren-bold", fontSizeIncDec);
            p3inc.Font = UIFont.FromName("beleren-bold", fontSizeIncDec);
            p4inc.Font = UIFont.FromName("beleren-bold", fontSizeIncDec);
            p5inc.Font = UIFont.FromName("beleren-bold", fontSizeIncDec);
            p6inc.Font = UIFont.FromName("beleren-bold", fontSizeIncDec);

            p1dec.Font = UIFont.FromName("beleren-bold", fontSizeIncDec);
            p2dec.Font = UIFont.FromName("beleren-bold", fontSizeIncDec);
            p3dec.Font = UIFont.FromName("beleren-bold", fontSizeIncDec);
            p4dec.Font = UIFont.FromName("beleren-bold", fontSizeIncDec);
            p5dec.Font = UIFont.FromName("beleren-bold", fontSizeIncDec);
            p6dec.Font = UIFont.FromName("beleren-bold", fontSizeIncDec);
        }

        public void SetupStyles()
        {
            //ImageView1.Image = UIImage.FromBundle("ip5s_assets/bg_" + Style.playersArray[1].bgColor + "_ip5s.png");

            // 1,3,4 3x2
            // 2,6,A 2x2
            string modePath;
            if (Mode.GetPlayersMode() == 1 || Mode.GetPlayersMode() == 3 || Mode.GetPlayersMode() == 4) modePath = "3x2";
            else modePath = "2x2";

            p1image.Image = UIImage.FromBundle("Assets/" + modePath + "/bg_" + Style.playersArray[0].bgColor + "_" + modePath + ".png");
            p2image.Image = UIImage.FromBundle("Assets/" + modePath + "/bg_" + Style.playersArray[1].bgColor + "_" + modePath + ".png");
            p3image.Image = UIImage.FromBundle("Assets/" + modePath + "/bg_" + Style.playersArray[2].bgColor + "_" + modePath + ".png");
            p4image.Image = UIImage.FromBundle("Assets/" + modePath + "/bg_" + Style.playersArray[3].bgColor + "_" + modePath + ".png");
            p5image.Image = UIImage.FromBundle("Assets/" + modePath + "/bg_" + Style.playersArray[4].bgColor + "_" + modePath + ".png");
            p6image.Image = UIImage.FromBundle("Assets/" + modePath + "/bg_" + Style.playersArray[5].bgColor + "_" + modePath + ".png");

            p1label.TextColor = Style.playersArray[0].textColor;
            p2label.TextColor = Style.playersArray[1].textColor;
            p3label.TextColor = Style.playersArray[2].textColor;
            p4label.TextColor = Style.playersArray[3].textColor;
            p5label.TextColor = Style.playersArray[4].textColor;
            p6label.TextColor = Style.playersArray[5].textColor;

            //ImageView1.ReloadInputViews();
        }

        public void SetupLife()
        {
            int lifeMemo = Mode.GetStartingLife();

            if (Mode.GetPlayersMode() < 10)
            {
                for (int i = 0; i < Mode.GetPlayersMode(); i++)
                {
                    Life.SetALife(i, lifeMemo);
                }
            }
            else if (Mode.GetPlayersMode() == 100)
            {
                for (int i = 0; i < 3; i++)
                {
                    Life.SetALife(i, lifeMemo);
                }
                Life.SetALife(3, 2*lifeMemo);
            }

            lifeMemo = Life.GetALife(0);
            
            p1label.Text = lifeMemo.ToString();
            lifeMemo = Life.GetALife(1);
            p2label.Text = lifeMemo.ToString();
            lifeMemo = Life.GetALife(2);
            p3label.Text = lifeMemo.ToString();
            lifeMemo = Life.GetALife(3);
            p4label.Text = lifeMemo.ToString();
            lifeMemo = Life.GetALife(4);
            p5label.Text = lifeMemo.ToString();
            lifeMemo = Life.GetALife(5);
            p6label.Text = lifeMemo.ToString();

        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewDidAppear(animated);
            for (int i = 0; i < tableItems.Length; i++)
            {
                tableItems[i] = Style.playersArray[i].name;
                imageTable[i] = Style.playersArray[i].bgColor;
            }
            settingsTableSource = new PlayersSettingsTableSource(tableItems, imageTable, this);
            PlayerSettingsTable.Source = settingsTableSource;
            Add(PlayerSettingsTable);
            //PlayerSettingsTable.U

            SetupStyles();
            
            //PlayerSettingsTable.ReloadInputViews();
        }

        //public override void WillRotate(UIInterfaceOrientation toInterfaceOrientation, double duration)
        //{
        //    base.WillRotate(toInterfaceOrientation, duration);
        //    for (int i = 0; i < tableItems.Length; i++)
        //    {
        //        tableItems[i] = Style.playersArray[i].name;
        //        imageTable[i] = Style.playersArray[i].bgColor;
        //    }
        //    settingsTableSource = new PlayersSettingsTableSource(tableItems, imageTable, this);
        //    PlayerSettingsTable.Source = settingsTableSource;
        //    Add(PlayerSettingsTable);
        //}

        public override void DidRotate(UIInterfaceOrientation fromInterfaceOrientation)
        {
            base.DidRotate(fromInterfaceOrientation);
            if (InterfaceOrientation == UIInterfaceOrientation.LandscapeLeft || InterfaceOrientation == UIInterfaceOrientation.LandscapeRight)
            {
                NavigationController.SetNavigationBarHidden(true, animated: false);
            }
            else NavigationController.SetNavigationBarHidden(false, animated: true);

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void P1inc_TouchUpInside(UIButton sender)
        {
            Life.IncrementLife(0, 1);
            int lifeMemo = Life.GetALife(0);
            p1label.Text = lifeMemo.ToString();
            UIDevice.CurrentDevice.PlayInputClick();
        }

        partial void P1dec_TouchUpInside(UIButton sender)
        {
            Life.DecrementLife(0, 1);
            int lifeMemo = Life.GetALife(0);
            p1label.Text = lifeMemo.ToString();
            UIDevice.CurrentDevice.PlayInputClick();
        }

        partial void P2inc_TouchUpInside(UIButton sender)
        {
            Life.IncrementLife(1, 1);
            int lifeMemo = Life.GetALife(1);
            p2label.Text = lifeMemo.ToString();
        }

        partial void P2dec_TouchUpInside(UIButton sender)
        {
            Life.DecrementLife(1, 1);
            int lifeMemo = Life.GetALife(1);
            p2label.Text = lifeMemo.ToString();
        }

        partial void P3inc_TouchUpInside(UIButton sender)
        {
            Life.IncrementLife(2, 1);
            int lifeMemo = Life.GetALife(2);
            p3label.Text = lifeMemo.ToString();
        }

        partial void P3dec_TouchUpInside(UIButton sender)
        {
            Life.DecrementLife(2, 1);
            int lifeMemo = Life.GetALife(2);
            p3label.Text = lifeMemo.ToString();
        }

        partial void P4inc_TouchUpInside(UIButton sender)
        {
            Life.IncrementLife(3, 1);
            int lifeMemo = Life.GetALife(3);
            p4label.Text = lifeMemo.ToString();
        }

        partial void P4dec_TouchUpInside(UIButton sender)
        {
            Life.DecrementLife(3, 1);
            int lifeMemo = Life.GetALife(3);
            p4label.Text = lifeMemo.ToString();
        }

        partial void P5inc_TouchUpInside(UIButton sender)
        {
            Life.IncrementLife(4, 1);
            int lifeMemo = Life.GetALife(4);
            p5label.Text = lifeMemo.ToString();
        }

        partial void P5dec_TouchUpInside(UIButton sender)
        {
            Life.DecrementLife(4, 1);
            int lifeMemo = Life.GetALife(4);
            p5label.Text = lifeMemo.ToString();
        }

        partial void P6inc_TouchUpInside(UIButton sender)
        {
            Life.IncrementLife(5, 1);
            int lifeMemo = Life.GetALife(5);
            p6label.Text = lifeMemo.ToString();
        }

        partial void P6dec_TouchUpInside(UIButton sender)
        {
            Life.DecrementLife(5, 1);
            int lifeMemo = Life.GetALife(5);
            p6label.Text = lifeMemo.ToString();
        }

        //void LongPressMethod(UILongPressGestureRecognizer gestureRecognizer)
        //{
        //    if (gestureRecognizer.State == UIGestureRecognizerState.Began)
        //    {
        //        Console.Write("LongPress");
        //        UIAlertController actionSheetAlert = UIAlertController.Create("Action Sheet", "Select an item from below", UIAlertControllerStyle.ActionSheet);

        //        actionSheetAlert.AddAction(UIAlertAction.Create("Item One", UIAlertActionStyle.Default, (action) => Console.WriteLine("Item One pressed.")));
        //        actionSheetAlert.AddAction(UIAlertAction.Create("Item Two", UIAlertActionStyle.Default, (action) => Console.WriteLine("Item Two pressed.")));
        //        actionSheetAlert.AddAction(UIAlertAction.Create("Item Three", UIAlertActionStyle.Default, (action) => Console.WriteLine("Item Three pressed.")));
        //        actionSheetAlert.AddAction(UIAlertAction.Create("Cancel", UIAlertActionStyle.Cancel, (action) => Console.WriteLine("Cancel button pressed.")));

        //        this.PresentViewController(actionSheetAlert, true, null);
        //    }
        //}

        
    }
}