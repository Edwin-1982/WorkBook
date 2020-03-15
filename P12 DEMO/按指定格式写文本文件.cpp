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
		cout << "请输入姓名:[ctrl+z退出]";
		cin >> name;
		if (cin.eof()) {
			break;
		}
		cout << "请输入年龄: ";
		cin >> age;
		stringstream s;
		s << "姓名:" << name << "\t\t年龄:"<<age << endl;

		//把格式化的数据写入文件
		outfile << s.str();
	}
	outfile.close();
	system("pause");
	return 0;
}