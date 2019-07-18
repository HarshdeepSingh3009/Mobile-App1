﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace App1.Services
{
	/// <summary>
	/// 
	/// </summary>
	public static class ProductService
	{
		#region Private Members

		private const string _wishList = "wishlist.json";
		private static HttpClient client;

		static ProductService()
		{
			client = new HttpClient();
			client.BaseAddress = new Uri("https://hplussport.com/api/");
		}

		#endregion

		#region Public Members

		/// <summary>
		/// 
		/// </summary>
		public static List<Product> WishList { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public static async Task<List<Product>> GetProductsAsync()
		{
			var productsRaw = await client.GetStringAsync("https://hplussport.com/api/products/");

			var serializer = new JsonSerializer();
			using (var tReader = new StringReader(productsRaw))
			{
				using (var jReader = new JsonTextReader(tReader))
				{
					var products = serializer.Deserialize<List<Product>>(jReader);
					return products;
				}
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public static async Task SaveWishList()
		{
			if (WishList != null)
			{
				//save wish list to file
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public static async Task LoadWishList()
		{
			//load wishList from file
		}
		#endregion

	}
}
