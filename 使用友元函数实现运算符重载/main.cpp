#include<iostream>
#include"Cow.h"
#include"Horse.h"
#include"Pork.h"

Pork operator+(const Cow& cow1, const Cow& cow2) {
	int tmp = (cow1.weight + cow2.weight) * 2;
	return Pork(tmp);
}

Pork operator+(const Cow& cow, const Horse& horse) {
	int tmp = cow.weight * 2 + horse.getWeight() * 3;
	return Pork(tmp);
}

Pork operator+(const Horse& horse, const Cow& cow) {
	int tmp = cow.weight * 2 + horse.getWeight() * 3;
	return Pork(tmp);
}
Cow operator+(int n, const Cow& cow){
	int tmp = n + cow.weight;
	return Cow(tmp);
}
int main(void) {
	Cow c1(100);
	//Cow c2(200);
	Cow c2=c1+200;
	Cow c3 = 200 + c1;
	//此时调用的是:c1.operator+(c2)
	//Pork p = c1 + c2;
	//Pork p = c1.operator+(c2);
	/*
	Pork p = c1 + c2;
	cout << p.description() << endl;

	Horse h1(100);
	p = c1 + h1;
	cout << p.description() << endl;
	
	p = h1 + c1;
	cout << p.description() << endl;
	*/
	//编译器去找:
	//1)g1.operator+(c1);
	//2)operator+(g1, c1);
	cout << c2.description() << endl; 
	cout << c3.description() << endl;
	system("pause");
	return 0;
}