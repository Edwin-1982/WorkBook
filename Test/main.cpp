#include<iostream>
#include<windows.h>

using namespace std;

/*******************************************************************************
子类和父类的构造函数的调用顺序

当创建子类对象时,构造函数的调用顺序:
静态数据成员的构造函数->父类构造函数->非静态的数据成员的构造函数->自己的构造函数

注意:
无论创建几个对象,该类的静态成员只构建一次,所以静态成员的构造函数只调用一次!!!
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

N B::ms;//静态成员

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