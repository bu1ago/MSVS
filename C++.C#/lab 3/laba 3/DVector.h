#include <iostream>
#include <conio.h>

using namespace std;

class DVector {

private:
	double* data;
	int size;

public:
	DVector(); //����������� �� ���������
	DVector(int);
	DVector(DVector&); //����������� �����������
	~DVector(); //����������
	DVector(double *a, int size1) {data = a; size = size1;}
	DVector& operator=(const DVector&); //���������� �������� ������������
	double&	operator[](int); //���������� �������� ����������
	friend DVector operator-(DVector, DVector); //���������� �������� ���������
	friend DVector operator *(double, DVector&); //���������� �������� ���������
	friend DVector operator /(DVector&, double); //���������� �������� �������
	friend istream&	operator >> (istream&, DVector&); //���������� �������� �����
	friend ostream&	operator <<(ostream&, DVector&); //���������� �������� ������
	friend bool operator ==(DVector &A, DVector &B); //���������� �������� ���������
};
