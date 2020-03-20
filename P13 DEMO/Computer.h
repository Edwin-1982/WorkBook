#pragma once
#include<string>
#include"ComputerService.h"

using namespace std;

class Computer{
public:
	Computer();
	string description(void);
private:
	string cpu; //计算机CPU芯片

	//把外部的全局函数upgrade,声明为这个类的有缘函数
	//friend void upgrade(Computer* computer);

	//friend void ComputerService::upgrade(Computer* computer);
	friend class ComputerService;
};

