/**************************************
写一个最简单的例子,来实现"派生",继承""
父类  子类
**************************************/
#include<iostream>
#include"Father.h"
#include"Son.h"

int main(void) {
	Father wjl("王健林", 68);
	Son wsc("王思聪", 32,"电竞");
	cout << wjl.description() << endl;

	// 子类对象调用方法时, 先在自己定义的方法中去寻找, 如果有, 就调用自己定义的方法
	// 如果找不到, 就到父类的方法中去找, 如果有, 就调用父类的这个同名方法
	// 如果还是找不到, 就是发生错误!

	cout <<wsc.description() << endl;

	cout << sizeof(wjl) << endl;
	cout << sizeof(wsc) << endl;

	system("pause");
	return 0;
}

