#pragma once
#include<string>
using namespace std;
class Book
{
public:
	Book(const string name,const float price,const string ISBN);
	~Book();

	string getName()const;//�鿴����
	float getPrice()const;//�鿴�۸�
	string getISBN()const;//�鿴���

protected:
	string name;
	float price;
	string ISBN;//���
};

