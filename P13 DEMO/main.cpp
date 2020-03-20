#include<iostream>
#include<Windows.h>
#include"Computer.h"
#include"ComputerService.h"

//使用全局函数,作为Computer类的友元函数
//void upgrade(Computer* computer) {
//	computer->cpu = "i9";
//}
int main(void) {
	Computer computer;
	ComputerService service;
	cout << computer.description() << endl;

	//upgrade(&computer);

	service.upgrade(&computer);
	service.clean(&computer);
	service.kill(&computer);
	cout << computer.description() << endl;

	system("pause");
	return 0;
}