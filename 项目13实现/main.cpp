#include<iostream>
#include<windows.h>
#include"Boy.h"
#include"Girl.h"
#include"Database.h"
#include <vector>

/*******************************************************************
//�Զ�ƥ��
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
* ����:Ҫ�����ļ��������û���Ϣ
* ����:���һ����,��ʵ����Ϣ�ı��湦��
* Database ���ݿ�
* ����:
* init()//��ʼ��,���ļ��ж�ȡ������Ϣ,����ʼ���û�����
* autoPair()//�Զ����
* print()     //��ӡ�����ݿ��е������û���Ϣ
* ����:
*	vector<Boy>boys;//���е�������Ϣ
*	vector<Girl>girls;//���е���Ů��Ϣ
******************************************************/
int main(void) {
	
	/*****************************************************
	vector<Boy>boys;
	vector<Girl>girls;

	Boy::inputBoys(boys);
	Girl::inputGirls(girls);

	cout << "\n\n-------------���------------\n" << endl;
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
��������:
25 ��� 15000
28 ���� 12000
36 ���� 50000
26 ½չԪ 15500
0
18 С��Ů 95
25 ���� 85
26 ���� 90
26 ��Ī�� 100
0
*/