#include<iostream>
#include<fstream>

using namespace std;

int main(void) {
	string name;
	int age;
	ofstream outfile;

	outfile.open("uscf.dat", ios::out | ios::trunc | ios::binary);
	
	while (1) {
		cout << "����������:[ctrl+z�˳�]";
		cin >> name;
		if (cin.eof()) {
			break;
		}

		outfile << name << "\t";

		cout << "����������:";
		cin >> age;
		//outfile<<age<<endl;
		outfile.write((char*)&age, sizeof(age));
	}
	outfile.close();
	system("pause");
	return 0;
}