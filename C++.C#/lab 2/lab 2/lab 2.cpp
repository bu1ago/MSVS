#include <iostream>
#include <math.h>
#include <complex>

#define _USE_MATH_DEFINES

using namespace std;
const double PI = 3.14159265358979323846;

class Complex
{
	double mod;		// модуль
	double arg;		// аругумент
	double Re, Im;	// действительная и мнимая часть
public:
	Complex();
	Complex(double mod, double arg);
	Complex(double mod);
	void polar1(Complex& a);  // функция перевода из mod и arg в Re и Im 
	friend void absarg(Complex& a);  // функция перевода из Re и Im в mod и arg
	double real(){return Re;}  // функция возврата Re
	double imag(){return Im;}  // функция возврата Im
	friend Complex cosh(Complex v); // перегрузка гиперболического косинуса для комплексного числа
	friend Complex operator -(Complex& c);  // оператор отрицания (-)
	friend Complex operator -(Complex a, Complex b); // оператор вычитания комплексных чисел
	friend Complex operator *(Complex a, Complex b); // оператор * для комплексных чисел
	friend Complex operator +(Complex, Complex c);  // оператор + для комплексных чисел
	friend ostream& operator <<(ostream& s, Complex c);  // оператор <<
	friend istream& operator >>(istream& s, Complex& c); // оператор >>
	friend bool operator ==(complex <double> z, Complex z1);  // оператор ==
};



Complex yz(Complex z)

{return z*z-cosh(2*z);}

complex <double> yzc(complex <double> z1) 

{return pow(z1,2)-cosh(z1*z1);}

void tabl()
{
cout << "Способ       " << "arg" << "         Real, Imag" << endl;
for (double i = 0; i <= 2 * PI; i += PI / 4)
	{
	Complex z1(1.0, i);
	complex <double> z(polar(1.0, i));
	cout << "Класс        " << i << "    " << yz(z1) << endl;
	cout << "Библиотека            " << yzc(z) << endl;
	}
}

void comparizon()
{
cout << "\nВведи модуль и аргумент\n";
Complex z1;
cin >> z1;
complex <double> z(z1.real(), z1.imag());
z1 = yz(z1);
z = yzc(z);
cout << "Класс      z1 = " << z1 << endl;
cout << "Библиотека  z = " << z << endl;
if (z == z1)
	cout << "--- z  равны z1 ---"<< endl;
else
	cout << "z не равно z1"<< endl;
}


Complex::Complex()
{
this->arg = 0;
this->mod = 0;
polar1(*this);
}

Complex::Complex(double mod, double arg)
{
this->mod = mod;
this->arg = arg;
polar1(*this);
}

Complex::Complex(double mod)
{
this->mod = mod;
this->arg = 0;
polar1(*this);
}

void Complex::polar1(Complex& a)
{
a.Re = a.mod*cos(a.arg);
a.Im = a.mod*sin(a.arg);
}

void absarg(Complex& a)
{
a.mod = sqrt(pow(a.Re, 2) + pow(a.Im, 2));
a.arg = atan(a.Im / a.Re);
}


Complex operator + (Complex a, Complex c)
{
Complex b;
b.Re = a.Re + c.Re;
b.Im = a.Im + c.Im;
return b;
}



Complex operator - (Complex& c)
{
	Complex a;
	a.Re = -c.Re;
	a.Im = -c.Im;
	return a;
}



Complex cosh(Complex v)
{
	Complex a;
	a.Re = cos(v.Re) * cosh(v.Im);
	a.Im = -sin(v.Re) * sinh(v.Im);
	return a;
}

Complex operator - (Complex a, Complex b)
{
	Complex c;
	c.Re = a.Re - b.Re;
	c.Im = a.Im - b.Im;
	return c;
}

Complex operator * (Complex a, Complex b) // перегрузка оператора *
{
	Complex c; 
	c.Re = a.Re * b.Re - a.Im * b.Im;
	c.Im = a.Re * b.Im + a.Im * b.Re;
	return c;
}

ostream& operator <<(ostream& s, Complex c)
{
	s << "(" << c.Re << "," << c.Im << ")";
	return s;
}

istream& operator >> (istream& s, Complex& c)
{
	s >> c.mod >> c.arg;
	c.polar1(c);
	return s;
}

bool operator ==(complex <double> z, Complex z1)
{
	if ((z.real() == z1.real()) && (z.imag() == z1.imag()))
		return false;
	else
		return true;
}

void main(void)
{
	setlocale(LC_ALL, "rus");
	cout.setf(std::ios::fixed);
	cout.precision(3);
	tabl();
	comparizon();
	system("pause");
}