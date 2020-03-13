#include<sstream>
#include "ODU.h"

ODU::ODU() {

}
ODU::~ODU(){
}

float ODU::getTxPower(){
	return txPower;
}

int ODU::getTxFreq(){
	return txFreq;
}
float ODU::getBandWidth() {
	return bandWidth;
}


bool ODU::setTxPower(float power){
	//ʵ�ʲ�Ʒ��Ŀ��,��ͨ�����ڷ��Ϳ��ư�ʵ�ֵ�
	txPower = power;
	return true;
}

bool ODU::setTxFreq(int frequency){
	txFreq = frequency;
	return true;
}

bool ODU::setBandWidth(float bandWidth){
	this->bandWidth = bandWidth;
	return true;
}

string ODU::description(){
	stringstream ret;
	ret <<"���书��:"<<txPower<<"\t����Ƶ��:"<<txFreq
		<<"\t����:"<<bandWidth<<endl ;
	return ret.str();
}


