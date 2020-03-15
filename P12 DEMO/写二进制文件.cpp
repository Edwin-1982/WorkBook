#include<iostream>
#include<fstream>

using namespace std;

int main(void) {
	string name;
	int age;
	ofstream outfile;

	outfile.open("uscf.dat", ios::out | ios::trunc | ios::binary);
	
	while (1) {
		cout << "请输入姓名:[ctrl+z退出]";
		cin >> name;
		if (cin.eof()) {
			break;
		}

		outfile << name << "\t";

		cout << "请输入年龄:";
		cin >> age;
		//outfile<<age<<endl;
		outfile.write((char*)&age, sizeof(age));
	}
	outfile.close();
	system("pause");
	return 0;
}