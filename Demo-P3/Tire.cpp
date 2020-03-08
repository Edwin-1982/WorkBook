#include <iostream>
#include<sstream>
#include "Tire.h"


Tire::Tire(const string& brand)
{
	this->brand = brand;
	this->pressure = 2.5;
}

Tire::~Tire(){
	cout << __FUNCTION__ << endl;
}

string Tire::getBrand() const{
	
	return brand;
}

float Tire::getPressure() const{
	return pressure;
}

string Tire::description() const{
	stringstream ret;
	ret << "Ʒ��:" << brand << "-̥ѹ:" << pressure;
	return ret.str();
}
