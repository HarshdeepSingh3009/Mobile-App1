using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.Services;
using Xamarin.Forms;

namespace App1
{
	// Learn more about making custom code visible in the Xamarin.Forms previewer
	// by visiting https://aka.ms/xamarinforms-previewer
	[DesignTimeVisible(false)]
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		//private void Button_Clicked(object sender, EventArgs e)
		//{
		//	// new page you want to navigate to 
		//	Navigation.PushAsync(new ProductDetails());
		//}

		private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
		{
			var target = e.Item as Product;
			Navigation.PushAsync(new ProductDetails(target));
		}

		protected async override void OnAppearing()
		{
			base.OnAppearing();
			INetworkManager networkManager = DependencyService.Get<INetworkManager>();
			if (networkManager.IsNetworkConnected())
			{
				var products = await ProductService.GetProductsAsync();
				BindingContext = products;
			}
			else
			{
			await DisplayAlert("Not Connected", "you are not connected to network", "Ok");
			}
		}

	}
}
