#include "Dvector.h"

using namespace std;

DVector::DVector() {
	size = 4;
	data = new double[size];
	for (int i = 0; i < 4; i++)
		data[i] = 0;
}

DVector::DVector(int n) {
	data = new double[n];
	size = n;
	for (int i = 0; i < n; i++)
		data[i] = 0;
}

DVector::DVector(DVector& obj) {
	data = new double[size = obj.size];
	for (int i = 0; i<size; i++)
		data[i] = obj.data[i];
}

DVector::~DVector() {
	delete[]data;
}

double& DVector::operator[](int a) {
	if (a >= 0 && a<size)
		return data[a];
}


DVector& DVector::operator=(const DVector &V) {
	if (this == &V) return *this;
	delete[]data;
	data = new double[size = V.size];
	for (int i = 0; i<size; i++)
		data[i] = V.data[i];
	return *this;
}


DVector operator-(DVector x, DVector y) {
	int n;
	if (x.size>y.size)
		n = x.size;
	else
		n = y.size;
	DVector z(n);
	for (int i = 0; i<x.size; i++)
		z.data[i] += x.data[i];
	for (int i = 0; i<y.size; i++)
		z.data[i] -= y.data[i];
	return z;
}

DVector operator /(DVector& a, double x)
{
	double *vec = new double[a.size];
	for (int i = 0; i < a.size; i++)
		vec[i] = a[i] / x;
	return DVector(vec, a.size);
}

DVector operator *(double x, DVector &a)
{
	double *vec = new double[a.size];
	for (int i = 0; i < a.size; i++)
		vec[i] = x * a[i];
	return DVector(vec, a.size);
}

istream& operator >> (istream& s, DVector& V) {
	for (int i = 0; i < V.size; i++)
		s >> V.data[i];
	return s;
}

ostream& operator <<(ostream& s, DVector& V) {
	s << "{";
	for (int i = 0; i < V.size - 1; i++)
		s << V.data[i] << ", ";
	s << V.data[V.size - 1] << "}";
	return s;
}

