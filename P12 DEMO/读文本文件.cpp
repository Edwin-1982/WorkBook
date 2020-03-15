#include<iostream>
#include<fstream>
#include<windows.h>

using namespace std;

int main(void) {
	ifstream inFile;
	string name;
	int age;

	//以读的方式打开
	inFile.open("uscr.txt");

	while (1) {
		//读名字
		inFile >> name;
		if (inFile.eof()) {
			break;
		}
		cout << name << "\t";

		//读年龄
		inFile >> age;
		cout << age << endl;
	}
	inFile.close();
	return 0;
}