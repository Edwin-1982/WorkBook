#include "Cow.h"
#include"Horse.h"
#include"Pork.h"

Cow::Cow(int weight){
	this->weight = weight;
}
/*
1��ţ��:2������
1������:3������
*/

Pork Cow::operator+(const Horse& horse){
	int tmp = this->weight * 2 + horse.getWeight()*3;
	return Pork(tmp);
}
/*
1��ţ��:2������
*/
Pork Cow::operator+(const Cow& cow){
	int tmp = (this->weight + cow.weight) * 2;
	return Pork(tmp);
}
