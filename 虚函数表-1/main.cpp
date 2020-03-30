#include<iostream>
#include"Son.h"

using namespace std;

typedef void(*func_t)(void);

string line(25, '-');

void testFather() {
	Father father;
	cout << "sizeof(father)==" << sizeof(father) << endl;
	cout << "对象地址: " << (_int64*)&father << endl;
	_int64* vptr = (_int64*)*(_int64*)(&father);

	cout << "调用第一个虚函数: ";
	((func_t) * (vptr + 0))();

	cout << "调用第二个虚函数: ";
	((func_t) * (vptr + 1))();

	cout << "调用第三个虚函数: ";
	((func_t) * (vptr + 2))();

	cout << "第一个数据成员的地址:" << endl;
	cout << &father.x << endl;
	cout << hex << (_int64)&father + 8 << endl;
	cout << "第一个数据成员的值:" << endl;
	cout << dec << father.x << endl;
	cout << *(_int64*)((_int64)&father + 8) << endl;

	cout << "第二个数据成员的地址:" << endl;
	cout << &father.y << endl;
	cout << hex << (_int64)&father + 16 << endl;
	cout << "第二个数据成员的值:" << endl;
	cout << dec << father.y << endl;
	cout << *(_int64*)((_int64)&father + 16) << endl;
}

void testSon() {
	Son son;
	Father* father = &son;
	father->func1();
	cout << "son对象地址：" << (_int64*)&son << endl;

	_int64* vptr = (_int64*) * (_int64*)&son;

	cout << "第一个虚函数表指针vptr:" << vptr << endl;

	for (_int64 i = 0; i < 4; i++) {
		cout << "调用第" << i + 1 << "个虚函数：";
		((func_t) * (vptr + i))();
	}
	for (_int64 i = 0; i < 2; i++) {
		cout << *(_int64*)((_int64)&son + 8 + i * 8) << endl;
	}

	cout << "sizeof(son)==" << sizeof(son) << endl;
	
	cout << line << "分割" << line << endl;
	
	_int64* vptr_1 = (_int64*)*((_int64*)&son +3);

	cout << "第二个虚函数表指针vptr_1:" << vptr_1 << endl;

	for (_int64 i = 0; i < 3; i++) {
		cout << "调用第" << i + 1 << "个虚函数:";
		((func_t) * (vptr_1 + i))();
	}
	for (_int64 i = 0; i < 2; i++) {
		cout << *(_int64*)((_int64)&son + 32 + i * 8) << endl;
	}
	cout << "sizeof(son)==" << sizeof(son) << endl;
}
int main(void) {
	testFather();
	cout << line << "分割" << line << endl;
	testSon();
	system("pause");
	return 0;
}