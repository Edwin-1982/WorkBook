#pragma once
class Mother{
public:
	virtual void handle1();
	virtual void handle2();
	virtual void handle3();
public://为了便于测试，使用public权限
	_int64 m = 400;
	_int64 n = 500;
};

