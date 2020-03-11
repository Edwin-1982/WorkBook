#include "Boy.h"
#include "Girl.h"
#include<sstream>
#include <iostream>

#define SALARY_FACTOR 0.006

Boy::Boy(){
}

Boy::Boy(const Boy&other):Single(other.getName(),other.getAge()){
	/*
	age = other.age;
	name = otjer.name;
	*/
	salary = other.salary;
}

Boy::Boy(int age, string name, int salary):Single(name,age){
	/*
	this->age = age;
	this->name = name;
	*/
	this->salary = salary;
}

Boy::~Boy(){
}

/*
int Boy::getAge() const
{
	return age;
}

string Boy::getName() const{
	return name;
}
*/

int Boy::getSalary() const{
	return salary;
}

string Boy::description()const{
	stringstream ret;
	ret << getName() << "-��-н��(" << salary << ")-����(" << getAge() << ")";
	
	return ret.str();
}

bool Boy::satisfied(const Girl& girl) const{
	double yanZhi = salary * SALARY_FACTOR;
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
