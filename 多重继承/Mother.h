#pragma once
#include<iostream>

using namespace std;

class Mother
{
public:
	Mother(const char* food, const char* lastName="����", const char* firstName="����");
	~Mother();

	void dance();//����
private:
	string lastName;//��
	string firstName;//��
	string food;    //ϲ����ʳ��
};

