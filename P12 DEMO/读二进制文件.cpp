#include<iostream>
#include<fstream>
#include<string>

using namespace std;

int main(void) {
	string name;
	int age;
	ifstream infile;
	infile.open("uscf.dat", ios::in | ios::binary);

	while (1) {
		infile >> name;
		if (infile.eof()) {
			break;
		}
		cout << name << "\t";

		//跳过中间的制表符
		char tmp;
		infile.read(&tmp, sizeof(tmp));
		
		//infile >> age;//从文本文件中读取整数,使用这个方式
		infile.read((char*)& age, sizeof(age));
		cout << age << endl;

	}
	infile.close();
	system("pause");
	return 0;
}