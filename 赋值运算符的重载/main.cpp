#include<iostream>
#include"Boy.h"
int main(void) {
	Boy boy1("Rock", 38, 58000, 10);
	Boy boy2, boy3;

	cout << boy1.description() << endl;
	cout << boy2.description() << endl;
	cout << boy3.description() << endl;

	cout << "¸³ÖµÒÔºó:" << endl;
	boy3 = boy2 = boy1;
	cout << boy1.description() << endl;
	cout << boy2.description() << endl;
	cout << boy3.description() << endl;

	system("pause");
	return 0;
}