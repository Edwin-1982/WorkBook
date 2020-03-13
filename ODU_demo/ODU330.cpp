#include "ODU330.h"
#include<sstream>


ODU330::ODU330(){
}
ODU330::~ODU330(){

}

float ODU330::getWarnThreshold(){
	return warnThreshold;
}

bool ODU330::setWarnThreshold(float threshold){
	this->warnThreshold = threshold;
	return true;
}

float ODU330::getBER(){
	return 0.00005f;//ģ��ֵ
}

string ODU330::description(){
	stringstream ret;
	ret << "���书��:" << txPower << "\t����Ƶ��:" << txFreq
		<< "\t����:" << bandWidth <<"\t������:"<<getBER()<<"\t�澯����:"<<warnThreshold<< endl;
	return ret.str();
}
