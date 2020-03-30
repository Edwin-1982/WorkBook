#include<iostream>
#include"Son.h"

using namespace std;

typedef void(*func_t)(void);

string line(25, '-');

void testFather() {
	Father father;
	cout << "sizeof(father)==" << sizeof(father) << endl;
	cout << "�����ַ: " << (_int64*)&father << endl;
	_int64* vptr = (_int64*)*(_int64*)(&father);

	cout << "���õ�һ���麯��: ";
	((func_t) * (vptr + 0))();

	cout << "���õڶ����麯��: ";
	((func_t) * (vptr + 1))();

	cout << "���õ������麯��: ";
	((func_t) * (vptr + 2))();

	cout << "��һ�����ݳ�Ա�ĵ�ַ:" << endl;
	cout << &father.x << endl;
	cout << hex << (_int64)&father + 8 << endl;
	cout << "��һ�����ݳ�Ա��ֵ:" << endl;
	cout << dec << father.x << endl;
	cout << *(_int64*)((_int64)&father + 8) << endl;

	cout << "�ڶ������ݳ�Ա�ĵ�ַ:" << endl;
	cout << &father.y << endl;
	cout << hex << (_int64)&father + 16 << endl;
	cout << "�ڶ������ݳ�Ա��ֵ:" << endl;
	cout << dec << father.y << endl;
	cout << *(_int64*)((_int64)&father + 16) << endl;
}

void testSon() {
	Son son;
	Father* father = &son;
	father->func1();
	cout << "son�����ַ��" << (_int64*)&son << endl;

	_int64* vptr = (_int64*) * (_int64*)&son;

	cout << "��һ���麯����ָ��vptr:" << vptr << endl;

	for (_int64 i = 0; i < 4; i++) {
		cout << "���õ�" << i + 1 << "���麯����";
		((func_t) * (vptr + i))();
	}
	for (_int64 i = 0; i < 2; i++) {
		cout << *(_int64*)((_int64)&son + 8 + i * 8) << endl;
	}

	cout << "sizeof(son)==" << sizeof(son) << endl;
	
	cout << line << "�ָ�" << line << endl;
	
	_int64* vptr_1 = (_int64*)*((_int64*)&son +3);

	cout << "�ڶ����麯����ָ��vptr_1:" << vptr_1 << endl;

	for (_int64 i = 0; i < 3; i++) {
		cout << "���õ�" << i + 1 << "���麯��:";
		((func_t) * (vptr_1 + i))();
	}
	for (_int64 i = 0; i < 2; i++) {
		cout << *(_int64*)((_int64)&son + 32 + i * 8) << endl;
	}
	cout << "sizeof(son)==" << sizeof(son) << endl;
}
int main(void) {
	testFather();
	cout << line << "�ָ�" << line << endl;
	testSon();
	system("pause");
	return 0;
}