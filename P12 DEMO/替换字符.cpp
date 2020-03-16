#include<iostream>
#include<fstream>
#include<string>

using namespace std;

/*
先向新文件写入:"123456789"
然后再在第4个字符文职写入"ABC"
*/

int main(void) {
	ofstream outfile;

	outfile.open("test.txt");
	if (!outfile.is_open()) {
		return 1;
	}
	outfile << "123456789";
	outfile.seekp(4, outfile.beg);
	outfile << "ABC";

	outfile.close();
	system("pause");
	return 0;
}