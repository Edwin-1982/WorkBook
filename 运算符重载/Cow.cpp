#include "Cow.h"
#include"Horse.h"
#include"Pork.h"

Cow::Cow(int weight){
	this->weight = weight;
}
/*
1½ïÅ£Èâ:2½ïÖíÈâ
1½ïÂíÈâ:3½ïÖíÈâ
*/

Pork Cow::operator+(const Horse& horse){
	int tmp = this->weight * 2 + horse.getWeight()*3;
	return Pork(tmp);
}
/*
1½ïÅ£Èâ:2½ïÖíÈâ
*/
Pork Cow::operator+(const Cow& cow){
	int tmp = (this->weight + cow.weight) * 2;
	return Pork(tmp);
}
