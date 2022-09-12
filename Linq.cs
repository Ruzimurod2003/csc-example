using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
// 11. Har biri 30 ta butun sondan iborat ikkita ketma-ketlik berilgan. 
// Birinchi ketma-ketlikning ikkinchi ketma-ketlikka kirmagan sonlari ichidagi eng kichigi topilsin
// (bunaqa sonlardan kamida bittasi mavjud deb faraz qilinsin).
namespace Masala 
{
	public class LINQ 
	{
		public static void Mission(int []a,int []b,int n,int m)
	    {
	    	List<int> Sonlar = new List<int>();
	    	for (int i = 0; i < n; i++)
	    	{
	    		int j;
	    		for (j = 0; j < m; j++)
	    			if (a[i] == b[j])
	    				break;
	 				if (j == m)
	    				Sonlar.Add(a[i]);
			}
	    	Console.WriteLine("Javob: "+Sonlar.Min());
	    }
	    public static void Main()
    	{
        	int []a = {1,2,3,4,5,7,8,96,5,4,7,8,4,5,7,4,5,84,7,4,8,44,41,444,44,4,5,4,45};
        	int []b = {1,8,9,7,4,5,7,85,154,48,7,8,78,45,45,54,52,1,54,31,4,45,124,48,7,7};
         
        	int n = a.Length;
        	int m = b.Length;
         
        	Mission(a, b, n, m);
        	Console.ReadKey();
   	 	}

	}
}