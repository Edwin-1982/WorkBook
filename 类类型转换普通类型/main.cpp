#include<iostream>
#include"Boy.h"
#include"Man.h"

using namespace std;


int main(void) {
	Boy boy("Rock", 28, 10000, 5);
	Man man = boy;

	cout << boy << endl;
	cout << man << endl;


	system("pause");
	return 0;
}