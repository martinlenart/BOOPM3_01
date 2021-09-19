using System;

namespace BOOPM3_01_06
{
	class Program
	{
		public class Stock
		{
			decimal currentPrice = 1;       // private "backing" field
			public decimal CurrentPrice     // public property
			{
				get => currentPrice;
				set
				{
					if (value > 0) currentPrice = value;
					else throw new Exception("Wrong Price");
				}
			}

			public decimal SharesOwned { get; set; } = 50;  // Automatic properties initialization

			public decimal Worth
			{
				get => currentPrice * SharesOwned;
				init => SharesOwned = value / currentPrice;  // Can only be set at initialization time
			}
		}
		static void Main(string[] args)
		{
			var stock1 = new Stock();
			Console.WriteLine(stock1.Worth);         // 50
			Console.WriteLine(stock1.SharesOwned);   // 50

			var stock2 = new Stock { CurrentPrice = 50, Worth = 10000 }; //object initialization of public properties
			Console.WriteLine(stock2.Worth);         // 10000
			Console.WriteLine(stock2.SharesOwned);   // 200
		}
	}
	//Excercises:
	//1.	Can SharesOwned be initialized through object initialization? 
	//2.	Make public (should it be static?) readonly members to return nr of Stocks objects created.
	//		Create a few Stocks using object initialization, and write out number of Stock instances created
	//3.	Modify code to write the Worth of the Stock instance with the highest worth created. 

}
