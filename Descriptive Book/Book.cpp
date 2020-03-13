#include "Book.h"

Book::Book(const string name,const float price, const string ISBN){
	this->name = name;
	this->price = price;
	this->ISBN = ISBN;
}

Book::~Book(){
}

string Book::getName() const{
	return name;
}

float Book::getPrice() const{
	return price;
}
string Book::getISBN() const
{
	return ISBN;
}
