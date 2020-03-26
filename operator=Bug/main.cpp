#include<iostream>
#include"Boy.h"
int main(void) {
	string line(50, '-');
	Boy boy1("Rock", 38, 58000, 10);
	Boy boy2, boy3;

	cout << boy1.description() << endl;
	cout << boy2.description() << endl;
	cout << boy3.description() << endl;

	cout << "赋值以后:" << endl;
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
		cout << "选择boy1!" << endl;
	}
	else if (boy1 < boy2) {
		cout << "选择boy2!" << endl;
	}
	else if (boy1 == boy2) {
		cout << "不分伯仲,难以选择!" << endl;
	}
	else {//boy1<boy2
		cout << "选择boy2" << endl;
	}
	*/
	system("pause");
	return 0;
}