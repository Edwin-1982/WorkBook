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
	Boy boy1("Rock", 28, 10000, 5);
	int power = boy1;//power();
	char* name = boy1;//"Rock"

	cout << boy1 << endl;
	cout << power << endl;
	cout << name << endl;

	system("pause");
	return 0;
}