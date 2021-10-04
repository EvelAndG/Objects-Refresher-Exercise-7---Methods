using System;

class MainClass 
{
  public static void Main (string[] args) 
	{
	Crypto crypto1 = new Crypto("Etherium", "ETH", 100, 2);

	Console.WriteLine(crypto1.Name);

	crypto1.Product();


  
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

	public void Product() 
	{
		double result = CurrentPrice * AmountOwned;
		Console.WriteLine(result);
		;

	}




	}
	

	

}