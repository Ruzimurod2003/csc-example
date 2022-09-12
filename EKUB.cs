using System;
namespace Masala 
{
	public class EKUB
	{
	  public static void Main(string[] args) 
	  {
	  	Console.Write("Birinchi sonni kiriting: ");
	  	int FirstNumber=Convert.ToInt32(Console.ReadLine());
	  	Console.Write("Ikkinchi sonni kiriting: ");
	  	int SecondNumber=Convert.ToInt32(Console.ReadLine());
	  	Console.Write("\n");
	  	Console.Write("EKUB("+FirstNumber+";"+SecondNumber+")="+EKUBHisoblash(FirstNumber,SecondNumber));
	  	Console.Write("\n");
	  	Console.Write("Chiqish uchun hohlagan tugmani bosing!!!");
	  	Console.ReadKey();
	  }
	  public static int EKUBHisoblash(int son1,int son2) 
		  {
		  	while (son1!=son2) 
		  	{
		  		if (son1>son2) 
		  		{
		  			son1=son1-son2;
		  		}else
		  		{
		  			son2=son2-son1;
		  		}
		  	}
		  	return son1;
		  }
	}
}