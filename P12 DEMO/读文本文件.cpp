#include<iostream>
#include<fstream>
#include<windows.h>

using namespace std;

int main(void) {
	ifstream inFile;
	string name;
	int age;

	//�Զ��ķ�ʽ��
	inFile.open("uscr.txt");

	while (1) {
		//������
		inFile >> name;
		if (inFile.eof()) {
			break;
		}
		cout << name << "\t";

		//������
		inFile >> age;
		cout << age << endl;
	}
	inFile.close();
	return 0;
}