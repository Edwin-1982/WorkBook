#include <iostream>
#include<sstream>
#include "Car.h"

Car::Car() {

}
Car::Car(const string& carBrand, const string& carVersion, int carPrice,
	const string& engineBrand, float engineVer, 
	const string& tireBrand) :
	engine(engineBrand, engineVer), tires{ tireBrand,tireBrand, tireBrand, tireBrand }
{


	this->brand = carBrand;
	this->version = carVersion;
	this->price = carPrice;
	this->miles = 0;
}

Car::~Car(){
	cout << __FUNCTION__ << endl;
}

Engine Car::getEngine()const{
	
	return  engine;
}

const Tire* Car::getTire(int i) const{
	if (i >= 1 && i <= 4) {
		return &tires[i];
	}
	return NULL;
	
}

string Car::getBrand() const{
	return brand;
}

string Car::getVersion() const
{
	return version;
}

int Car::getPrice() const
{
	return price;
}

int Car::getMiles() const
{
	return miles;
}

string Car::description() const{
	stringstream ret;
	ret << "Æû³µÆ·ÅÆ:" << brand << "-" << version << "-£¤" << price
		<< "\t\tÒýÇæ" << engine.description()
		<< "\t\tÂÖÌ¥" << tires[0].description();
	return ret.str();
}
