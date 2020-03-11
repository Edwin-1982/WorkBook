#include<sstream>  
#include <iostream>
#include "Girl.h"
#include "Boy.h"
#include"Single.h"

//��ֵϵ��
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
	//��ֵϵ��  
	if (boy.getSalary() >= yanZhi * YANZHI_FACTOR) {
		return true;
	}
	else {
		return false;
	}
}

string Girl::description() const {
	stringstream ret;
	ret << getName()<<"-Ů-��ֵ("<<yanZhi<<")-����("<<getAge()<<")";
	return ret.str();
}

void Girl::inputGirls(vector<Girl>& girls){
	int age;
	string name;
	int yanZhi;

	int n = 1;
	while (1) {
		cout << "�������" << n << "λС��������[����0����]:";
		cin >> age;
		if (age == 0) {
			break;
		}
		cout << "�������" << n << "λС��������[����0����]:";
		cin >> name;
		cout << "�������" << n << "λС������ֵ[����0����]:";
		cin >>yanZhi;

		girls.push_back(Girl(age, name, yanZhi));
		n++;
	}

}
