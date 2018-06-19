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
	~Stack();//����������
	Stack(Stack&);//�����������(�� �����������)
	Stack() { top = 0; };//����������� �� ���������
	bool Empty() { return top == NULL; }
	void push(int);//����
	void pop(int);//��������
	int peek ();//��������
	Element* poisk(int);
	friend ostream &operator <<(ostream&, Stack&);//���������� ������� ������, ��� ��� �� ������� �� 1 �������, � ������
	Stack& operator=(Stack&);//���������� ��������� ������������
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
	//������� ��������� �������� ��������
	int peek()
	{
		return current->data;
	}
	//������� �������� � ���������� ��������
	void next()
	{
		current = current->next;
	}
	//������� �������� � ������ ������
	void reset()
	{
		current = D->top;
	}
	//������� ������ �������� ������
	Element* cur()
	{
		return current;
	}
	Element* isEmpty() 
		{
				if (current == 0) return 0;
				else return current;
		}
	//������� �������� �� ��������� ������
	void set(Element*p = 0) { current = p; }
};


//����������
Stack:: ~Stack()
{
	Element* pe = top;//������� �������
	Element* pn = top;//��������� �������
	while (pe != 0)//���� ������� ������� �� ����� 0, �.� ���� ���������� ������
	{
		pn = pe->next;//����. ������� ����� ����. ����� ��������
		delete pe;//������� ������� �������
		pe = pn;//�����������
	}
	top = 0;//������� ��������� �� ������ �������, �.� ��� ���
}
//������� ������ � ���������� ������ �� �����������
Element* Stack::poisk(int x) {
	Element* r = top;//�������� r ����������� �������� ����� ������ ������
	Element* q = 0;//�������� q ����������� 0
	while (r != 0) {//���� r ����������, �.� ���� ���������� ������
		if (x <= r->data)//���� ��� ������� ������ ��� ����� 
			return q;//���������� ���� �������
		else {
			q = r;//���� ��� ������� ���-���� ������, �� ���������� ��� ������
			r = r->next;//������������� �� ��������� �������
		}
	}
	return q;//���������� ���� �������
}
//���������� ��������
void Stack::push(int a)
{
	Element* ptr = new Element(a);//������� ����� �������
	Element *s = poisk(a);//�������� ������� ������
	if (s != 0)//���� ������ ����������
	{
		ptr->next = s->next;//���������� �����(pointer-���������)
		s->next = ptr;//��������� ������� pointer
	}
	else
	{
		ptr->next = top;//����������� ���� next ������ �������� ��������� �� ��� ��-�, ������� ������ ��� ������
		top = ptr;//����������� ���������� top ��� �������=>����� ������� ���� ������
	}
}

//������� ��������
void Stack::pop(int x)
{
Element* r = 0;
if (top == 0) //���� ������ ����������
{
	return;
}
else 
{
	Element* q = poisk(x);//�������� ������� ������ � ��������������

	if (q == 0)
	{
		if (top->data == x) //���� �� ��������, ������� �� ���� �������� � ���������� � ������ ��������
		{
			r = top;//�� ����������� �������� r ������ 0 ������ ������� ������(������)
			top = top->next;//�����������
		}
	}
	else //���� ������ �� ������
	{
		r = q->next;//����������� r ������ 0 ����. �������
		if (r->data == x) //���� ���������� ������ ������ ��������� � ������� ���������
		{
			q->next = r->next;//�� ������������ ������
		}
	}
	delete r;//������� ��������� �������

}
}
//������������� ������ ������� ������ ������
int Stack::peek()
{
	if (top != 0)//���� ������ ������� ����������, �.� ������ �� ����
	{
		return top->data;//���������� ������ ������� ��������
	}
}
Stack::Stack(Stack&s)
{
	if (s.top == 0)//���� ������ ���, �� �����
		return;
	top = new Element(s.peek());//������� ����� ������� � ����������� �� ���� data
	Element* pfrom = s.top->next;//����. pfrom ����������� ��������� �������� ����� top
	Element* pto_new = 0;//����. pto_new ������������ � 0
	Element* pto_old = top;//����-�� pto_old ����������� �������� ������ ����������
	while (pfrom != 0)//���� ������� pfrom �� ����� 0
	{
		pto_new = new Element(pfrom->data);//� ����. pto_new ������� ����� ������� pfrom � ����������� data �� ����
		pto_old->next = pto_new;//����. ����. �� pto_old ��������. ����. ����. pto_new
		pto_old = pto_new;//������ pto_old �����. ����. pto_new
		pfrom = pfrom->next;//����. pfrom ����������� ����. �������� ����� pfrom
	}
}
//���������� ��������� ������ ��� ����, ����� ������� ���� ������ ����� �������
ostream &operator <<(ostream&s, Stack&oper)
{
	if (!oper.Empty())//���� ������ �� ������
	if (oper.top!=0)//���� ������ ������� �� ����� 0
	{
		cout << "[";//��������� [
		Element* p = oper.top;
		while (p)//���� ���������� p
		{
			s << p->data << " ";//�������  ������ ���� �����(�� �����)
			p = p->next;//�� ���� ������ ���������� ������ p �� ��������� ������� ������
		}
		cout << "]";//��������� ]
	}
	else
		cout << "�����������";//���� ������ ����, �� ������� ��������� �� ����
	return s;
}
Stack &Stack::operator=(Stack& s)
{
	if (this == &s)
		return *this;
	Element* pe = top;//������� �������
	Element* pn = top;//��������� �������
	while (pe != 0)//���� ������� ������� �� ����� 0, �.� ���� ���������� ������
	{
		pn = pe->next;//����. ������� ����� ����. ����� ��������
		delete pe;//������� ������� ����.
		pe = pn;//�����������
	}
	top = 0;//������� ��������� �� ������ �������, �.� ��� ���
	new(this) Stack(s);
	return*this;
}
//������� ���������� ������������� �����
int find(int elem1, Stack& ochered)
{
	Iterator m(ochered);
	int elem2;
	for (m.reset(); m.isEmpty() != 0; m.next())//for(������ ������;���� ��������� �� ������;��������� � ����. ��������)
	{
		elem2 = m.peek();//��������� �������
		if (elem1 == elem2) //���� �������1 ����� �������2
			return 1;
	}
	return 0;
}

int main()
{
	setlocale(LC_ALL, "rus");
	Stack a;//������� ������ �
	a.push(50);//���� ��������
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
	cout << "�������� ������ �� �����������: " << a << endl;//����� ������
	a.pop(20);//������� ��������
	a.pop(234);
	a.pop(70);
	a.pop(32);
	a.pop(30);
	cout << "����� �������� ����� 20, 30, 32, 70, 234: " << a << endl;
	Iterator m(a);//������� ������ � �������� ������ �� �
	int elem1 = m.peek();//���������� ������
	Stack b;//������� ������ b
	b.push(elem1);//���������� ����
	for (m.next(); m.isEmpty() != 0; m.next())//for(����. �������; ��������� �� ������; ����. �������)
	{
		elem1 = m.peek();//���������� ������� �������
		if (find(elem1, b) == 0)//���� ������� ������������� ��������
			b.push(elem1);//���������� ����
	}
	cout << "������ ����� ������������: " << b;//�����
	_getch();
}