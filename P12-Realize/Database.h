#pragma once
#include<vector>
#include<string>

using namespace std;

class Boy;
class Girl;
/*****************************************************
* 功能:
* init()//初始化,从文件中读取数据信息,来初始化用户数据
* autoPair()//自动配对
* print()     //打印该数据库中的所有用户信息
* 数据:
*	vector<Boy>boys;//所有单身男信息
*	vector<Girl>girls;//所有单身女信息
******************************************************/
class Database{
public:
	Database();

	//初始化,从文件中读取数据信息,来初始化用户数据
	void init();

	//自动配对
	void autoPair();

	//打印该数据库中的所有用户信息
	void print();

	void addOne(Boy& boy);
	void addOne(Girl& girl);


private:
	//所有单身男信息
	vector<Boy>boys;
	//所有单身男信息
	vector<Girl>girls;

	//用文件中信息来初始化boys
	void initBoysFromFile();

	//用文件中信息来初始化boys
	void initGirlsFromFile();

	//保存
	void saveBoys();
	void saveGirls();

};

