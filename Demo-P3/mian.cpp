#include<iostream>
#include<Windows.h>
#include"Car.h"

int main(void) {
	{
		Car car("����", "X7", 950000, "����", 3.5);
		cout << car.description() << endl;
	}
	system("pause");
	return 0;
}