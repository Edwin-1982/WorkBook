#include<iostream>
#include"Toy.h"

int main(void) {
	Toy toy("变形金刚", 5600, "China");
	cout << toy.getName() << ":"<<toy.getPrice()<<":"<<toy.getOrigin()<<":"<<endl;
	cout << endl;
	cout << "修改折扣后:" << endl;
	toy.setDiscount(2.0);
	cout << toy.getName() << ":" << toy.getPrice() << ":" << toy.getOrigin() << ":" << endl;
	
	system("pause");
	return 0;
}