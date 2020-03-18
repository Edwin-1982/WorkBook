#pragma once
#include<vector>
#include<string>

using namespace std;

class Boy;
class Girl;
/*****************************************************
* ����:
* init()//��ʼ��,���ļ��ж�ȡ������Ϣ,����ʼ���û�����
* autoPair()//�Զ����
* print()     //��ӡ�����ݿ��е������û���Ϣ
* ����:
*	vector<Boy>boys;//���е�������Ϣ
*	vector<Girl>girls;//���е���Ů��Ϣ
******************************************************/
class Database{
public:
	Database();

	//��ʼ��,���ļ��ж�ȡ������Ϣ,����ʼ���û�����
	void init();

	//�Զ����
	void autoPair();

	//��ӡ�����ݿ��е������û���Ϣ
	void print();

	void addOne(Boy& boy);
	void addOne(Girl& girl);


private:
	//���е�������Ϣ
	vector<Boy>boys;
	//���е�������Ϣ
	vector<Girl>girls;

	//���ļ�����Ϣ����ʼ��boys
	void initBoysFromFile();

	//���ļ�����Ϣ����ʼ��boys
	void initGirlsFromFile();

	//����
	void saveBoys();
	void saveGirls();

};

