#include<iostream>
#include<fstream>
#include "Database.h"
#include"Boy.h"
#include "Girl.h"         

#define BOYS_FILE "boys.txt"
#define GIRLS_FILE "girls.txt"

//const char* boys_file="boys.txt";//同宏定义

Database::Database(){
}

void Database::init(){
	//从之前已经保存的文件中,读取用户信息,用来初始化内部数据boys和girls
	initBoysFromFile();
	initGirlsFromFile();
}

void Database::autoPair(){
	cout << endl << "自动配对结果;" << endl;
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
	cout << endl << "最佳自动配对结果;" << endl;
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
	cout << "男嘉宾信息:" << endl;
	for (int i = 0; i < boys.size(); i++) {
		cout << boys[i].description() << endl;
	}

	cout << "\n女嘉宾信息:" << endl;
	for (int i = 0; i < girls.size(); i++) {
		cout << girls[i].description() << endl;
	}
}

void Database::addOne(Boy& boy){
	boys.push_back(boy);
	
	cout << endl << "自动配对结果:" << endl;
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

	cout << endl << "自动配对结果:" << endl;
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
	//打开文件->读文件内容->初始化boys
	ifstream stream;
	stream.open(BOYS_FILE);
	if (!stream.is_open()) {
		//开始时,没有文件!
		//假设有这个需求:
		//最开始没有文件是,让用户输入基础用户数据
		cout << "=== 输入基础用户信息[男嘉宾]数据 ===" << endl;
		Boy::inputBoys(this->boys);
		saveBoys();
		stream.close();
		return;
	}

	//boys.txt 打开成功

	while (1) {
		string line;
		char name[64] = "";
		int salary;
		int age;
		getline(stream, line);

		if (stream.eof()) {
			break;
		}

		//解析读到的一行数据
		
		//to do
		//文件格式:姓名:Rock\t\t\t性别:男\t\t\t年龄:39\t\t\t薪资:35000
		int ret=sscanf_s(line.c_str(), "姓名:%s 性别:男 年龄:%d 薪资:%d",name,sizeof(name),&age,&salary);
		if (ret <= 0) {
			cout << "男嘉宾数据库格式匹配失败!" << endl;
			exit(1);
		}

		//使用读到的一个单身男信息,来构建一个Boy对象,并添加到boys
		boys.push_back(Boy(age, string(name), salary));
	}
}

void Database::initGirlsFromFile(){
	//打开文件->读文件内容->初始化boys
	ifstream stream;
	stream.open(GIRLS_FILE);
	if (!stream.is_open()) {
		//开始时,没有文件!
		//假设有这个需求:
		//最开始没有文件是,让用户输入基础用户数据
		cout << "=== 输入基础用户信息[女嘉宾]数据 ===" << endl;
		Girl::inputGirls(this->girls);
		saveGirls();
		stream.close();
		return;
	}

	//girls.txt 打开成功

	while (1) {
		string line;
		char name[64] = "";
		int age;
		int yanZhi;

		getline(stream, line);

		if (stream.eof()) {
			break;
		}
		//解析读到的一行数据

		//to do
		//文件格式:姓名:李莫愁\t\t\t性别:女\t\t\t年龄:39\t\t\tyanZhi:100
		int ret = sscanf_s(line.c_str(), "姓名:%s 性别:女 年龄:%d 颜值:%d",name,sizeof(name),&age,&yanZhi);
		if (ret <= 0) {
			cout << "女嘉宾数据库格式匹配失败!" << endl;
			exit(1);
		}

		//使用读到的一个单身女信息,来构建一个Girl对象,并添加到girls
		girls.push_back(Girl(age, string(name), yanZhi));

	}
}

void Database::saveBoys(){
	
	//把boys中的所有单身男信息写入文件
	ofstream stream;
	stream.open(BOYS_FILE);
	if (!stream.is_open()) {
		cout << BOYS_FILE << "写入失败!" << endl;
		exit(1);
	}
	for (int i = 0; i < boys.size(); i++) {
		stream<<boys[i].description()<<endl;
	}
	stream.close();
}

void Database::saveGirls(){
	//把girls中的所有单身男信息写入文件
	ofstream stream;
	stream.open(GIRLS_FILE);
	if (!stream.is_open()) {
		cout << GIRLS_FILE << "写入失败!" << endl;
		exit(1);
	}
	for (int i = 0; i < girls.size(); i++) {
		stream << girls[i].description() << endl;
	}
	stream.close();
}
