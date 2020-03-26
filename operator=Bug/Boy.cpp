#include<sstream>
#include "Boy.h"
#include <iomanip>

int Boy::LAST_ID = 0;

Boy::Boy(const char* name, int age, int salary, int darkHorse){
	if (!name) {
		name = "未命名";
	}
	this->name = new char[strlen(name) + 1];
	strcpy_s(this->name, strlen(name) + 1, name);

	this->age = age;
	this->salary = salary;
	this->darkHorse = darkHorse;
	this->id = ++LAST_ID;
}

Boy::~Boy(){
	if (name) {
		delete name;
	}
}
string Boy::description() {
	stringstream ret;
	ret<<"ID:"<<id<<"姓名:"<<name<<"\t年龄:"<<age
		<<"\t薪资:"<<salary
		<<setw(15) << setiosflags(ios::right)
		<<"\t黑马系数:"<<darkHorse;
	return ret.str();
}

//注意返回类型和参数类型
Boy& Boy::operator=(const Boy& boy){
	// TODO: 在此处插入 return 语句
	if (name) {
		delete name;//释放原来的内存
	}
	int len = strlen(boy.name) + 1;
	name = new char[len];//分配新内存
	strcpy_s(name, len, boy.name);

	this->age = boy.age;
	this->salary = boy.salary;
	this->darkHorse = boy.darkHorse;
	//this->id = boy.id;//根据需求来确定是否要拷贝id
	return *this;
}

bool Boy::operator>(const Boy& boy){
	
	//设置比较规则
	//薪资*黑马系数+(100-年龄)*1000
	if (power() > boy.power()) {
		return true;
	}
	else {
		return false;
	}
}

bool Boy::operator<(const Boy& boy){
	
	//设置比较规则
	//薪资*黑马系数+(100-年龄)*1000
	if (power() < boy.power()) {
		return true;
	}
	else {
		return false;
	}
}
bool Boy::operator==(const Boy& boy) {

	//设置比较规则
	//薪资*黑马系数+(100-年龄)*1000
	if (power() == boy.power()) {
		return true;
	}
	else {
		return false;
	}
}

int Boy::power() const{
	//薪资*黑马系数+(100-年龄)*1000
	int ret = salary * darkHorse + (100 - age) * 1000;
	return ret;
}
//Boy::Boy(const Boy& boy) {
//	int len = strlen(boy.name) + 1;
//	name = new char[len];
//	strcpy_s(name, len, boy.name);
//
//	this->age = boy.age;
//	this->salary = boy.salary;
//	this->darkHorse = boy.darkHorse;
//	//this->id = boy.id;//根据需求来确定是否要拷贝id
//	this->id = ++LAST_ID;
//}
