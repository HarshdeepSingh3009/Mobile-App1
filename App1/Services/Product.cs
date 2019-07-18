using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Services
{
	public class Product
	{
		#region Public Memebers

		/// <summary>
		/// 
		/// </summary>
		public string Name
		{
			get;
			set;
		}

		/// <summary>
		/// 
		/// </summary>
		public int Id
		{
			get;
			set;
		}

		/// <summary>
		/// 
		/// </summary>
		public string Description
		{
			get;
			set;
		}

		/// <summary>
		/// 
		/// </summary>
		public string Image_Title
		{
			get;
			set;
		}

		/// <summary>
		/// 
		/// </summary>
		public string Image
		{
			get;
			set;
		}

		/// <summary>
		/// 
		/// </summary>
		public Uri ImageUri
		{
			get
			{
				return String.IsNullOrEmpty(Image) ? null : new Uri(Image);
			}
		}

		#endregion
	}
}
