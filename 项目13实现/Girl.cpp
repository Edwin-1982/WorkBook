#include<sstream>
#include<iostream>
#include<iomanip>
#include "Girl.h"
#include "Boy.h"

//颜值系数
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
	//颜值系数  
	if (boy.getSalary() >= yanZhi * YANZHI_FACTOR) {
		return true;
	}
	else {
		return false;
	}
}

string Girl::description() const {
	stringstream ret;
	//ret << name << "-女-颜值(" << YanZhi << ")-年龄(" << age << ")";
	ret << "姓名:" << name
		<< "\t\t\t性别:女"
		<< "\t\t\t年龄:" << age
		<<setw(3)<<setiosflags(ios::left)
		<< "\t\t\t颜值:" << yanZhi;
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
		cout << "请输入第" << n << "位小姐姐的年龄[输入0结束]:";
		cin >> age;
		if (age == 0) {
			break;
		}
		cout << "请输入第" << n << "位小姐姐的姓名[输入0结束]:";
		cin >> name;
		cout << "请输入第" << n << "位小姐姐的颜值[输入0结束]:";
		cin >> yanZhi;

		girls.push_back(Girl(age, name, yanZhi));
		n++;
	}

}

void Girl::inputGirl(Girl& girl){
	string name;
	int age;
	int yanZhi;

	cout << "请输入小姐姐的姓名:";
	cin >> name;

	cout << "请输入小姐姐的年龄:";
	cin >> age;

	cout << "请输入小姐姐的颜值:";
	cin >> yanZhi;

	girl=Girl(age,name, yanZhi);

}

ostream& operator<<(ostream& os, const Girl& girl){

	// TODO: 在此处插入 return 语句
	os << "姓名:" << girl.name
		<< "\t\t\t性别:女"
		<< "\t\t\t年龄:" << girl.age
		<< "\t\t\t薪资:" << girl.yanZhi;
	return os;
}
