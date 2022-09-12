#include <iostream>
#include<math.h>
using namespace std;
int main() {
	float z;
	double pi = 2 * acos(0.0); 
	float Natija;
	cout<<"Son kiriting: ";
	cin>>z;
	if (z<(-9))
	{
		Natija=(tan(abs(z+8))*sqrt(abs(z+2)));
	}else if((z>=(-9))and(z<2))
	{
		Natija=pow(abs(z-12),2)*cos(pi)-9;
	}else
	{
		Natija=pow((z-2),(z/3))*sin(z/2);
	}
    cout <<"Natija: "<<Natija;
    return 0;
}
