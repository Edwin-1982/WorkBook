#include<iostream>
#include"Boy.h"
int main(void) {
	string line(50, '-');
	Boy boy1("Rock", 38, 58000, 10);
	Boy boy2, boy3;

	cout << boy1.description() << endl;
	cout << boy2.description() << endl;
	cout << boy3.description() << endl;

	cout << "��ֵ�Ժ�:" << endl;
	cout << line << endl;
	boy3 = boy2 = boy1;
	cout << boy1.description() << endl;
	cout << boy2.description() << endl;
	cout << boy3.description() << endl;
	

	/*
	Boy boy1("Rock", 38, 58000, 10);
	Boy boy2("Jack", 35, 50000, 10);
	*/

	/*
	if (boy1 > boy2) {//boy1.operator>(boy2)
		cout << "ѡ��boy1!" << endl;
	}
	else if (boy1 < boy2) {
		cout << "ѡ��boy2!" << endl;
	}
	else if (boy1 == boy2) {
		cout << "���ֲ���,����ѡ��!" << endl;
	}
	else {//boy1<boy2
		cout << "ѡ��boy2" << endl;
	}
	*/
	system("pause");
	return 0;
}