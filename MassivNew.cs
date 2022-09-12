using System;
using System.Collections.Generic;
using System.Linq;
namespace Masala 
{
	public class Tempratura 
	{
	  public static void Main(string[] args) 
	  {
	  	List<int> Qiymatlar = new List<int>();
	  	for (int i = (-25); i <= 25; i++)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.Write("Tempraturaning "+i+"- °C dagi tezligini kirgizing:");
				Console.ForegroundColor = ConsoleColor.Yellow;
				int m=Convert.ToInt32(Console.ReadLine());
				Qiymatlar.Add(m);
			}
	  	var MaxTezlik = Qiymatlar.Max();
	  	var MinTezlik = Qiymatlar.Min();
	  	var MiddleTezlik = Qiymatlar.Average();
		Console.Write("\n");
		Console.ForegroundColor = ConsoleColor.Blue;
		Console.WriteLine("-25°C va 25°C dagi eng katta tezlik "+MaxTezlik+" m/s ga teng.");
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine("-25°C va 25°C dagi eng kichik tezlik "+MinTezlik+" m/s ga teng.");
		Console.ForegroundColor = ConsoleColor.Magenta;
		Console.WriteLine("-25°C va 25°C dagi o'rtacha tezlik "+MiddleTezlik+" m/s ga teng.");
		Console.ForegroundColor = ConsoleColor.White;
		Console.WriteLine("Chiqish uchun hohlagan tugmani bosing!!!");
		Console.ReadKey();
	  }
	}
}