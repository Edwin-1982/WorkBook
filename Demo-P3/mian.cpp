#include<iostream>
#include<Windows.h>
#include"Car.h"

int main(void) {
	{
		Car car("±¦Âí", "X7", 950000, "±¦Âí", 3.5);
		cout << car.description() << endl;
	}
	system("pause");
	return 0;
}