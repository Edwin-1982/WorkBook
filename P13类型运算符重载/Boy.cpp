#include<sstream>
#include "Boy.h"

int Boy::LAST_ID = 0;

Boy::Boy(const char* name, int age, int salary, int darkHorse) {
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

Boy::~Boy() {
	if (name) {
		delete name;
	}
}
Boy::Boy(int salary){
	const char*defaultName= "δ����";
	this->name = new char[strlen(defaultName) + 1];
	strcpy_s(this->name, strlen(defaultName) + 1, defaultName);

	this->age = 0;
	this->salary = salary;
	this->darkHorse = 0;
	this->id = ++LAST_ID;
}
Boy::Boy(const char* name){
	this->name = new char[strlen(name) + 1];
	strcpy_s(this->name, strlen(name) + 1, name);

	this->age = 0;
	this->salary = 0;
	this->darkHorse = 0;
	this->id = ++LAST_ID;
}
string Boy::description() {
	stringstream ret;
	ret << "ID:" << id << "\t����:" << name << "\t����:" << age
		<< "\tн��:" << salary << "\t����ϵ��:" << darkHorse << endl;
	return ret.str();
}
Boy& Boy::operator=(const Boy& boy) {
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

bool Boy::operator>(const Boy& boy) {

	//���ñȽϹ���
	//н��*����ϵ��+(100-����)*1000
	if (power() > boy.power()) {
		return true;
	}
	else {
		return false;
	}
}

bool Boy::operator<(const Boy& boy) {

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

int Boy::operator[](string index) {
	if (index == AGE_KEY) {
		return age;
	}
	else if (index == SALARY_KEY) {
		return salary;
	}
	else if (index == DARK_HORSE_KEY) {
		return darkHorse;
	}
	else if (index == POWER_KEY) {
		return power();
	}
	else {
		return -1;
	}
}

int Boy::operator[](int index) {
	if (index == AGE) {
		return age;
	}
	else if (index == SALARY) {
		return salary;
	}
	else if (index == DARK_HORSE) {
		return darkHorse;
	}
	else if (index == POWER) {
		return power();
	}
	else {
		return -1;
	}
	return 0;
}

//ostream& Boy::operator<<(ostream& os) const{
//	// TODO: �ڴ˴����� return ���
//	
//	os << "ID:" << id << "\t����:" << name << "\t����:" << age
//		<< "\t\tн��:" << salary << "\t����ϵ��:" << darkHorse<<endl;
//	return os;
//}

int Boy::power() const {
	//н��*����ϵ��+(100-����)*1000
	int ret = salary * darkHorse + (100 - age) * 1000;
	return ret;
}
