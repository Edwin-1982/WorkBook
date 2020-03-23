#include <string.h>
#include "Man.h"
#include"Boy.h"

Man::Man(const char* name, int age, int salary){
	if (!name) {
		name = "未命名";
	}
	this->name = new char[strlen(name) + 1];
	strcpy_s(this->name, strlen(name) + 1, name);

	this->age = age;
	this->salary = salary;
}

Man::Man(const Boy& boy){
	int len = strlen((char*)boy)+1;
	name = new char[len];
	strcpy_s(name, len, (char*)boy);

	age = boy[AGE];
	salary = boy[SALARY];
	
}

Man::~Man(){
	delete name;
}

ostream& operator<<(ostream& os, const Man& man){

	// TODO: 在此处插入 return 语句
	os << "[男人]姓名:" << man.name
	<< "\t[男人]年龄:" << man.age
	<< "\t[男人]薪资:" << man.salary
		<<  endl;
	return os;
}
