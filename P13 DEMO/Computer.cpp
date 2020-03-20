#include<sstream>
#include "Computer.h"

Computer::Computer(){
	cpu = "i7";
}
string Computer::description(void){
	stringstream ret;
	ret << "CPU:" <<cpu<< endl;
	return ret.str();
}

//void upgrade(Computer* computer){
//}
