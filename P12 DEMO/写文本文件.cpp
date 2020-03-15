/************************************
*需求:
*用户来输入姓名和年龄,并保存到文件中。
*指导用户输入ctrl+z
*************************************/

#include<iostream>
#include<fstream>
using namespace std;

int write(void) {

	string name;
	int age;
	ofstream outfile;//定义了一个文件输出流对象
	//fstream outfile;

	//使用输出流对象打开一个文件
	outfile.open("uscr.txt");
	//outfile.open("uscr.txt",ios::out|ios::trunc);

	while (1) {
		cout << "请输入姓名:[ctrl+z退出]";
		cin >> name;
		if (cin.eof()) {
			break;
		}
		//把输入的姓名写入文件
		outfile << name << "\t";

		cout << "请输入年龄";
		cin >> age;

		//把年龄写入文件
		outfile << age << endl;
	}

	//关闭刚才打开的文件流
	outfile.close();
	return 0;
}