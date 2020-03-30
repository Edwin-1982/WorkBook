#pragma once
#include"Father.h"
#include"Mother.h"
class Son:public Father,public Mother {
public:
	void func1();
	virtual void handle1();
	virtual void func5();
	
private:
	int m = 0;
};

