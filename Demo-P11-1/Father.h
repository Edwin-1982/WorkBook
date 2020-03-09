#pragma once
#include<string>

using namespace std;
class Father
{
public:
	Father(const char* name, int age);
	~Father();

	string getName();
	int getAge();
	string description();
protected:
	int age;
	string name;

	/*****************************************************************************
	一个类,如果希望,它的成员,可以被自己的子类(派生类)直接访问,但是又不想被外部访问
	那么就可以把这些成员,定义为protected访问权限!
	*****************************************************************************/
};

/*********************************************************************************
成员的访问权限总结:
public
	外部可以直接访问.
	可以通过对象来访问这个成员
	Father wjl("王健林",65);
	wjl.getName();
private
	外部不可以访问
	自己的成员函数内,可以访问
	Father wjl("王健林",65);
	wjl.name();//错误!!!
	Father 内的所有成员函数内,可以直接访问name;
protected
	proteced和private非常相似
	和private唯一的区别:
		protected:子类的成员函数可以直接访问
		private:子类的成员函数不可以访问
**********************************************************************************/

