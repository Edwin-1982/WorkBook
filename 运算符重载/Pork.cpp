#include<sstream>
#include "Pork.h"

Pork::Pork(int weight){
	this->weight = weight;
}

string Pork::description(){
	stringstream ret;
	ret << weight<<"������" << endl;
	return ret.str();
}
