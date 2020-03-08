#include <iostream>
#include<sstream>
#include "Engine.h"


Engine::Engine(){
	
}

Engine::Engine(const string& brand, float version){
	this->brand = brand;
	this->version = version;
}

Engine::~Engine(){
	cout << __FUNCTION__ << endl;
}

string Engine::description() const{
	stringstream ret;
	ret << "Æ·ÅÆ:" << brand << "-ÐÍºÅ:" << version;
	return ret.str();
}
