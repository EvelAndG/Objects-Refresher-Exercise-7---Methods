using System;

class MainClass 
{
  public static void Main (string[] args) 
	{

		Crypto firstCrypto = new Crypto ("Etherium", "ETH", 100, 2);

		Crypto secondCrypto = new Crypto();

		Console.WriteLine(secondCrypto.AmountOwned);

		Console.WriteLine(firstCrypto.Name);

	


		
  
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



	}


}