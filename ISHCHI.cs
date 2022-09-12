using System;
using System.Collections.Generic;
using System.Linq;
namespace Masala 
{
	public class ISHCHI 
	{
	  public static void Main(string[] args) 
	  {
	  	string[ , ] Massiv_ISHCHI = new string[3, 4];  int son;son=0;
		Massiv_ISHCHI[0, 0] = "Abdunazarov";
		Massiv_ISHCHI[1, 0] = "15.03.2015";
		Massiv_ISHCHI[2, 0] = "Ishchi"; 
		Massiv_ISHCHI[0, 1] = "Cho'liyev";  
		Massiv_ISHCHI[1, 1] = "24.02.2003";  
		Massiv_ISHCHI[2, 1] = "Direktor";  
		Massiv_ISHCHI[0, 2] = "Sarimsoqov"; 
		Massiv_ISHCHI[1, 2] = "23.03.1998";
		Massiv_ISHCHI[2, 2] = "Ishchi";
		Massiv_ISHCHI[0, 3] = "Temurov";  
		Massiv_ISHCHI[1, 3] = "08.04.2012";  
		Massiv_ISHCHI[2, 3] = "Xisobchi";
	  	Console.Write("Siz ISHCHI tizimida qaysi lavozimni qidirayapsiz: ");
	  	string Lavozim=Console.ReadLine();
	  	Console.Write("\n"+Lavozim+" lavozimidagi shaxslar haqida ma’lumotlar:\n \n");
	  	for (int i=0; i<=3; i++) 
	  	{
	  		if (Massiv_ISHCHI[2,i]==Lavozim) 
	  		{
	  			Console.ForegroundColor = ConsoleColor.Red; Console.Write("Familiya: ");
	  			Console.ForegroundColor = ConsoleColor.White; Console.Write(Massiv_ISHCHI[0,i]+"\n");
	  			Console.ForegroundColor = ConsoleColor.Green; Console.Write("Ishga kirgan vaqt: ");
	  			Console.ForegroundColor = ConsoleColor.White; Console.Write(Massiv_ISHCHI[1,i]+"\n");
	  			Console.ForegroundColor = ConsoleColor.Blue; Console.Write("Lavozimi: ");
	  			Console.ForegroundColor = ConsoleColor.White; Console.Write(Massiv_ISHCHI[2,i]+"\n");
	  		}else
	  		{ son=son+1; }
	  	}
	  	if (son==4) 
	  	{
	  		Console.ForegroundColor = ConsoleColor.Red; Console.Write("Kechirasiz tizimda bunday lavozim mavjud emas!!!"+"\n");
	  	}
	  	Console.Write("\n"); Console.ForegroundColor = ConsoleColor.White; Console.Write("Chiqish uchun hohlagan tugmani bosing!!!");
		Console.ReadKey();
	  }
	}
}