#include<sstream>
#include "Boy.h"

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
		<<"\tн��:"<<salary<<"\t����ϵ��:"<<darkHorse;
	return ret.str();
}
Boy& Boy::operator=(const Boy& boy){
	// TODO: �ڴ˴����� return ���
	if (name) {
		delete name;//�ͷ�ԭ�����ڴ�
	}
	name = new char[strlen(boy.name) + 1];
	strcpy_s(name, strlen(boy.name) + 1, boy.name);
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

