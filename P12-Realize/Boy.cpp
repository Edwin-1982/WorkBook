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
	//规范一下字符串格式:姓名:Rock\t\t\t性别:男\t\t\t年龄:39\t\t\t薪资:35000
	stringstream ret;
	//ret << getName() << "-男-薪资(" << salary << ")-年龄(" << getAge() << ")";
	ret << "姓名:" << name
		<< "\t\t\t性别:男" 
		<< "\t\t\t年龄:" << age
		<<"\t\t\t薪资:"<<salary;
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
		cout<<"请输入第" << n << "位小哥哥的年龄[输入0结束]:";
		cin >> age;
		if (age == 0) {
			break;

		}
		cout << "请输入第" << n << "位小哥哥的姓名[输入0结束]:";
		cin >> name;
		cout << "请输入第" << n << "位小哥哥的薪资[输入0结束]:";
		cin >> salary;

		boys.push_back(Boy(age, name, salary));
		n++;
	}
}

void Boy::inputBoy(Boy& boy){
	
	string name;
	int age;
	int salary;
	cout << "请输入小哥哥的姓名:";
	cin >> name;

	cout << "请输入小哥哥的年龄:";
	cin >> age;

	cout << "请输入小哥哥的薪资:";
	cin >> salary;

	boy = Boy(age, name, salary);
}
