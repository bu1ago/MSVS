#include <iostream>
using namespace std;

class vector
{
	float x,y;
	public:
	vector();		  //конструктор по умолчанию
	vector(float a);		  //конструктор преобразования
	vector(float a,float b);//конструктор инициализации значений
	void vvod();
	void vivod();
	bool check();
};
vector::vector()
{
	x=y=0;
}
vector::vector(float a)
{
	x=y=a;
}
vector::vector(float a, float b)
{
	x=a; y=b;
}
void vector::vvod()
{
	cin>>x>>y;
}
void vector::vivod()
{
	cout<<x<<" "<<y<<endl;
}
bool vector::check()
{
	return (y>=0);
}
int main()
{
	setlocale(LC_ALL,"RUSSIAN");
	vector A;
	cout<<"Введите координаты х и y"<<endl;
	A.vvod();
	if(A.check() == true)
	{
		cout<<"Конструктор по умолчанию"<<endl;
		A.vivod();
	}
	else cout<<"Ошибка ввода"<<endl;
	vector B = 5;
	cout<<"Конструктор преобразования"<<endl;
	B.vivod();
	vector C(3,6);
	cout<<"Конструктор инициализации значений"<<endl;
	C.vivod();
	system("pause");
	return 0;
}