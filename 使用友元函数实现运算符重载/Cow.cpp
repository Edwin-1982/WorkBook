#include<sstream>
#include "Cow.h"
//#include"Horse.h"
//#include"Pork.h"


Cow::Cow(int weight){
	this->weight = weight;
}
Cow Cow::operator+(int n){
	int tmp=weight + n;
	return Cow(tmp);
}

string Cow::description(){
	stringstream ret;
	ret << "Ò»Í·Å£" << weight << "½ïµÄÅ£Èâ" << endl;
	return ret.str();
}

/*
1½ïÅ£Èâ:2½ïÖíÈâ
1½ïÂíÈâ:3½ïÖíÈâ
*/

//Pork Cow::operator+(const Horse& horse){
//	int tmp = this->weight * 2 + horse.getWeight()*3;
//	return Pork(tmp);
//}
/*
1½ïÅ£Èâ:2½ïÖíÈâ
*/
//Pork Cow::operator+(const Cow& cow){
//	int tmp = (this->weight + cow.weight) * 2;
//	return Pork(tmp);
//}
