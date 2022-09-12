using System;  
namespace Masala 
{
    public class KvadratTenglama 
    {  
        public static void Main() 
        {  
            double a, b, c;  
            double Diskirminat, Mahraj, x1, x2 , x;  
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("a koifitsentini kiriting: ");  
            a = Convert.ToDouble(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("b koifitsentini kiriting: ");   
            b = Convert.ToDouble(Console.ReadLine()); 
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("c koifitsentini kiriting: ");  
            c = Convert.ToDouble(Console.ReadLine());  
            if (a == 0) 
            {  
                x = (-c / b);  
                Console.ForegroundColor = ConsoleColor.Red; Console.Write("\nKvadrat tenglama chiziqli va uning ildizi "+ x + " ga teng.");  
            } else 
            {  
                Diskirminat = ((b * b) - (4 * a * c));  
                Mahraj = (2 * a);  
                if (Diskirminat > 0) 
                {  
                    Console.ForegroundColor = ConsoleColor.Red; Console.Write("\nKvadrat tenglama ikkita Haqiqiy ildizga ega.");  
                    x1 = (-b / Mahraj) + (Math.Sqrt(Diskirminat) / Mahraj);  
                    x2 = (-b / Mahraj) - (Math.Sqrt(Diskirminat) / Mahraj);  
                    Console.ForegroundColor = ConsoleColor.Blue; Console.Write("\nBu ildizlar " + x1 + " va " + x2+" ildizlar hisoblanadi.");  
                } else if (Diskirminat == 0) 
                {  
                    Console.ForegroundColor = ConsoleColor.Red; Console.Write("\nKvadrat tenglama bitta Haqiyqiy ildizga ega.");  
                    x = (-b / Mahraj);  
                    Console.ForegroundColor = ConsoleColor.Blue; Console.Write("\nU ildiz " + x + " ga teng.");  
                } else 
                {  
                    Console.ForegroundColor = ConsoleColor.Blue; Console.Write("\nKvadrat tenglama Complex sonlarda yechimga ega.");  
                    x1 = (-b / Mahraj);  
                    x2 = ((Math.Sqrt((4 * a * c) - (b * b))) / Mahraj);  
                    Console.ForegroundColor = ConsoleColor.Red; Console.Write("\nBirinchi ildizi: " + x1 + "+" + x2+"*i");  
                    Console.ForegroundColor = ConsoleColor.Green; Console.Write("\nIkkinchi ildizi: " + x1 + "-" + x2+"*i");  
                }  
            }  
            Console.ForegroundColor = ConsoleColor.White; Console.Write("\n\nChiqish uchun hohlagan tugmani bosing!!!");
            Console.ReadKey();  
        }  
    } 
}
