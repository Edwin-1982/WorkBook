#pragma once
#include <string>

using namespace std;

class ODU
{
public:
	ODU();
	~ODU();

	float getTxPower();
	int getTxFreq();
	float getBandWidth();

	
	bool setTxPower(float power);
	bool setTxFreq(int frequency);
	bool setBandWidth(float bandWidth);

	string description();
protected:
	float txPower;//���书��
	int txFreq;//����Ƶ��
	float bandWidth;//����.��λ:M
};

