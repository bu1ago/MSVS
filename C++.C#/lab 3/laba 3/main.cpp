#include "DVector.h"

void main()
{
	setlocale(LC_ALL, "Russian");
	DVector U(4);
	DVector V(4);

	double x;
	cout << "������� �: ";
	cin >> x;

	for (int i = 0; i < 4; i++)
	{
		cout << "������� " << i << " ������� ������� U: ";
		cin >> U[i];
		cout << "������� " << i << " ������� ������� V: ";
		cin >> V[i];
	}

	cout << endl << "������ U " << U << endl;
	cout << "������ V " << V << endl;

	DVector Y;
	DVector Z;

	Y = x * V - U / 2;
	Z = V[2] * U -  2 * V;


	cout << endl << "������ Y = x * V - U / 2 = " << Y << endl;
	cout << "������ Z = V[2] * U - 2 * V = " << Z << endl;

	getch();
}