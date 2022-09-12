using System;
using System.Globalization;
using System.Data;
using System.Linq;
using System.Collections.Generic;

namespace Masala
{
	class Fibonachi
	{
		static void Main(string[] args)
		{
			int[] Yangi = Fib_Sonlar(1500);
			for (int m = 1; m <= Yangi.Length; m++) 
			{
				Console.WriteLine(Yangi[m]);
			}
			Console.ReadKey();
		}
		public static int Fibonachi1(int son) 
		{
		 if (son == 1 || son == 2) 
		 {return 1; }
		 else 
		 {return Fibonachi1(son - 1) + Fibonachi1(son - 2);} 
		}

		public static int[] Fib_Sonlar(int last)
		{
			int t = 0;
			List<int> Sonlar = new List<int>();
			for (int i = 1; i <= int.MaxValue; i++)
			{
				if (Fibonachi1(i) < last && Fibonachi1(i + 1) > last)
				{
					t = i;
					break;
				}
			}
			for (int i = 1; i <= t; i++)
			{
				Sonlar.Add(Fibonachi1(i));
			}
			return Sonlar.ToArray();
		}


	}
}