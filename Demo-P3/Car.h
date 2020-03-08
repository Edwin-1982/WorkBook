#pragma once
#include<string>
#include"Engine.h"
#include"Tire.h"

using namespace std;
class Car
{
public:
	Car();
	Car(const string& carBrand, const string& carVersion, int carPrice, const string& engineBrand,float  engineVer, const string& tireBrand = "米其林");
	~Car();

	Engine getEngine()const;
	const Tire* getTire(int i)const;
	string getBrand()const;
	string getVersion()const;
	int getPrice()const;
	int getMiles()const;
	string description()const;

private:
	Engine  engine;
	Tire tires[4];
	string brand;//品牌
	string version;//型号
	int price;
	int miles;//行驶里程

};

