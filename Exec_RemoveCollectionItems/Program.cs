using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_RemoveCollectionItems
{
	internal class Program
	{
		static void Main(string[] args)
		{

			List<Product> list2 = new List<Product>()
			{
				new Product(){Id="321",Buyer="小白"},
				new Product(){Id="456",Buyer="小黃"},
			};

			Product product = new Product() { Id = "666", Buyer = "小魚" };
			list2.Add(product);

			list2.Remove(product);
			list2.Remove(list2[0]);

			foreach (Product all in list2) //list2有三個值依序放入Product all內 並依序跑圈
			{
				Console.WriteLine(all.Id + all.Buyer);
			}


		}
	}
	class Product
	{
		public string Id { get; set; }
		public string Buyer { get; set; }
	}
}
