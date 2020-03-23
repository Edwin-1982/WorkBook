#include<iostream>
#include"Boy.h"

using namespace std;

ostream& operator<<(ostream& os, const Boy& boy) {
	os << "ID:" << boy.id << "\t姓名:" << boy.name << "\t年龄:" << boy.age
		<< "\t薪资:" << boy.salary << "\t黑马系数: " << boy.darkHorse << endl;
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
	Boy boy1 = 10000; //薪资  构造函数Boy(int)
	Boy boy2 = "Rock";//姓名 构造函数Boy(char*)
	cout << boy1 << endl;
	cout << boy2 << endl;
	system("pause");
	return 0;
}