#include <iostream>
#include<sstream>
#include "Son.h"


//创建Son对象时,会调用构造函数!
//会先调用父类的构造函数,用来初始化从父类继承的数据
//再调用子类的构造函数,用来初始化自己定义的数据

Son::Son(const char* name, int age, const char* game) :Father(name, age) {

	cout << __FUNCTION__ << endl;

	//没有体现父类的构造函数,就会自动调用父类的默认构造函数
	this->game = game;
}
Son::~Son() {

}
string Son::getGame() {
	return game;
}

string Son::description(){
	stringstream ret;

	// 子类的成员函数中, 不能访问从父类继承的private成员

	ret << "姓名:" << getName() << " 年龄:" << getAge()
		<< " 游戏:" << game;
	return ret.str();
}
