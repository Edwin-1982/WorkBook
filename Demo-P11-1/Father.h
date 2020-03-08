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
private:
	string name;
	int age;

};

