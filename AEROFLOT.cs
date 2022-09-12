using System;
using System.Collections.Generic;
using System.Linq;
namespace Masala 
{
	public class AEROFLOT 
	{
	  public static void Main(string[] args) 
	  {
	  	string[ , ] Massiv_AEROFLOT = new string[3, 4];  int son;son=0;
		Massiv_AEROFLOT[0, 0] = "Uzbekistan";
		Massiv_AEROFLOT[1, 0] = "15.03.2021";
		Massiv_AEROFLOT[2, 0] = "Boing 420"; 
		Massiv_AEROFLOT[0, 1] = "Germany";  
		Massiv_AEROFLOT[1, 1] = "24.02.2021";  
		Massiv_AEROFLOT[2, 1] = "Boing 427";  
		Massiv_AEROFLOT[0, 2] = "India"; 
		Massiv_AEROFLOT[1, 2] = "23.03.2021";
		Massiv_AEROFLOT[2, 2] = "Boing 420";
		Massiv_AEROFLOT[0, 3] = "India";  
		Massiv_AEROFLOT[1, 3] = "08.04.2021";  
		Massiv_AEROFLOT[2, 3] = "Boing 415";
	  	Console.Write("Siz AEROFLOT tizimida qayerga bormoqchisiz: ");
	  	string ReysningManzilPunkti=Console.ReadLine();
	  	Console.Write("\n"+ReysningManzilPunkti+" ga boruvchi samalyotlar haqida ma’lumotlar\n \n");
	  	for (int i=0; i<=3; i++) 
	  	{
	  		if (Massiv_AEROFLOT[0,i]==ReysningManzilPunkti) 
	  		{
	  			Console.ForegroundColor = ConsoleColor.Red; Console.Write("Samalyotning oxirgi manzili: ");
	  			Console.ForegroundColor = ConsoleColor.White; Console.Write(Massiv_AEROFLOT[0,i]+"\n");
	  			Console.ForegroundColor = ConsoleColor.Green; Console.Write("Yetib borish vaqti: ");
	  			Console.ForegroundColor = ConsoleColor.White; Console.Write(Massiv_AEROFLOT[1,i]+"\n");
	  			Console.ForegroundColor = ConsoleColor.Blue; Console.Write("Samalyotning turi: ");
	  			Console.ForegroundColor = ConsoleColor.White; Console.Write(Massiv_AEROFLOT[2,i]+"\n");
	  		}else
	  		{ son=son+1; }
	  	}
	  	if (son==4) 
	  	{
	  		Console.ForegroundColor = ConsoleColor.Red; Console.Write("Bunday reysda samalyot uchmaydi"+"\n");
	  	}
	  	Console.Write("\n"); Console.ForegroundColor = ConsoleColor.White; Console.Write("Chiqish uchun hohlagan tugmani bosing!!!");
		Console.ReadKey();
	  }
	}
}