#pragma once
#include<iostream>

using namespace std;

class Boy{
public:
	Boy(const char* name = NULL, int age = 0, int salary = 0,int darkHorse=0);
	~Boy();
	
	string description();

	//���ظ�ֵ�����
	Boy& operator=(const Boy& boy);

	bool operator>(const Boy& boy);
	bool operator<(const Boy& boy);
	bool operator==(const Boy& boy);



private:
	char* name;
	int age;
	int salary;
	int darkHorse;//����ֵ,��ʾǱ��ϵ��
	unsigned int id;//���
	static int LAST_ID;

	int power()const;//�ۺ�����ֵ
};

