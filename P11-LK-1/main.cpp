#include<iostream>
#include<windows.h>
#include<string>
using namespace std;

//�绰��
//��ʱ��ͬ�Ļ���Tel��,�ͳ�Ϊ"�����"
class Tel { //�����
public :
	Tel() {
		this->number = "δ֪";
	}
protected:
	string number;//�绰����
};

//������
class FixedLine :virtual public Tel{
public:
	FixedLine() {

	}
};

//�ֻ���
class MobilePhone :virtual public Tel {

};

//����������
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