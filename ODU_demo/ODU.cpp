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
	//实际产品项目中,是通过串口发送控制包实现的
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
	ret <<"发射功率:"<<txPower<<"\t发射频率:"<<txFreq
		<<"\t带宽:"<<bandWidth<<endl ;
	return ret.str();
}


