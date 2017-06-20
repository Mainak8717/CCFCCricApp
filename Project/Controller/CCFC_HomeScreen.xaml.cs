using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CCFCCricApp
{
	public partial class CCFC_HomeScreen : ContentPage
	{
		public CCFC_HomeScreen()
		{
			InitializeComponent();
			BindingContext = new HomeScreenViewModel();
		}
	}
}
