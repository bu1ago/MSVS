#include <iostream>
#include <conio.h>
using namespace std;

class Element
{
private:
	int data;
	Element* next;
public:
	Element(int a)
	{
		data = a;
		next = 0;
	}
	friend class Stack;
	friend class Iterator;
	friend ostream &operator << (ostream &s, Stack &lst);
};

class Stack
{
private:
	Element* top;
public:
	~Stack();//Деструктор
	Stack(Stack&);//Конструктор(не понадобится)
	Stack() { top = 0; };//Конструктор по умолчанию
	bool Empty() { return top == NULL; }
	void push(int);//Ввод
	void pop(int);//Удаление
	int peek ();//Просмотр
	Element* poisk(int);
	friend ostream &operator <<(ostream&, Stack&);//Перегрузка функции вывода, так как мы выводим на 1 элемент, а список
	Stack& operator=(Stack&);//Перегрузка оператора присваивания
	friend class Iterator;
};
class Iterator
{
private:
	Stack *D;
	Element* current;
public:
	Iterator(Stack& d) 
	{
		D = &d;
		current = d.top;
	}
	//Функция просмотра текущего элемента
	int peek()
	{
		return current->data;
	}
	//Функция перехода к следующему элементу
	void next()
	{
		current = current->next;
	}
	//Функция перехода в начало списка
	void reset()
	{
		current = D->top;
	}
	//Функуия выдачи текущего адреса
	Element* cur()
	{
		return current;
	}
	Element* isEmpty() 
		{
				if (current == 0) return 0;
				else return current;
		}
	//Функция перехода по заданному адресу
	void set(Element*p = 0) { current = p; }
};


//Деструктор
Stack:: ~Stack()
{
	Element* pe = top;//Текущий элемент
	Element* pn = top;//Следующий элемент
	while (pe != 0)//Пока текущий элемент на равен 0, т.е пока существует список
	{
		pn = pe->next;//След. элемент равен след. после текущего
		delete pe;//Удаляем текущий элемент
		pe = pn;//Передвигаем
	}
	top = 0;//Очищаем указатель на первый элемент, т.к его нет
}
//Функция поиска и сортировки списка по возрастанию
Element* Stack::poisk(int x) {
	Element* r = top;//Элементу r присваиваем значение самой первой ячейки
	Element* q = 0;//Элементу q присваиваем 0
	while (r != 0) {//Пока r существует, т.е пока существует список
		if (x <= r->data)//Если наш элемент меньше или равен 
			return q;//Возвращаем этот элемент
		else {
			q = r;//Если наш элемент все-таки больше, то перемещаем его вперед
			r = r->next;//Передвигаемся на следующий элемент
		}
	}
	return q;//Возвращаем этот элемент
}
//Добавление элемента
void Stack::push(int a)
{
	Element* ptr = new Element(a);//Создаем новый элемент
	Element *s = poisk(a);//Вызываем функцию поиска
	if (s != 0)//Если список существует
	{
		ptr->next = s->next;//Перемещаем адрес(pointer-указатель)
		s->next = ptr;//Вставляем элемент pointer
	}
	else
	{
		ptr->next = top;//Присваиваем полю next нового элемента указатель на тот эл-т, который раньше был первым
		top = ptr;//Присваиваем переменной top наш элемент=>новый элемент стал первым
	}
}

