#include<iostream>
#include"Boy.h"

using namespace std;

ostream& operator<<(ostream& os, const Boy& boy) {
	os << "ID:" << boy.id << "\t����:" <<boy.name << "\t����:" << boy.age
		<< "\t\tн��:" << boy.salary << "\t����ϵ��:" << boy.darkHorse << endl;
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
	cout << "��������Ϣ(���� ���� н�ʺ���ϵ��):";
	cin >> boy1;
	cout << boy1;

	//boy1 << cout;
	system("pause");
	return 0;
}