#pragma once
#include<iostream>

using namespace std;

class Father
{
public:
	Father(const char* lastName="����",const char*firstName="����");
	~Father();
	

	void playBasketball();//������
	void dance();
protected:
	string lastName;//��
	string firstName;//��
};

