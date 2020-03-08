#pragma once
#include<string>

using namespace std;

class Toy
{
public:
	Toy();
	Toy(string name, int price, string origin);
	~Toy();

	string getName()const;
	float getPrice()const;
	string getOrigin()const;
	void setDiscount(float discount);
private:
	string name;
	int price;
	string origin;//╡З╣ь
	float discount = 1.0;//уш©ш
};

