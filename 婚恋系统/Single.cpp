#include "Single.h"

Single::Single(){
	name = "����";
	age = 0;
}

Single::Single(string name, int age){
	this->age = age;
	this->name = name;
}

Single::~Single(){
}

int Single::getAge() const{
	return age;
}

string Single::getName() const{
	return name;
}
