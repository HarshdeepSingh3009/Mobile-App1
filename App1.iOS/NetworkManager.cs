using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using Foundation;
using UIKit;
using SystemConfiguration;

[assembly:Xamarin.Forms.Dependency(typeof(App1.iOS.NetworkManager))]
namespace App1.iOS
{
	class NetworkManager : INetworkManager
	{
		/// <summary>
		/// 
		/// </summary>
		public NetworkManager()
		{

		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public bool IsNetworkConnected()
		{
			NetworkReachabilityFlags flags;
			var address = new IPAddress(0);
			var reachability = new NetworkReachability(address);

			if (reachability.TryGetFlags(out flags))
			{
				return (flags & NetworkReachabilityFlags.Reachable) != 0;
			}
			else
			{
				return false;
			}
		}
	}
}