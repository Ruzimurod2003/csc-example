using System;
namespace Masala 
{
	public class Fibonachi 
	{
	  public static void Main(string[] args) 
	  {
	  	Console.Write("Fibonachining hadini kirgizing: ");
	  	int FibHad=Convert.ToInt32(Console.ReadLine());
	  	Console.Write("\n");
	  	Console.Write("Fibonachining "+FibHad+"- hadi "+FibonachiHisoblash(FibHad)+" ga teng.");
	  	Console.Write("\n");
	  	Console.Write("Chiqish uchun hohlagan tugmani bosing!!!");
	  	Console.ReadKey();
	  }
	  public static int FibonachiHisoblash(int son) 
	  {
	  	if ((son==0)||(son==1)) 
	  	{
	  		return 1;
	  	}else 
	  	{
	  		return (FibonachiHisoblash(son-1)+FibonachiHisoblash(son-2));
	  	}
	  }
	}
}