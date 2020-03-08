#include "Boy.h"
#include "Girl.h"
#include<sstream>
#include <iostream>

#define SALARY_FACTOR 0.006

Boy::Boy(){
	age = 0;
	name = "";
	salary = 0;
}

Boy::Boy(int age, string name, int salary){
	this->age = age;
	this->name = name;
	this->salary = salary;
}

Boy::~Boy()
{
}

int Boy::getAge() const
{
	return age;
}

string Boy::getName() const{
	return name;
}

int Boy::getSalary() const
{
	return salary;
}

string Boy::description()const{
	stringstream ret;
	ret << name << "-��-н��(" << salary << ")-����(" << age << ")";
	
	return ret.str();
}

bool Boy::satisfied(const Girl& girl) const{
	int yanZhi = salary * SALARY_FACTOR;
	if (yanZhi > 100) {
		yanZhi = 100;
	}
	if (girl.getYanzhi()>=yanZhi) {
		return true;
	}
	else{
		return false;
	}
}

void Boy::inputBoys(vector<Boy>& boys){
	int age;
	string name;
	int salary;

	int n = 1;
	while (1) {

		cout << "�������" << n << "λС��������[����0����]:";
		cin >> age;
		if (age == 0) {
			break;

		}
		cout << "�������" << n << "λС��������[����0����]:";
		cin >> name;
		cout << "�������" << n << "λС����н��[����0����]:";
		cin >> salary;

		boys.push_back(Boy(age,name,salary));
		n++;
	}
}
