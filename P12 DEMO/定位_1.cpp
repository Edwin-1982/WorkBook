#include<iostream>
#include<fstream>
#include<string>

using namespace std;

//����һ������,����ָ���ļ��Ĵ�С
long long getSize(const char* fileName) {
	ifstream infile;

	infile.open(fileName);
	if (!infile.is_open()) {
		return 0;
	}

	//�Ȱ��ļ�ֽ���ƶ����ļ�β
	infile.seekg(0, infile.end);

	long long ret = infile.tellg();
	infile.close();
	return ret;
}
int main(void) {
	cout << getSize("��λ_1.cpp") << endl;
	system("pause");
	return 0;
}