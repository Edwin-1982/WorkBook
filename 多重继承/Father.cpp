#include<iostream>
#include "Father.h"

using namespace std;

Father::Father(const char* lastName, const char* firstName) {
	this->lastName = lastName;
	this->firstName = firstName;

	cout << __FUNCTION__ << endl;
}

Father::~Father(){
}

void Father::playBasketball() {
	cout << "����,��Ҫ����������!" << endl;
}

void Father::dance(){
	cout << "�ٺ�,��Ҫ��������!" << endl;
}
