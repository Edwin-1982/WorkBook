#include<iostream>
#include<string>
#include<fstream>
#include<Windows.h>


using namespace std;

int main(void) {
	ifstream infile;
	string line;
	char name[32];
	int age;

	infile.open("uscr.txt");
	if (!infile.is_open()) {
		cout << "�ļ���ʧ��!" << endl;
		system("pause");
		return 1;
	}
	while (1) {
		getline(infile,line);
		if (infile.eof()) {
			break;
		}

		sscanf_s(line.c_str(), "����:%s ����:%d", name, sizeof(name), &age);
		cout << "����: " << name << "\t\t����" << age << endl;
	}
	infile.close();
	system("pause");
	return 0;
}