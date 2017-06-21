using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CCFCCricApp
{
	public partial class CCFC_TeamScreen : ContentPage
	{
		public CCFC_TeamScreen()
		{
			InitializeComponent();
			BindingContext = new TeamViewModel();
		}
	}
}
