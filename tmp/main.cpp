#include<iostream>
#include<fstream>

using namespace std;

int main(void) {
	ofstream stream;
	int num;
	int n = 0;
	stream.open("num.txt");
	if (!stream.is_open()) {
		cout << "�ļ���ʧ��!" << endl;
		exit(1);
	}
	while (1) {

		//����һ������
		cout << "������һ������:";
		cin >> num;

		if (cin.eof()) {
			break;
		}
		//����������,��Ҫ��������

		while (cin.fail()) {
			cin.clear();//��������־
			//cin.sync(); //C++ �в�����
			//��cin�����뻺�����е�����ȫ�����,ֱ�������س���
			cin.ignore(std::numeric_limits<streamsize>::max(), '\n');
			cout << "��������,����������:";
			cin >> num;
		}
		//д�����ݵ��ļ�
		stream << num << "\t";
		if (++n % 10 == 0) {
			stream << endl;
		}
	}
	stream.close();
	system("pause");
	return 0;
}