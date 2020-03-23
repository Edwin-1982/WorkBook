#include<iostream>
#include<fstream>
#include "Database.h"
#include"Boy.h"
#include "Girl.h"         

#define BOYS_FILE "boys.txt"
#define GIRLS_FILE "girls.txt"

//const char* boys_file="boys.txt";//ͬ�궨��

Database::Database(){
}

void Database::init(){
	//��֮ǰ�Ѿ�������ļ���,��ȡ�û���Ϣ,������ʼ���ڲ�����boys��girls
	initBoysFromFile();
	initGirlsFromFile();
}

void Database::autoPair(){
	cout << endl << "�Զ���Խ��;" << endl;
	string line(100, '-');
	cout << line << endl;

	for (int i = 0; i < boys.size(); i++) {
		for (int j = 0; j < girls.size(); j++) {
			if (boys[i].satisfied(girls[j]) &&
				girls[j].satisfied(boys[i])) {
				cout << boys[i].description() << endl;
				cout << girls[j].description() << endl;
				cout << line << endl;
			}
		}
	}
	for (int i = 0; i < girls.size(); i++) {
		for (int j = 0; j < boys.size(); j++) {
			if (girls[j].satisfied(boys[i]) &&
				boys[i].satisfied(girls[j])) {
				cout << girls[i].description() << endl;
				cout << boys[j].description() << endl;
				cout << line << endl;
			}
		}
	}
}

void Database::autoPairBest(){
	cout << endl << "����Զ���Խ��;" << endl;
	string line(100, '-');
	cout << line << endl;

	for (int i = 0; i < boys.size(); i++) {
		Girl* girlBest = NULL;
		for (int j = 0; j < girls.size(); j++) {
			if (boys[i].satisfied(girls[j]) &&
				girls[j].satisfied(boys[i])) {
				if (!girlBest) {
					girlBest = &girls[j];
				}
				else if (girls[j] > * girlBest) {
						girlBest = &girls[j];
				}
				
			}
		}
		if (girlBest) {
			cout << boys[i] << endl;
			cout << *girlBest << endl;
			cout << line << endl;
		}
	}
	for (int i = 0; i <girls.size(); i++) {
		Boy* boyBest = NULL;
		for (int j = 0; j < boys.size(); j++) {
			if (boys[j].satisfied(girls[i]) &&
				girls[i].satisfied(boys[j])) {
				if (!boyBest) {
					boyBest = &boys[j];
				}
				else if (boys[j] > * boyBest) {
					boyBest = &boys[j];
				}

			}
		}
		if (boyBest) {
			cout << girls[i] << endl;
			cout << *boyBest << endl;
			cout << line << endl;
		}
	}
}

void Database::print(){
	cout << "�мα���Ϣ:" << endl;
	for (int i = 0; i < boys.size(); i++) {
		cout << boys[i].description() << endl;
	}

	cout << "\nŮ�α���Ϣ:" << endl;
	for (int i = 0; i < girls.size(); i++) {
		cout << girls[i].description() << endl;
	}
}

void Database::addOne(Boy& boy){
	boys.push_back(boy);
	
	cout << endl << "�Զ���Խ��:" << endl;
	string line(100, '-');
	cout << line << endl;

	for (int j = 0; j < girls.size(); j++) {
		if (boy.satisfied(girls[j]) &&
			girls[j].satisfied(boy)) {
			cout << boy.description() << endl;
			cout << girls[j].description() << endl;
			cout << line << endl;
		}
	}
}

void Database::addOne(Girl& girl){
	girls.push_back(girl);

	cout << endl << "�Զ���Խ��:" << endl;
	string line(100, '-');
	cout << line << endl;
	
	for (int i = 0; i < boys.size(); i++) {
		if (girl.satisfied(boys[i]) &&
			boys[i].satisfied(girl)) {
			cout << girl.description() << endl;
			cout << boys[i].description() << endl;
			cout << line << endl;
		}
	}
}

void Database::initBoysFromFile(){
	//���ļ�->���ļ�����->��ʼ��boys
	ifstream stream;
	stream.open(BOYS_FILE);
	if (!stream.is_open()) {
		//��ʼʱ,û���ļ�!
		//�������������:
		//�ʼû���ļ���,���û���������û�����
		cout << "=== ��������û���Ϣ[�мα�]���� ===" << endl;
		Boy::inputBoys(this->boys);
		saveBoys();
		stream.close();
		return;
	}

	//boys.txt �򿪳ɹ�

	while (1) {
		string line;
		char name[64] = "";
		int salary;
		int age;
		getline(stream, line);

		if (stream.eof()) {
			break;
		}

		//����������һ������
		
		//to do
		//�ļ���ʽ:����:Rock\t\t\t�Ա�:��\t\t\t����:39\t\t\tн��:35000
		int ret=sscanf_s(line.c_str(), "����:%s �Ա�:�� ����:%d н��:%d",name,sizeof(name),&age,&salary);
		if (ret <= 0) {
			cout << "�мα����ݿ��ʽƥ��ʧ��!" << endl;
			exit(1);
		}

		//ʹ�ö�����һ����������Ϣ,������һ��Boy����,����ӵ�boys
		boys.push_back(Boy(age, string(name), salary));
	}
}

void Database::initGirlsFromFile(){
	//���ļ�->���ļ�����->��ʼ��boys
	ifstream stream;
	stream.open(GIRLS_FILE);
	if (!stream.is_open()) {
		//��ʼʱ,û���ļ�!
		//�������������:
		//�ʼû���ļ���,���û���������û�����
		cout << "=== ��������û���Ϣ[Ů�α�]���� ===" << endl;
		Girl::inputGirls(this->girls);
		saveGirls();
		stream.close();
		return;
	}

	//girls.txt �򿪳ɹ�

	while (1) {
		string line;
		char name[64] = "";
		int age;
		int yanZhi;

		getline(stream, line);

		if (stream.eof()) {
			break;
		}
		//����������һ������

		//to do
		//�ļ���ʽ:����:��Ī��\t\t\t�Ա�:Ů\t\t\t����:39\t\t\tyanZhi:100
		int ret = sscanf_s(line.c_str(), "����:%s �Ա�:Ů ����:%d ��ֵ:%d",name,sizeof(name),&age,&yanZhi);
		if (ret <= 0) {
			cout << "Ů�α����ݿ��ʽƥ��ʧ��!" << endl;
			exit(1);
		}

		//ʹ�ö�����һ������Ů��Ϣ,������һ��Girl����,����ӵ�girls
		girls.push_back(Girl(age, string(name), yanZhi));

	}
}

void Database::saveBoys(){
	
	//��boys�е����е�������Ϣд���ļ�
	ofstream stream;
	stream.open(BOYS_FILE);
	if (!stream.is_open()) {
		cout << BOYS_FILE << "д��ʧ��!" << endl;
		exit(1);
	}
	for (int i = 0; i < boys.size(); i++) {
		stream<<boys[i].description()<<endl;
	}
	stream.close();
}

void Database::saveGirls(){
	//��girls�е����е�������Ϣд���ļ�
	ofstream stream;
	stream.open(GIRLS_FILE);
	if (!stream.is_open()) {
		cout << GIRLS_FILE << "д��ʧ��!" << endl;
		exit(1);
	}
	for (int i = 0; i < girls.size(); i++) {
		stream << girls[i].description() << endl;
	}
	stream.close();
}
