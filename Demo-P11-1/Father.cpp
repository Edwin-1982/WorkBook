#include <iostream>
#include<sstream>
#include "Father.h"


Father::Father(const char* name, int age){
	cout << __FUNCTION__ << endl;
	this->name = name;
	this->age = age;
}

Father::~Father(){
}

string Father::getName(){
	return name;
}

int Father::getAge(){
	return age;
}

string Father::description(){
	stringstream ret;
	ret << "ÐÕÃû:" << name<<" ÄêÁä:"<<age;
	return ret.str();
}
