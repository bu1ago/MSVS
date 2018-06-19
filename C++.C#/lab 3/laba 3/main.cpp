#include "DVector.h"

void main()
{
	setlocale(LC_ALL, "Russian");
	DVector U(4);
	DVector V(4);

	double x;
	cout << "Введите х: ";
	cin >> x;

	for (int i = 0; i < 4; i++)
	{
		cout << "Введите " << i << " элемент вектора U: ";
		cin >> U[i];
		cout << "Введите " << i << " элемент вектора V: ";
		cin >> V[i];
	}

	cout << endl << "Вектор U " << U << endl;
	cout << "Вектор V " << V << endl;

	DVector Y;
	DVector Z;

	Y = x * V - U / 2;
	Z = V[2] * U -  2 * V;


	cout << endl << "Вектор Y = x * V - U / 2 = " << Y << endl;
	cout << "Вектор Z = V[2] * U - 2 * V = " << Z << endl;

	getch();
}