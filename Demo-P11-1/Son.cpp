#include <iostream>
#include<sstream>
#include "Son.h"


//����Son����ʱ,����ù��캯��!
//���ȵ��ø���Ĺ��캯��,������ʼ���Ӹ���̳е�����
//�ٵ�������Ĺ��캯��,������ʼ���Լ����������

Son::Son(const char* name, int age, const char* game) :Father(name, age) {

	cout << __FUNCTION__ << endl;

	//û�����ָ���Ĺ��캯��,�ͻ��Զ����ø����Ĭ�Ϲ��캯��
	this->game = game;
}
Son::~Son() {

}
string Son::getGame() {
	return game;
}

string Son::description(){
	stringstream ret;

	// ����ĳ�Ա������, ���ܷ��ʴӸ���̳е�private��Ա

	ret << "����:" << getName() << " ����:" << getAge()
		<< " ��Ϸ:" << game;
	return ret.str();
}
