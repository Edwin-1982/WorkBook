#include<iostream>
#include<windows.h>
#include<string>
using namespace std;

//电话类
//此时共同的基类Tel类,就称为"虚基类"
class Tel { //虚基类
public :
	Tel() {
		this->number = "未知";
	}
protected:
	string number;//电话号码
};

//座机类
class FixedLine :virtual public Tel{
public:
	FixedLine() {

	}
};

//手机类
class MobilePhone :virtual public Tel {

};

//无线座机类
class WirelessTel :public FixedLine, public MobilePhone {
public:
	void setNumber(const char* number) {
		this->number = number;
		//this->FixedLine::number = number;
	}
	string getNumber() {
		return this->number;
	}
};
int main(void) {
	WirelessTel phone;
	phone.setNumber("13243879166");
	cout << phone.getNumber() << endl;
	system("pause");
	return 0;
}