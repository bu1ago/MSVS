#include <iostream>
using namespace std;

class vector
{
	private:
	float x,y;
	friend void set(float,float,vector&);
	friend void get(vector&);
	
	public:
	vector(){x=y=0;}				  //конструктор по умолчанию
	vector(float a){x=y=a;}			  //конструктор преобразования
	vector(float a,float b){x=a;y=b;};//конструктор инициализации значений
		
};
void set(float a, float b, vector& object)
{
	object.x=a;
	object.y=b;
}
void get(vector& object)
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