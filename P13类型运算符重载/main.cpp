#include<iostream>
#include"Boy.h"

using namespace std;

ostream& operator<<(ostream& os, const Boy& boy) {
	os << "ID:" << boy.id << "\t����:" << boy.name << "\t����:" << boy.age
		<< "\tн��:" << boy.salary << "\t����ϵ��: " << boy.darkHorse << endl;
	return os;
}
istream& operator>>(istream& is, Boy& boy) {
	/*is >>  boy.name >> boy.age
		>> boy.salary >> boy.darkHorse ;*/
	string name2;
	is >> name2 >> boy.age
		>> boy.salary >> boy.darkHorse;
	boy.name = (char*)malloc((name2.length() + 1) * sizeof(char));
	strcpy_s(boy.name, name2.length() + 1, name2.c_str());
	return is;
}
int main(void) {
	Boy boy1 = 10000; //н��  ���캯��Boy(int)
	Boy boy2 = "Rock";//���� ���캯��Boy(char*)
	cout << boy1 << endl;
	cout << boy2 << endl;
	system("pause");
	return 0;
}