#include<iostream>
using namespace std;
int main()
{
	int New[sizeof(int)];
	New=Fib_Sonlar(1300); length(New) sizeof()
	for(int m=1;m<=sizeof(New[])/sizeof(New[0]);m++)
	{
		cout<<New[i]<<"  ";
	}
}
int Fibonachi1(int son) 
{
	if (son == 1 || son == 2) 
	{return 1; }
	else 
	{return Fibonachi1(son - 1) + Fibonachi1(son - 2);} 
}
int** Fib_Sonlar(int last)
{
	int t = 0;
	int[] Sonlar;
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
		Sonlar[i]=(Fibonachi1(i));
	}
	return Sonlar;
}

