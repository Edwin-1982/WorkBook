#include<iostream>

using namespace std;

/************************************************************
����Ҫ���������κεط�,����ʹ��"��������"������Ķ��������
�Ӷ�����ʹ����ͬ�ĺ���ͳһ����������͹������������
��:�β�Ϊ�������ʱ,ʵ�ο��������������.
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