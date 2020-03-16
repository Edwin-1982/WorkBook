#include<iostream>
#include<fstream>
#include<string>

using namespace std;

int main(void) {
	string line;
	ifstream infile;
	infile.open("¶¨Î».cpp");
	if (!infile.is_open()) {
		return 1;
	}
	infile.seekg(-50, infile.end);

	while (!infile.eof()) {
		getline(infile, line);
		cout << line << endl;
		
	}
	infile.close();
	system("pause");
	return 0;
}
