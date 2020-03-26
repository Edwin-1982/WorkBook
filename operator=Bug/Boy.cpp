#include<sstream>
#include "Boy.h"
#include <iomanip>

int Boy::LAST_ID = 0;

Boy::Boy(const char* name, int age, int salary, int darkHorse){
	if (!name) {
		name = "δ����";
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
	ret<<"ID:"<<id<<"����:"<<name<<"\t����:"<<age
		<<"\tн��:"<<salary
		<<setw(15) << setiosflags(ios::right)
		<<"\t����ϵ��:"<<darkHorse;
	return ret.str();
}

//ע�ⷵ�����ͺͲ�������
Boy& Boy::operator=(const Boy& boy){
	// TODO: �ڴ˴����� return ���
	if (name) {
		delete name;//�ͷ�ԭ�����ڴ�
	}
	int len = strlen(boy.name) + 1;
	name = new char[len];//�������ڴ�
	strcpy_s(name, len, boy.name);

	this->age = boy.age;
	this->salary = boy.salary;
	this->darkHorse = boy.darkHorse;
	//this->id = boy.id;//����������ȷ���Ƿ�Ҫ����id
	return *this;
}

bool Boy::operator>(const Boy& boy){
	
	//���ñȽϹ���
	//н��*����ϵ��+(100-����)*1000
	if (power() > boy.power()) {
		return true;
	}
	else {
		return false;
	}
}

bool Boy::operator<(const Boy& boy){
	
	//���ñȽϹ���
	//н��*����ϵ��+(100-����)*1000
	if (power() < boy.power()) {
		return true;
	}
	else {
		return false;
	}
}
bool Boy::operator==(const Boy& boy) {

	//���ñȽϹ���
	//н��*����ϵ��+(100-����)*1000
	if (power() == boy.power()) {
		return true;
	}
	else {
		return false;
	}
}

int Boy::power() const{
	//н��*����ϵ��+(100-����)*1000
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
//	//this->id = boy.id;//����������ȷ���Ƿ�Ҫ����id
//	this->id = ++LAST_ID;
//}
