#include<iostream>
#include<fstream>
#include<string>

using namespace std;

/*
�������ļ�д��:"123456789"
Ȼ�����ڵ�4���ַ���ְд��"ABC"
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