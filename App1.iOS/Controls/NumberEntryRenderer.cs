using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: Xamarin.Forms.ExportRenderer(typeof(App1.Controls.NumberEntry), typeof(App1.iOS.Controls.NumberEntryRenderer))]
namespace App1.iOS.Controls
{
	public class NumberEntryRenderer : EntryRenderer
	{
		public NumberEntryRenderer()
		{

		}

		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);
			if (Control != null)
			{
				Control.KeyboardType = UIKit.UIKeyboardType.NumberPad;
			}
		}
	}
}