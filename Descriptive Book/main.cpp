#include<iostream>
#include"Book.h"
#include"SellBook.h"

int main(void) {

	Book book1("C#高级编程",98, "ISBN20192556875632");
	cout <<"书名:"<<book1.getName()<< " 价格:" << book1.getPrice() << " ISBN:" << book1.getISBN() << endl;

	SellBook book2("C++实战经典",120, "ISBN201952136987-9");
	cout << "书名:" << book2.getName() << " 价格:" << book2.getPrice() << " ISBN:" << book2.getISBN() << endl;

	book2.setDiscount(5);
	cout << "书名:" << book2.getName() << " 折扣价格:" << book2.getPrice() << " ISBN:" << book2.getISBN() << endl;

	cout << "折扣:" << book2.getDiscount() << "折" <<  endl;

	system("pause");
	return 0;
}