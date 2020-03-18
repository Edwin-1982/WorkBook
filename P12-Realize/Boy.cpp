#include<iostream>
#include<sstream>
#include "Boy.h"
#include"Girl.h"

#define SALARY_FACTOR 0.006

Boy::Boy(){
}

Boy::Boy(const Boy& other):Single(other.getName(),other.getAge()){
	
	salary = other.salary;
}

Boy::Boy(int age, string name, int salary):Single(name,age){

	this->salary = salary;
}

Boy::~Boy(){
}

int Boy::getSalary() const{
	
	return salary;
}

string Boy::description() const{
	//�淶һ���ַ�����ʽ:����:Rock\t\t\t�Ա�:��\t\t\t����:39\t\t\tн��:35000
	stringstream ret;
	//ret << getName() << "-��-н��(" << salary << ")-����(" << getAge() << ")";
	ret << "����:" << name
		<< "\t\t\t�Ա�:��" 
		<< "\t\t\t����:" << age
		<<"\t\t\tн��:"<<salary;
	return ret.str();
}

bool Boy::satisfied(const Girl& girl) const{
	int YanZhi = (int)(salary * SALARY_FACTOR);
	if (YanZhi > 100) {
		YanZhi = 100;
	}
	if (girl.getYanZhi() >= salary * SALARY_FACTOR) {
		return true;
	}
	else {
		return false;
	}
}

void Boy::inputBoys(vector<Boy>& boys){

	int age;
	string name;
	int salary;

	int n = 1;
	while (1) {
		cout<<"�������" << n << "λС��������[����0����]:";
		cin >> age;
		if (age == 0) {
			break;

		}
		cout << "�������" << n << "λС��������[����0����]:";
		cin >> name;
		cout << "�������" << n << "λС����н��[����0����]:";
		cin >> salary;

		boys.push_back(Boy(age, name, salary));
		n++;
	}
}

void Boy::inputBoy(Boy& boy){
	
	string name;
	int age;
	int salary;
	cout << "������С��������:";
	cin >> name;

	cout << "������С��������:";
	cin >> age;

	cout << "������С����н��:";
	cin >> salary;

	boy = Boy(age, name, salary);
}
