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

	//������boy��Ϣ
	static void inputGirls(vector<Girl>& girls);
	static void inputGirl(Girl& girl);
private:
	int yanZhi;  //��ֵ
};

