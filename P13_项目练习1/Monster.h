#pragma once
#include<iostream>
#include<string>

using namespace std;

class SpriteStone;

//怪兽类
class Monster{
public:
	Monster(int level = 1, const string& category = "未知");
	
	SpriteStone getValue()const; 
	int getPower()const;//获取该妖兽的战斗力
	friend ostream& operator<<(ostream& os, const Monster& monster);
	friend bool  operator==(const Monster& one, const Monster& other);

private:
	string category;//怪兽种类
	int level;//1-9级
};

//非成员函数实现运算符重载
ostream& operator<<(ostream& os, const Monster& monster);
//成员函数实现运算符重载
bool operator==(const Monster& one, const Monster& other);