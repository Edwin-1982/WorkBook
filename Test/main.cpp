#include<iostream>
#include<windows.h>

using namespace std;

/*******************************************************************************
����͸���Ĺ��캯���ĵ���˳��

�������������ʱ,���캯���ĵ���˳��:
��̬���ݳ�Ա�Ĺ��캯��->���๹�캯��->�Ǿ�̬�����ݳ�Ա�Ĺ��캯��->�Լ��Ĺ��캯��

ע��:
���۴�����������,����ľ�̬��Աֻ����һ��,���Ծ�̬��Ա�Ĺ��캯��ֻ����һ��!!!
********************************************************************************/
class M {
public:
	M() {
		cout << __FUNCTION__<<endl;
	}
	~M() {
		cout << __FUNCTION__ << endl;
	}
};

class N {
public:
	N() { 
		cout << __FUNCTION__<<endl; 
	}
	~N() {
		cout << __FUNCTION__ << endl;
	}
};

class A {
public:
	A() { 
		cout << __FUNCTION__ << endl; 
	}
	~A() {
		cout << __FUNCTION__ << endl;
	}
};
class B:public A {
public:
	B() { 
		cout << __FUNCTION__ << endl; 
	}
	~B() {
		cout << __FUNCTION__ << endl;
	}
private:
	M m1;
	M m2;
	static N ms;
};

N B::ms;//��̬��Ա

int main(void) {
	{
		B b1;
	}

	/*
	cout << "\n\n*****************\n\n"<<endl;
	B b2;
	*/

	system("pause");
	return 0;

}