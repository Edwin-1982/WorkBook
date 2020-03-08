#include<iostream>
#include<windows.h>
#include"Boy.h"
#include"Girl.h"
#include <vector>

//自动匹配
void autoPair(const vector<Boy> &boys, const vector<Girl> &girls){
	for (int i = 0; i < boys.size(); i++) {
		for(int j = 0; j < girls.size(); j++) {
			if (boys[i].satisfied(girls[j]) &&
				girls[j].satisfied(boys[i])) {
				cout << boys[i].description() << "<==>" <<
					girls[j].description()<<endl;
			}
		}
	}
}
int main(void) {
	/*
	//vector 顺序容器
	vector<Boy>boys;
	vector<Girl>girls;
	Boy boy1(25, "柳公子", 20000);
	Boy boy2(28, "王公子", 18000);

	boys.push_back(boy1);//尾部添加数据
	boys.push_back(boy2);
	for (int i = 0; i < boys.size(); i++) {
		cout << boys[i].description()<< endl;
	}
	*/
	vector<Boy>boys;
	vector<Girl>girls;

	Boy::inputBoys(boys);
	Girl::inputGirls(girls);

	cout << "\n\n-------------结果------------\n" << endl;
	autoPair(boys, girls);
	
	system("pause");
	return 0;
}