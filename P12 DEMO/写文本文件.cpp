/************************************
*����:
*�û�����������������,�����浽�ļ��С�
*ָ���û�����ctrl+z
*************************************/

#include<iostream>
#include<fstream>
using namespace std;

int write(void) {

	string name;
	int age;
	ofstream outfile;//������һ���ļ����������
	//fstream outfile;

	//ʹ������������һ���ļ�
	outfile.open("uscr.txt");
	//outfile.open("uscr.txt",ios::out|ios::trunc);

	while (1) {
		cout << "����������:[ctrl+z�˳�]";
		cin >> name;
		if (cin.eof()) {
			break;
		}
		//�����������д���ļ�
		outfile << name << "\t";

		cout << "����������";
		cin >> age;

		//������д���ļ�
		outfile << age << endl;
	}

	//�رողŴ򿪵��ļ���
	outfile.close();
	return 0;
}