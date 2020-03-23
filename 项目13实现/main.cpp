#include<iostream>
#include<windows.h>
#include"Boy.h"
#include"Girl.h"
#include"Database.h"
#include <vector>

/*******************************************************************
//自动匹配
void autoPair(const vector<Boy>& boys, const vector<Girl>& girls) {
	for (int i = 0; i < boys.size(); i++) {
		for (int j = 0; j < girls.size(); j++) {
			if (boys[i].satisfied(girls[j]) &&
				girls[j].satisfied(boys[i])) {
				cout << boys[i].description() << "<==>" <<
					girls[j].description() << endl;
			}
		}
	}
}
********************************************************************/

/*****************************************************
* 需求:要是用文件来保存用户信息
* 分析:设计一个类,来实现信息的保存功能
* Database 数据库
* 功能:
* init()//初始化,从文件中读取数据信息,来初始化用户数据
* autoPair()//自动配对
* print()     //打印该数据库中的所有用户信息
* 数据:
*	vector<Boy>boys;//所有单身男信息
*	vector<Girl>girls;//所有单身女信息
******************************************************/
int main(void) {
	
	/*****************************************************
	vector<Boy>boys;
	vector<Girl>girls;

	Boy::inputBoys(boys);
	Girl::inputGirls(girls);

	cout << "\n\n-------------结果------------\n" << endl;
	autoPair(boys, girls);
	******************************************************/
	Database data;
	data.init();
	data.print();
	/*Boy boy;
	Boy::inputBoy(boy);

	Girl girl;
	Girl::inputGirl(girl);

	data.addOne(boy);
	data.addOne(girl);*/
	data.autoPair();
	data.autoPairBest();
	system("pause");
	return 0;
}
/*
输入用例:
25 杨过 15000
28 郭靖 12000
36 段玉 50000
26 陆展元 15500
0
18 小龙女 95
25 黄蓉 85
26 秋香 90
26 李莫愁 100
0
*/