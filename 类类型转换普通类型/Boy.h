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
	Boy(const char* name, int age, int salary, int darkHorse);
	~Boy();
	Boy(int salary);
	Boy(const char* name);
	string description();

	//重载赋值运算符
	Boy& operator=(const Boy& boy);

	bool operator>(const Boy& boy);
	bool operator<(const Boy& boy);
	bool operator==(const Boy& boy);

	//类型运算符重载,不需要返回类型
	operator int()const;
	operator char* ()const;
	//下标运算符的重载
	int operator[](string index)const;
	int operator[](int index)const;

	//ostream& operator<<(ostream& os) const;//此方法不合适
	friend ostream& operator<<(ostream& os, const Boy& boy);
	friend istream& operator>>(istream& is, Boy& boy);

private:
	char* name;
	int age;
	int salary;
	int darkHorse;//黑马值,表示潜力系数
	unsigned int id;//编号
	static int LAST_ID;

	int power()const;//综合能力值

};

ostream& operator<<(ostream& os, const Boy& boy);
istream& operator>>(istream& is, Boy& boy);



