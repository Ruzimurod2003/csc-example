using System;
using System.Collections.Generic;
using System.Linq;
namespace Masala 
{
	public class Massiv 
	{
	  public static void Main(string[] args) 
	  {
	  	List<int> Qiymatlar = new List<int>();
		Console.Write("Massivingiz nechta elementdan iborat:");
		int Element=Convert.ToInt32(Console.ReadLine());
	  	for (int i = (1); i <= Element; i++)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.Write("Massivning "+i+"-elementini kirgizing:");
				Console.ForegroundColor = ConsoleColor.Yellow;
				int m=Convert.ToInt32(Console.ReadLine());
				Qiymatlar.Add(m);
			}
	  	var MiddleTezlik = Qiymatlar.Average();
		Console.Write("\n");
		Console.ForegroundColor = ConsoleColor.Blue;
		Console.WriteLine("Ushbu massivning o'rtacha qiymati "+MiddleTezlik+" ga teng.");
		Console.ForegroundColor = ConsoleColor.White;
		Console.WriteLine("Chiqish uchun hohlagan tugmani bosing!!!");
		Console.ReadKey();
	  }
	}
}