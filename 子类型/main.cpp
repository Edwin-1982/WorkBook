#include<iostream>

using namespace std;


class Father {
public:
	void play() {
		cout << "KTV唱歌!" << endl;
	}
};

class Son:public Father {
public:
	void play() {
		cout << "今晚吃鸡!" << endl;
	}
};
void party(Father *f1, Father *f2) {
	f1->play();
	f2->play();
}
void party_1(Father f1, Father f2) {
	f1.play();
	f2.play();
}

/********************************************************
1.基类(父类)的指针,可以指向这个类的公有派生类(子类型)对象.
  Son yangGuo;
  Father *f=&yangGuo;
********************************************************/
//int main(void) {
//	Father yangKang;
//	Son yangGuo;
//
//	party(&yangKang,&yangGuo);
//
//	Father* p;
//	p = &yangGuo;
//	cout << endl;
//	p->play();
//
//	system("pause");
//	return 0;
//}
/***********************************************

2.公有派生类(子类型)的对象可以初始化基类的引用.
Son yangGuo;
Father &f2=yangGuo;

************************************************/
//int main(void) {
//	Father yangKang;
//	Son yangGuo;
//
//	/*Father& p = yangGuo;
//	p.play();*/
//	
//	//cout << endl;
//	Father p(yangGuo);
//	p.play();
//	system("pause");
//	return 0;
//}
/***********************************************

3.公有派生类的对象可以赋值给基类的对象.
Son yangGuo;
Father f1=yangGuo;

************************************************/
int main(void) {
	Father yangKang;
	Son yangGuo;

	party_1(yangKang,yangGuo);
	system("pause");
	return 0;
}