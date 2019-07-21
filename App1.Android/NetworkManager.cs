using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Net;
using App1;

[assembly: Xamarin.Forms.Dependency(typeof(App1.Droid.NetworkManager))]
namespace App1.Droid
{
	public class NetworkManager : INetworkManager
	{
		Context ctx = Android.App.Application.Context;
		public NetworkManager()
		{

		}

		public bool IsNetworkConnected()
		{
			var cSvc = (ConnectivityManager)ctx.GetSystemService(Context.ConnectivityService);
			return cSvc.ActiveNetworkInfo == null ? false : cSvc.ActiveNetworkInfo.IsConnected;
		}
	}
}