#pragma once
#include<iostream>

using namespace std;

#define AGE_KEY        "age"
#define SALARY_KEY     "salary"
#define DARK_HORSE_KEY "darkHorse"
#define POWER_KEY      "power"

typedef enum {
	AGE,
	SALARY,
	DARK_HORSE,
	POWER,
}BOY_KEY_TYPE;
class Boy {
public:
	Boy(const char* name = NULL, int age = 0, int salary = 0, int darkHorse = 0);
	~Boy();

	string description();

	//���ظ�ֵ�����
	Boy& operator=(const Boy& boy);

	bool operator>(const Boy& boy);
	bool operator<(const Boy& boy);
	bool operator==(const Boy& boy);

	//�±������������
	int operator[](string index);
	int operator[](int index);
	
	//ostream& operator<<(ostream& os) const;//�˷���������
	friend ostream& operator<<(ostream& os, const Boy& boy);
	friend istream& operator>>(istream& is, Boy& boy);
private:
	char* name;
	int age;
	int salary;
	int darkHorse;//����ֵ,��ʾǱ��ϵ��
	unsigned int id;//���
	static int LAST_ID;

	int power()const;//�ۺ�����ֵ
	
};

//Boy boy1;
//boy1["name"]; return string
//boy1["age"];  return int
//boy1["salary"];return string
//boy1[0] boy[1] boy[2]
//int data[] = { 1,2,3,4,5 };
//data[0],data[1],
