#include<sstream>
#include<iostream>
#include<iomanip>
#include "Girl.h"
#include "Boy.h"

//��ֵϵ��
#define YANZHI_FACTOR 100  

Girl::Girl() {
}
Girl::Girl(int age, string name, int yanZhi) :Single(name, age) {
	this->yanZhi = yanZhi;
}
Girl::~Girl() {

}
int Girl::getYanZhi() const {

	return yanZhi;
}

bool Girl::satisfied(const Boy& boy) const {
	//��ֵϵ��  
	if (boy.getSalary() >= yanZhi * YANZHI_FACTOR) {
		return true;
	}
	else {
		return false;
	}
}

string Girl::description() const {
	stringstream ret;
	//ret << name << "-Ů-��ֵ(" << YanZhi << ")-����(" << age << ")";
	ret << "����:" << name
		<< "\t\t\t�Ա�:Ů"
		<< "\t\t\t����:" << age
		<<setw(3)<<setiosflags(ios::left)
		<< "\t\t\t��ֵ:" << yanZhi;
	return ret.str();
}

bool Girl::operator>(const Girl& girl){
	
	return yanZhi>girl.yanZhi;
}

void Girl::inputGirls(vector<Girl>& girls) {
	int age;
	string name;
	int yanZhi;

	int n = 1;
	while (1) {
		cout << "�������" << n << "λС��������[����0����]:";
		cin >> age;
		if (age == 0) {
			break;
		}
		cout << "�������" << n << "λС��������[����0����]:";
		cin >> name;
		cout << "�������" << n << "λС������ֵ[����0����]:";
		cin >> yanZhi;

		girls.push_back(Girl(age, name, yanZhi));
		n++;
	}

}

void Girl::inputGirl(Girl& girl){
	string name;
	int age;
	int yanZhi;

	cout << "������С��������:";
	cin >> name;

	cout << "������С��������:";
	cin >> age;

	cout << "������С������ֵ:";
	cin >> yanZhi;

	girl=Girl(age,name, yanZhi);

}

ostream& operator<<(ostream& os, const Girl& girl){

	// TODO: �ڴ˴����� return ���
	os << "����:" << girl.name
		<< "\t\t\t�Ա�:Ů"
		<< "\t\t\t����:" << girl.age
		<< "\t\t\tн��:" << girl.yanZhi;
	return os;
}
