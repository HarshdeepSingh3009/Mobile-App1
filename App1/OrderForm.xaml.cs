using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Skip)]
	public partial class OrderForm : TabbedPage
	{
		public OrderForm()
		{
			InitializeComponent();
		}

		public OrderForm(Order target)
		{
			InitializeComponent();
			BindingContext = target;
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			var order = BindingContext as Order;
			DisplayAlert("Order Placed", $"Order placed for {order.Quantity} of {order.ProductName}\r\n You rated this {order.Rating}.", "Ok");
		}
	}
}