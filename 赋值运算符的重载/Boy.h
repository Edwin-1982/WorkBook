#pragma once
#include<iostream>

using namespace std;

class Boy{
public:
	Boy(const char* name = NULL, int age = 0, int salary = 0,int darkHorse=0);
	~Boy();
	
	//重载赋值运算符
	Boy& operator=(const Boy& boy);
	string description();
private:
	char* name;
	int age;
	int salary;
	int darkHorse;//黑马值,表示潜力系数
	unsigned int id;//编号
	static int LAST_ID;
};

