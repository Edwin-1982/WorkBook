/**************************************
дһ����򵥵�����,��ʵ��"����",�̳�""
����  ����
**************************************/
#include<iostream>
#include"Father.h"
#include"Son.h"

int main(void) {
	Father wjl("������", 68);
	Son wsc("��˼��", 32,"�羺");
	cout << wjl.description() << endl;

	// ���������÷���ʱ, �����Լ�����ķ�����ȥѰ��, �����, �͵����Լ�����ķ���
	// ����Ҳ���, �͵�����ķ�����ȥ��, �����, �͵��ø�������ͬ������
	// ��������Ҳ���, ���Ƿ�������!

	cout <<wsc.description() << endl;

	cout << sizeof(wjl) << endl;
	cout << sizeof(wsc) << endl;

	system("pause");
	return 0;
}

