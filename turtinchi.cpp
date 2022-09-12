#include <iostream>
#include<math.h>
using namespace std;
int main() {
	int m;
	cout<<"m ni kiriting: ";
	cin>>m;
	int n;
	cout<<"n ni kiriting: ";
	cin>>n;
	int S=1;
	int Natija;
//	for (int j = 2; j <= m; j++)
//	{
//		for (int i = 3; i <= n; i++)
//		{
//			S=S*i*pow(j,i);
//		}
//		Natija=Natija+S;
//	}
	for (int i = 3; i <= n; i++)
	{
		
		for (int j = 2; j <= m; i++)
		{
			S=S*i*pow(j,i);
			Natija=Natija+S;	
		}
		
		
	}
    cout <<"Natija: "<<Natija;
    return 0;
}
