#include<iostream>
#include"Computer.h"
#include "ComputerService.h"

void ComputerService::upgrade(Computer* computer) {
	
	computer->cpu = "i9";
}

void ComputerService::clean(Computer* computer){
	cout << "正在对电脑进行清理工作[CPU:"
		<< computer->cpu << "]..." 
		<< endl;
}

void ComputerService::kill(Computer* computer){
	cout << "正在对电脑进行杀毒[CPU:"
		<< computer->cpu << "]..."
		<< endl;
}

