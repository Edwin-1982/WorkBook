#pragma once
#include<string>
#include<vector>
#include"Single.h"

using namespace std;
class Girl;
class Boy:public Single{
public:
	Boy();
	Boy(const Boy& other);
	Boy(int age, string name, int salary);
	~Boy();

	/*
	int getAge()const;
	string getName()const;
	*/
	int getSalary()const;
	string description()const;
	bool satisfied(const Girl& girl)const;
	//输入多个boy信息
	static void inputBoys(vector<Boy>& boys);

private:
	/*
	int age;
	string name;
	*/
	int salary;   //薪资


};

