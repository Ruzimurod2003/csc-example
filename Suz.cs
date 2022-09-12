using System;
namespace Masala 
{
	public class Suz 
	{
	  public static void Main(string[] args) 
	  {
	  	Console.WriteLine(Aniqla("sdfsdfsdfsxcvbntjfcjnfcawefr"));
	  	Console.ReadKey();
	  }
	  public static string Aniqla(string word)
	  {
	  	ObjectSuz MyObject = new ObjectSuz();
	  	string newWord="";
	  	for (int i=0; i<word.Length-2; i++) 
	  	{
	  		newWord=newWord+MyObject.English.Substring(i,1).ToString()+"("+SuzQaytar(word,MyObject.English.Substring(i,1)).ToString()+") ";
	  	}
	  	return newWord;
	  }
	  public static int SuzQaytar(string suz,string findSuz)
	  {
	  	int k=0;
	  	for (int i=0; i<suz.Length-2; i++) 
	  	{
	  		if (suz.Substring(i,1)==findSuz) 
	  		{
	  			k=k+1;
	  		}
	  	}
	  	return k;
	  }
	}
	public class ObjectSuz
	{
		public string English="qwertyuiopasdfghjklmnbvcxz";

		public string Russian="йцукенгшщзхъфывапролджэячсмитьбюё";

		public string Simvol="`~!@#$%^&*()_+{}:|<>?,.;''№/*-+\"\"";
	}
}