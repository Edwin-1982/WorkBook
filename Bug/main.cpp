#include<iostream>
#include"Boy.h"

using namespace std;

int main(void) {
	string line(50, '-');

	const Boy boy("Rock", 38, 58000, 5);

	//const����ֻ�ܵ���const����
	cout << line << endl;
	cout << boy[0] << endl;

	system("pause");
	return 0;
}