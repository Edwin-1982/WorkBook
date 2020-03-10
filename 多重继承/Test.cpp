#include<windows.h>
#include"Son.h"

int main(void) {

	Son wsc("王", "思聪", "川菜", "吃鸡游戏");
	cout << endl;
	wsc.playBasketball();

	//解决多重继承的二义性的方法1:
	//使用"类名::"进行制定,指定调用从哪个基类继承的方法!
	
	/*
	wsc.Father::dance();
	wsc.Mother::dance();
	*/

	//解决多重继承的二义性的方法2:
	//在子类中重新实现这个同名方法,并在这个方法内部,使用基类名进行限定,来调用对应的基类方法
	cout << endl;
	wsc.playGame();
	cout << endl;
	wsc.dance();

	system("pause");
	return 0;
}