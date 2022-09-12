using System;
using System.Collections.Generic;
using System.Linq;
namespace Masala 
{
	public class Massiv_nxn 
	{
	  public static void Main(string[] args) 
	  {
	  	List<int> Qiymatlar = new List<int>();
		Console.Write("Massivingiz nechta elementdan iborat:");
		int Element=Convert.ToInt32(Console.ReadLine());
	  	for (int i = (1); i <= Element; i++)
			{
				Console.Write("Massivning "+i+"-elementini kirgizing:");
				int m=Convert.ToInt32(Console.ReadLine());
				Qiymatlar.Add(m);
			}
	  	var MiddleQiymat = Qiymatlar.Average();
		Console.Write("\n");
		Console.Write("Ushbu massivning o'rtacha qiymati "+MiddleQiymat+" ga teng.");

		Console.Write("\n");
		Console.Write("Massivning qaysi elementini qidirayapsiz: ");
		int QidirayotganQiymat=Convert.ToInt32(Console.ReadLine());
		var SearchQiymat = Qiymatlar.Select(QidirayotganQiymat);

		Console.Write("\n");
		Console.Write("Massivning "+QidirayotganQiymat+"-hadi "+SearchQiymat+" ga teng.");

		Console.WriteLine("Chiqish uchun hohlagan tugmani bosing!!!");
		Console.ReadKey();
	  }
	}
}