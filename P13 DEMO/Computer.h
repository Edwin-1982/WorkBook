#pragma once
#include<string>
#include"ComputerService.h"

using namespace std;

class Computer{
public:
	Computer();
	string description(void);
private:
	string cpu; //�����CPUоƬ

	//���ⲿ��ȫ�ֺ���upgrade,����Ϊ��������Ե����
	//friend void upgrade(Computer* computer);

	//friend void ComputerService::upgrade(Computer* computer);
	friend class ComputerService;
};

