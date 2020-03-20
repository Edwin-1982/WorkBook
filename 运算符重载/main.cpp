#include<iostream>
#include"Cow.h"
#include"Horse.h"
#include"Pork.h"

int main(void) {
	Cow c1(100);
	Cow c2(200);

	//此时调用的是:c1.operator+(c2)
	//Pork p = c1 + c2;
	Pork p = c1.operator+(c2);
	cout << p.description() << endl;
	Horse h1(100);
	p = c1 + h1;
	cout << p.description() << endl;

	system("pause");
	return 0;
}