#include<iostream>
#include"Book.h"
#include"SellBook.h"

int main(void) {

	Book book1("C#�߼����",98, "ISBN20192556875632");
	cout <<"����:"<<book1.getName()<< " �۸�:" << book1.getPrice() << " ISBN:" << book1.getISBN() << endl;

	SellBook book2("C++ʵս����",120, "ISBN201952136987-9");
	cout << "����:" << book2.getName() << " �۸�:" << book2.getPrice() << " ISBN:" << book2.getISBN() << endl;

	book2.setDiscount(5);
	cout << "����:" << book2.getName() << " �ۿۼ۸�:" << book2.getPrice() << " ISBN:" << book2.getISBN() << endl;

	cout << "�ۿ�:" << book2.getDiscount() << "��" <<  endl;

	system("pause");
	return 0;
}