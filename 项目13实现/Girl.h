#pragma once
#include<string>
#include<vector>
#include "Single.h"

using namespace std;
class Boy;
class Girl :public Single{
public:
	Girl();
	Girl(int age, string name, int yanZhi);
	~Girl();

	int getYanZhi()const;
	bool satisfied(const Boy& boy)const;
	string description()const;

	bool operator>(const Girl& girl);


	//输入多个boy信息
	static void inputGirls(vector<Girl>& girls);
	static void inputGirl(Girl& girl);
	
	friend ostream& operator<<(ostream& os, const Girl& girl);
private:
	int yanZhi;  //颜值
};

ostream& operator<<(ostream& os, const Girl& girl);