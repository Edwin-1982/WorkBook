#pragma once
#include<string>
class Pork;
class Horse;

using namespace std;
class Cow{
public:
	Cow(int weight = 0);

	//ʹ�����������ʵ��:һͷţ+һƥ��=?
	//Pork operator+(const Horse &horse);  //һͷţ+һƥ��
	//Pork operator+(const Cow& cow);      //һͷţ+һͷţ
    
	Cow operator+(int n);

	friend Cow operator+(int n, const Cow& cow);
	friend Pork operator+(const Cow& cow1,const Cow &cow2);
	friend Pork operator+(const Cow& cow, const Horse& horse);
	friend Pork operator+(const Horse& horse, const Cow& cow);
	
	string description();
private:
	int weight;//ţ������

};

