#include "Mother.h"

Mother::Mother(const char*food,const char*lastName,const char*firstName){
	this->food = food;
	this->lastName = lastName;
	this->firstName = firstName;

	cout << __FUNCTION__<<endl;
}

Mother::~Mother(){

}

void Mother::dance(){
	cout << endl;
	cout << "һ����ǡǡ��,һ������,��������...\n" << endl;
}
