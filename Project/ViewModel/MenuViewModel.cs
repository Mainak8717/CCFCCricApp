using System;
using System.Collections.Generic;

namespace CCFCCricApp
{
	public class MenuViewModel
	{
		public List<SideMenuItem> MenuItems
		{
			get;
		}
		public MenuViewModel()
		{
			MenuItems = new List<SideMenuItem>();
			MenuItems.Add(new SideMenuItem() { Title = "Home", Icon = "Home_Icon.png"});
			MenuItems.Add(new SideMenuItem() { Title = "Teams", Icon = "team_icon.png"});
			MenuItems.Add(new SideMenuItem() { Title = "Calendar 2017", Icon = "Calendar_Icon.png"});
			MenuItems.Add(new SideMenuItem() { Title = "Tournaments", Icon = "Tournament_Icon.png"});
			MenuItems.Add(new SideMenuItem() { Title = "Merchants Cup", Icon = "MerchantsCup_Icon.png"});
			MenuItems.Add(new SideMenuItem() { Title = "Gallery", Icon = "Gallery_Icon.png"});
			MenuItems.Add(new SideMenuItem() { Title = "CCFC Pro Team", Icon = "ProTeam_Icon.png"});
			MenuItems.Add(new SideMenuItem() { Title = "Past Captains", Icon = "captains.png"});
			MenuItems.Add(new SideMenuItem() { Title = "Contact Us", Icon = "contactUs.png"});
		}
	}
}
