#pragma once
#include<string>
using namespace std;
class Book
{
public:
	Book(const string name,const float price,const string ISBN);
	~Book();

	string getName()const;//查看书名
	float getPrice()const;//查看价格
	string getISBN()const;//查看书号

protected:
	string name;
	float price;
	string ISBN;//书号
};

