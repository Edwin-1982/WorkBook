#include<iostream>
#include"Human.h"

using namespace std;

int main(void) {
	Human lhc("�����", Male, 25);
	Human ryy("��ӯӯ", Female, 18);
	Human tbg("�ﲮ��", Male, 30);
	Human yls("����ɺ", Female, 20);
	Human cx("�������", Male, 55);

	lhc.marry(yls);
	Human* who = lhc.getSpouse();
	cout << lhc.getNick() << "����ż��: " << who->description() << endl;
	cout << who->getNick() << "����ż��: " << who->getSpouse()->description() << endl;
	cout << endl;
	cout << lhc.getNick() << "���" << endl << endl;
	lhc.divorce();
	if (lhc.getSpouse() == NULL) {
		cout << lhc.getNick()<<"����" << endl;
	}
	else {
		cout << lhc.getNick() << "���ʧ��" << endl;
	}
	cout << endl;

	lhc.addFriend(tbg);
	lhc.addFriend(cx);
	
	vector<Human*>friends = lhc.getFriends();
	cout << "�����ĺ�����Ϣ:" << endl;
	for (int i = 0; i < friends.size(); i++) {
		
		cout<<friends[i]->description() << endl;
	}
	cout << endl;

	lhc.delFriend(tbg);
	cout << lhc.getNick() << "ɾ������: " << tbg.getNick() << endl;

	friends = lhc.getFriends();
	cout << endl;
	for (int i = 0; i < friends.size(); i++) {
		cout << "�����ʣ�����:\n"<<friends[i]->description() << endl;
	}
	system("pause");
	return 0;
}