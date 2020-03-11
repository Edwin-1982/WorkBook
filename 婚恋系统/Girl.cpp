#include<sstream>  
#include <iostream>
#include "Girl.h"
#include "Boy.h"
#include"Single.h"

//颜值系数
#define YANZHI_FACTOR 100  

Girl::Girl() {
	/*
	age = 0;
	name = "";
	yanZhi = 0;
	*/
}
Girl::Girl(int age, string name, int yanZhi):Single(name,age) {
	/*
	this->age = age;
	this->name = name;
	*/
	this->yanZhi = yanZhi;
}
Girl::~Girl() {

}
/*
int Girl::getAge() const {

	return age;
}

string Girl::getName() const {

	return name;
}
*/
int Girl::getYanzhi() const {

	return yanZhi;
}

bool Girl::satisfied(const Boy& boy) const {
	//颜值系数  
	if (boy.getSalary() >= yanZhi * YANZHI_FACTOR) {
		return true;
	}
	else {
		return false;
	}
}

string Girl::description() const {
	stringstream ret;
	ret << getName()<<"-女-颜值("<<yanZhi<<")-年龄("<<getAge()<<")";
	return ret.str();
}

void Girl::inputGirls(vector<Girl>& girls){
	int age;
	string name;
	int yanZhi;

	int n = 1;
	while (1) {
		cout << "请输入第" << n << "位小姐姐的年龄[输入0结束]:";
		cin >> age;
		if (age == 0) {
			break;
		}
		cout << "请输入第" << n << "位小姐姐的姓名[输入0结束]:";
		cin >> name;
		cout << "请输入第" << n << "位小姐姐的颜值[输入0结束]:";
		cin >>yanZhi;

		girls.push_back(Girl(age, name, yanZhi));
		n++;
	}

}
