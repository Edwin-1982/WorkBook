#include<iostream>
#include "Son.h"

Son::Son(const char* lastName, const char* firstName, const char* food, const char* game) :Father(lastName, firstName), Mother(food) {
	this->game = game;

	cout << __FUNCTION__ << endl;

}
Son::~Son() {

}

void Son::playGame(){

	cout << "Ò»ÆðÍæ" <<game<<"°É..."<< endl;
}

void Son::dance() {
	Father::dance();
	Mother::dance();
	cout << "àëàë,ÎÒÃÇÀ´Ìø½ÖÎè°É!\n" << endl;
}
