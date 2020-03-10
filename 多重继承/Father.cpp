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
	cout << "呦呦,我要三步上篮了!" << endl;
}

void Father::dance(){
	cout << "嘿嘿,我要跳霹雳舞!" << endl;
}
