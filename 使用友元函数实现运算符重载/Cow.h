#pragma once
#include<string>
class Pork;
class Horse;

using namespace std;
class Cow{
public:
	Cow(int weight = 0);

	//使用运算符重载实现:一头牛+一匹马=?
	//Pork operator+(const Horse &horse);  //一头牛+一匹马
	//Pork operator+(const Cow& cow);      //一头牛+一头牛
    
	Cow operator+(int n);

	friend Cow operator+(int n, const Cow& cow);
	friend Pork operator+(const Cow& cow1,const Cow &cow2);
	friend Pork operator+(const Cow& cow, const Horse& horse);
	friend Pork operator+(const Horse& horse, const Cow& cow);
	
	string description();
private:
	int weight;//牛的体重

};

