using System;

class MainClass 
{
  public static void Main (string[] args) 
	{

	
	Crypto crypto1 = new Crypto("Etherium", "ETH", 100, 2.3453);

	Crypto crypto2 = new Crypto("Dogecoin", "DOGE", 0.2426, 1);

	Crypto crypto3 = new Crypto("Litecoin", "LTC", 168.30, 12);

		double sumOfCyrpto = crypto1.Product() + crypto2.Product() + crypto3.Product();
		

	Console.WriteLine(crypto1);
	Console.WriteLine(crypto2);
	Console.WriteLine(crypto3);

	Console.WriteLine("Total Value for all Crypto Owned = "+sumOfCyrpto);

	Console.WriteLine(crypto1.Product());


  
  }

	public class Crypto
	{
		public string Name {get; set;}
		public string TokenName {get; set;}
		public double CurrentPrice {get; set;}
		public double AmountOwned {get; set;}

	
	public Crypto()
	{
		Name = "";
		TokenName = "";
		CurrentPrice = 0;
		AmountOwned = 0;
	}
	public Crypto(string name, string tokenName, double currentPrice, double amountOwned)
	{
		Name = name;
		TokenName = tokenName;
		CurrentPrice = currentPrice;
		AmountOwned = amountOwned;

	}

	public double Product() 
	{
		double result = CurrentPrice * AmountOwned;
		return result;

	}

public override string ToString()
	{
		return "\nName: " + this.Name+"\nToken Name: " +this.TokenName+"\nCurrent Price: "+this.CurrentPrice+"\nAmount Owned: "+this.AmountOwned;
	}


	}

	
	

	

}