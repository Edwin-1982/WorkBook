#include<iostream>
#include"Computer.h"
#include "ComputerService.h"

void ComputerService::upgrade(Computer* computer) {
	
	computer->cpu = "i9";
}

void ComputerService::clean(Computer* computer){
	cout << "���ڶԵ��Խ���������[CPU:"
		<< computer->cpu << "]..." 
		<< endl;
}

void ComputerService::kill(Computer* computer){
	cout << "���ڶԵ��Խ���ɱ��[CPU:"
		<< computer->cpu << "]..."
		<< endl;
}

