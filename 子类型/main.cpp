#include<iostream>

using namespace std;


class Father {
public:
	void play() {
		cout << "KTV����!" << endl;
	}
};

class Son:public Father {
public:
	void play() {
		cout << "����Լ�!" << endl;
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
1.����(����)��ָ��,����ָ�������Ĺ���������(������)����.
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

2.����������(������)�Ķ�����Գ�ʼ�����������.
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

3.����������Ķ�����Ը�ֵ������Ķ���.
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