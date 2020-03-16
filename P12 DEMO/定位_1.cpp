#include<iostream>
#include<fstream>
#include<string>

using namespace std;

//定义一个函数,返回指定文件的大小
long long getSize(const char* fileName) {
	ifstream infile;

	infile.open(fileName);
	if (!infile.is_open()) {
		return 0;
	}

	//先把文件纸针移动到文件尾
	infile.seekg(0, infile.end);

	long long ret = infile.tellg();
	infile.close();
	return ret;
}
int main(void) {
	cout << getSize("定位_1.cpp") << endl;
	system("pause");
	return 0;
}