#pragma once
#include "ODU.h"
class ODU330 :public ODU{
public:
	ODU330();
	~ODU330();

	float getWarnThreshold();
	bool setWarnThreshold(float threshold);
	float getBER();//��ȡ��ǰ������
	string description();
private:
	float warnThreshold=0.0f;//�澯����
};

