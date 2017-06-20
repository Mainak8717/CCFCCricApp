using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CCFCCricApp
{
	public partial class CCFC_MasterDetailPage : MasterDetailPage
	{
		public List<SideMenuItem> menuList { get; set; }

		public CCFC_MasterDetailPage()
		{
			InitializeComponent();
			NavigationPage.SetHasNavigationBar(this, false);
			BindingContext = new MenuViewModel();
			Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(CCFC_HomeScreen)));
		}
	
		//private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
		//{
		//	var item = (SideMenuItem)e.SelectedItem;
		//	Type page = item.TargetType;

		//	Detail = new NavigationPage((Page)Activator.CreateInstance(page));
		//	IsPresented = false;
		//}
	}
}
