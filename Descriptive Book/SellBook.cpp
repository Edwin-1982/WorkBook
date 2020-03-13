#include "SellBook.h"
#include"Book.h"
SellBook::SellBook(string name,float price, string ISBN, float discount):Book(name,price,ISBN){
	
	this->discount = discount;
}

SellBook::~SellBook(){
}

float SellBook::getDiscount(){
	return discount;
}

void SellBook::setDiscount(float discount){
	this->discount=discount;
}

float SellBook::getPrice(){
	float ret = price * discount / 10.0;
	return ret;
}
