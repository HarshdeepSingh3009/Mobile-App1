using App1.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProductDetails : ContentPage
	{
		public ProductDetails()
		{
			InitializeComponent();
		}

		public ProductDetails(Product target)
		{
			InitializeComponent();
			BindingContext = target;
		}

		private void OrderBtn_Clicked(object sender, System.EventArgs e)
		{
			var target = BindingContext as Product;
			Navigation.PushAsync(new OrderForm(
				new Order {	ProductName = target.Name,	Quantity = 1 }));
		}

		private void FavButton_Clicked(object sender, System.EventArgs e)
		{
			var prod = BindingContext as Product;
			ProductService.WishList.Add(prod);
		}
	}
}