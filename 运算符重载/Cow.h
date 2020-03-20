#pragma once
class Pork;
class Horse;
class Cow{
public:
	Cow(int weight = 0);

	//使用运算符重载实现:一头牛+一匹马=?
	Pork operator+(const Horse &horse);  //一头牛+一匹马
	Pork operator+(const Cow& cow);      //一头牛+一头牛
private:
	int weight;//牛的体重

};

