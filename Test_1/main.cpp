#include<iostream>

using namespace std;

/************************************************************
在需要父类对象的任何地方,可以使用"共有派生"的子类的对象来替代
从而可以使用相同的函数统一处理基类对象和公有派生类对象
即:形参为基类对象时,实参可以是派生类对象.
*************************************************************/

class A {
public:
	A(){}
	~A(){}
	void kill(){
		cout << "A kill." << endl;
	}
};

class B : public A {
public:
	B(){}
	~B(){}
	void kill() { cout << "B.kill."<< endl; 
	}
};

void test(A a) {
	a.kill();
}
int main(void) {
	A a;
	B b;
	test(b);
	test(a);
	system("pause");
	return 0;
}