//Функция удаления
void Stack::pop(int x)
{
Element* r = 0;
if (top == 0) //Если список существует
{
	return;
}
else 
{
	Element* q = poisk(x);//Вызываем функцию поиска и упорядочивания

	if (q == 0)
	{
		if (top->data == x) //Если то значение, которое мы ищем совпадет с информации в первом элементе
		{
			r = top;//То присваиваем элементу r вместо 0 первый элемент списка(ячейку)
			top = top->next;//Передвигаем
		}
	}
	else //Если список не пустой
	{
		r = q->next;//Присваиваем r вместо 0 след. элемент
		if (r->data == x) //Если содержимое ячейки списка совпадает и искомым элементом
		{
			q->next = r->next;//То перемещаемся вперед
		}
	}
	delete r;//Удаляем найденный элемент

}
}
//Просматриваем первый элемент нашего списка
int Stack::peek()
{
	if (top != 0)//Если первый элемент существует, т.е список не пуст
	{
		return top->data;//Возвращаем данные первого элемента
	}
}
Stack::Stack(Stack&s)
{
	if (s.top == 0)//Если списка нет, то конец
		return;
	top = new Element(s.peek());//Создаем новый элемент и вытаскиваем из него data
	Element* pfrom = s.top->next;//Элем. pfrom присваиваем следующее значение после top
	Element* pto_new = 0;//Элем. pto_new приравниваем к 0
	Element* pto_old = top;//Элем-ту pto_old присваиваем значение первой переменной
	while (pfrom != 0)//Пока элемент pfrom не равен 0
	{
		pto_new = new Element(pfrom->data);//В элем. pto_new создаем нвоый элемент pfrom и присваиваем data из него
		pto_old->next = pto_new;//След. элем. за pto_old присваив. знач. элем. pto_new
		pto_old = pto_new;//Самому pto_old присв. знач. pto_new
		pfrom = pfrom->next;//Элем. pfrom присваиваем знач. элемента после pfrom
	}
}
//Перегрузка оператора вывода для того, чтобы вывести весь список одной строкой
ostream &operator <<(ostream&s, Stack&oper)
{
	if (!oper.Empty())//Пока список не пустой
	if (oper.top!=0)//Пока первый элемент не равен 0
	{
		cout << "[";//Открываем [
		Element* p = oper.top;
		while (p)//Пока существует p
		{
			s << p->data << " ";//Выводим  данные всех ячеек(по одной)
			p = p->next;//По сути просто перемещаем объект p на следующий элемент списка
		}
		cout << "]";//Закрываем ]
	}
	else
		cout << "отсутствуют";//Если список пуст, то выводим сообщение об этом
	return s;
}
Stack &Stack::operator=(Stack& s)
{
	if (this == &s)
		return *this;
	Element* pe = top;//Текущий элемент
	Element* pn = top;//Следующий элемент
	while (pe != 0)//Пока текущий элемент на равен 0, т.е пока существует список
	{
		pn = pe->next;//След. элемент равен след. после текущего
		delete pe;//Удаляем текущий элем.
		pe = pn;//Передвигаем
	}
	top = 0;//Очищаем указатель на первый элемент, т.к его нет
	new(this) Stack(s);
	return*this;
}
//Функуия нахождения повторяющихся чисел
int find(int elem1, Stack& ochered)
{
	Iterator m(ochered);
	int elem2;
	for (m.reset(); m.isEmpty() != 0; m.next())//for(начало списка;пока множество не пустое;переходим к след. элементу)
	{
		elem2 = m.peek();//считываем элемент
		if (elem1 == elem2) //Если элемент1 равен элемент2
			return 1;
	}
	return 0;
}

int main()
{
	setlocale(LC_ALL, "rus");
	Stack a;//Создаем объект а
	a.push(50);//Ввод значение
	a.push(70);
	a.push(20);
	a.push(17);
	a.push(32);
	a.push(30);
	a.push(235);
	a.push(235);
	a.push(234);
	a.push(3);
	a.push(0);
	cout << "Элементы списка по возрастанию: " << a << endl;//Вывод списка
	a.pop(20);//Удаляем элементы
	a.pop(234);
	a.pop(70);
	a.pop(32);
	a.pop(30);
	cout << "После удаления чисел 20, 30, 32, 70, 234: " << a << endl;
	Iterator m(a);//Создаем объект и получаем ссылку на а
	int elem1 = m.peek();//Записываем список
	Stack b;//Создаем объект b
	b.push(elem1);//Записываем стэк
	for (m.next(); m.isEmpty() != 0; m.next())//for(След. элемент; множество не пустое; след. элемент)
	{
		elem1 = m.peek();//Используем функцию доступа
		if (find(elem1, b) == 0)//Если нашлись повторяющиеся элементы
			b.push(elem1);//Записываем стэк
	}
	cout << "Список после итерирования: " << b;//Вывод
	_getch();
}