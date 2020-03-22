#include<iostream>
#include"Boy.h"

using namespace std;

ostream& operator<<(ostream& os, const Boy& boy) {
	os << "ID:" << boy.id << "\t姓名:" <<boy.name << "\t年龄:" << boy.age
		<< "\t\t薪资:" << boy.salary << "\t黑马系数:" << boy.darkHorse << endl;
	return os;
}
istream& operator>>(istream& is, Boy& boy){
	/*is >>  boy.name >> boy.age
		>> boy.salary >> boy.darkHorse ;*/
	string name2;
	is >>  name2 >> boy.age
		>> boy.salary >> boy.darkHorse ;
	boy.name = (char*)malloc((name2.length() + 1) * sizeof(char));
	strcpy_s(boy.name, name2.length() + 1, name2.c_str());
	return is;
}
int main(void) {
	string line(50, '-');
	
	Boy boy1("Rock", 38, 58000, 5);
	Boy boy2("Jack", 25, 50000, 10);

	cout << "age:" << boy1[AGE_KEY] << endl;
	cout << "salary:" << boy1[SALARY_KEY] << endl;
	cout << "darkHorse:" << boy1[DARK_HORSE_KEY] << endl;
	cout << "power:" << boy1[POWER_KEY] << endl;
	
	cout << line << endl;
	cout << "age:" << boy1[AGE] << endl;
	cout << "salary:" << boy1[SALARY] << endl;
	cout << "darkHorse:" << boy1[DARK_HORSE] << endl;
	cout << "power:" << boy1[POWER] << endl;
	
	cout << line << endl;
	cout << boy1 << endl;
	cout << boy1 << endl << boy2 << endl;
	
	cout << line << endl;
	cout << boy1 << endl;
	cout << "请输入信息(姓名 年龄 薪资黑马系数):";
	cin >> boy1;
	cout << boy1;

	//boy1 << cout;
	system("pause");
	return 0;
}