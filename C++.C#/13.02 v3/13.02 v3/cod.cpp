#include <iostream>
using namespace std;

class vector
{
	private:
	float x,y;
	friend float setx(float,vector);
	friend float sety(float,vector);
	friend void get(vector);
	
	public:
	vector(){x=y=0;}				  //конструктор по умолчанию
	vector(float a){x=y=a;}			  //конструктор преобразования
	vector(float a,float b){x=a;y=b;};//конструктор инициализации значений
		
};
float setx(float a, vector object)
{
	object.x=a;
	return object.x;
}
float sety(float b, vector object)
{
	object.y=b;
	return object.y;
}
void get(vector object)
{
	cout<<object.x<<" "<<object.y<<endl;
}

int main()
{
	setlocale(LC_ALL,"RUSSIAN");
	float a,b;
	do
	{
		cout<<"Введите x и y"<<endl;
		cin>>a>>b;
	}
	while (b<0);
	vector A;
	get(A);	
	vector B = 5;
	get(B);
	vector C(3,4);
	get(C);
	system("pause");
	return 0;
}