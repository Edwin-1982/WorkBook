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
	cout << "一起跳恰恰吧,一二三四,二二三四...\n" << endl;
}
