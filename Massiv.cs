using System;
using System.Collections.Generic;
using System.Linq;
namespace Masala 
{
	public class Massiv 
	{
	   public static void MassivIshlash() 
	   {
	   	int UrtachaTezlik1=0;
	   	int UrtachaTezlik;
	   	int MinSon;
	   	int Maxson;
			List<int> Qiymatlar = new List<int>();
			for (int i = (0); i <= 5; i++)
			{
				Console.WriteLine("Massivning "+i+"- elementini kirgizing:");
				int m=Convert.ToInt32(Console.ReadLine());
				Qiymatlar.Add(m);
			}
			var MaxTezlik= from Tezlik in Qiymatlar
			orderby Tezlik
			select Tezlik;
			foreach (int son in MaxTezlik) 
			{
				UrtachaTezlik1=UrtachaTezlik1+Convert.ToInt32(son);
				UrtachaTezlik=UrtachaTezlik1/(MaxTezlik.Length);
			}
			foreach (int son in MaxTezlik) 
			{
				MinSon=MinFunc(son);
			}
			foreach (int son in MaxTezlik) 
			{
				Maxson=MaxFunc(son);
			}
	   }
	   public static int MaxFunc(int[] n)
	   { 
	   	int num = n[0] ; 
	   	 for (int i = 0; i < n.Length; i++)
	   	 { if (num < n[i])  num = n[i];  
	   	 	 
	   	 	return num; 
	   	 } 
	   }
	   	 public static int MinFunc(int[] n) 
	   	 {
	   	 	int min = n[0];
	   	 	for (int i = 0; i < n.Length; i++)
	   	 	{
	   	 		if (min > n[i])min = n[i]; 
	   	 	} 
	   	 return min;
	   	 		 
	     }
	   public static void Main()
	   {
	   	MassivIshlash();
	   	Console.WriteLine(" Ortacha tezligi"+UrtachaTezlik);

	   	Console.WriteLine("Eng kichigi "+MinSon);

	   	Console.WriteLine("Eng kattasi"+Maxson);
	   	Console.ReadKey();
	   }
	}
}