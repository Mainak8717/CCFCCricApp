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
			var page1 = new SideMenuItem() { Title = "Home", Icon = "Home_Icon.png", TargetType = typeof(CCFC_HomeScreen) };
			var page2 = new SideMenuItem() { Title = "Teams", Icon = "team_icon.png"};
			var page3 = new SideMenuItem() { Title = "Calendar 2017", Icon = "Calendar_Icon.png"};
			var page4 = new SideMenuItem() { Title = "Tournaments", Icon = "Tournament_Icon.png"};
			var page5 = new SideMenuItem() { Title = "Merchants Cup", Icon = "MerchantsCup_Icon.png"};
			var page6 = new SideMenuItem() { Title = "Gallery", Icon = "Gallery_Icon.png"};
			var page7 = new SideMenuItem() { Title = "CCFC Pro Team", Icon = "ProTeam_Icon.png"};
			var page8 = new SideMenuItem() { Title = "Past Captains", Icon = "captains.png"};
			var page9 = new SideMenuItem() { Title = "Contact Us", Icon = "contactUs.png"};


			// Adding menu items to menuList
			MenuItems.Add(page1);
			MenuItems.Add(page2);
			MenuItems.Add(page3);
			MenuItems.Add(page4);
			MenuItems.Add(page5);
			MenuItems.Add(page6);
			MenuItems.Add(page7);
			MenuItems.Add(page8);
			MenuItems.Add(page9);

		}
	}
}
