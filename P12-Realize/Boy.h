#pragma once
#include<string>
#include<vector>
#include "Single.h"

using namespace std;
class Girl;
class Boy :public Single{
public:
	Boy();
	Boy(const Boy& other);
	Boy(int age, string name, int salary);
	~Boy();

	int getSalary()const;
	string description()const;
	bool satisfied(const Girl& girl)const;

	//输如多个boy信息
	static void inputBoys(vector<Boy>& boys);
	static void inputBoy(Boy& boy);
private:
	int salary;//薪资
};

