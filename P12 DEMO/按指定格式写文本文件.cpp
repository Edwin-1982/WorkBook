#include<iostream>
#include<fstream>
#include<Windows.h>
#include<string.h>
#include<sstream>

using namespace std;

int main(void) {
	string name;
	int age;
	ofstream outfile;
	outfile.open("uscr.txt");
	while (1) {
		cout << "����������:[ctrl+z�˳�]";
		cin >> name;
		if (cin.eof()) {
			break;
		}
		cout << "����������: ";
		cin >> age;
		stringstream s;
		s << "����:" << name << "\t\t����:"<<age << endl;

		//�Ѹ�ʽ��������д���ļ�
		outfile << s.str();
	}
	outfile.close();
	system("pause");
	return 0;
}