#include <iostream>
#include <conio.h>

using namespace std;

class DVector {

private:
	double* data;
	int size;

public:
	DVector(); //конструктор по умолчанию
	DVector(int);
	DVector(DVector&); //конструктор копирования
	~DVector(); //деструктор
	DVector(double *a, int size1) {data = a; size = size1;}
	DVector& operator=(const DVector&); //перегрузка операции присваивания
	double&	operator[](int); //перегрузка операции индексаций
	friend DVector operator-(DVector, DVector); //перегрузка операции вычитания
	friend DVector operator *(double, DVector&); //перегрузка операции умножения
	friend DVector operator /(DVector&, double); //перегрузка операции деления
	friend istream&	operator >> (istream&, DVector&); //перегрузка операции ввода
	friend ostream&	operator <<(ostream&, DVector&); //перегрузка операции вывода
	friend bool operator ==(DVector &A, DVector &B); //перегрузка операции сравнения
};
