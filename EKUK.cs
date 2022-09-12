using System;
namespace Masala 
{
	public class EKUK
	{
	  public static void Main(string[] args) 
	  {
	  	Console.Write("Birinchi sonni kiriting: ");
	  	int FirstNumber=Convert.ToInt32(Console.ReadLine());
	  	Console.Write("Ikkinchi sonni kiriting: ");
	  	int SecondNumber=Convert.ToInt32(Console.ReadLine());
	  	Console.Write("\n");
	  	Console.Write("EKUK("+FirstNumber+";"+SecondNumber+")="+EKUKHisoblash(FirstNumber,SecondNumber));
	  	Console.Write("\n");
	  	Console.Write("Chiqish uchun hohlagan tugmani bosing!!!");
	  	Console.ReadKey();
	  }
	  public static int EKUKHisoblash(int son1,int son2) 
		  {
		  	int number1=son1;
		  	int number2=son2;
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
		  	return ((number1*number2)/son1);
		  }
	}
}