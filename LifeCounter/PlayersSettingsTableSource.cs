using System;
using System.Collections.Generic;
using System.Text;
using Foundation;
using UIKit;

namespace LifeCounter
{
    public class PlayersSettingsTableSource : UITableViewSource
    {
        string[] TableItems;
        string[] itemsColors;
        string CellIdentifier = "TableCell";
        ViewController owner;

        public PlayersSettingsTableSource(string[] items, string[] itemsColors, ViewController owner)
        {
            TableItems = items;
            this.itemsColors = itemsColors;
            this.owner = owner;
        }

        public override string TitleForHeader(UITableView tableView, nint section)
        {
            //return base.TitleForHeader(tableView, section);
            return "Players Settings";
        }
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            //UITableViewCell cell = new UITableViewCell(UITableViewCellStyle.Default, CellIdentifier + indexPath.Row.ToString());

            UITableViewCell cell = tableView.DequeueReusableCell(CellIdentifier);
            //if (cell == null)
            //{
            //    cell = new UITableViewCell(UITableViewCellStyle.Default, CellIdentifier);
            //}

            cell.Accessory = UITableViewCellAccessory.DisclosureIndicator;

            string item = TableItems[indexPath.Row];
            UIImage image = UIImage.FromFile("Assets/Indicators/indicator_" + itemsColors[indexPath.Row] + ".png");

            cell.TextLabel.Text = item;
            cell.ImageView.Image = image;

            return cell;
        }
        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            Style.activePlayerId = indexPath.Row;
        }
        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return TableItems.Length;
        }
    }
}
