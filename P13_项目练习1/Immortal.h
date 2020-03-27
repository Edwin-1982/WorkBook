#pragma once
#include<iostream>
#include<string>
#include<vector>

using namespace std;

class SpriteStone;
class Monster;

//��������(������,������,�ᵤ��,ԪӤ��,������,������,������,�����,�ɽ���
enum class ImmortalLevel {
	LIAN_QI,
	ZHU_JI,
	JIE_DAN,
	YUAN_YING,
	HUA_SHEN,
	LIAN_XU,
	HE_TI,
	DA_CHENG,
	DU_JIE
};
//��������
class Immortal{
public:
	Immortal(const char* name, const char* menpai, ImmortalLevel level);
	
	//�ڿ�
	void mining();

	//�г���������
	bool trade();

	//�г�����ָ��������
	bool trade(const Monster& monster);

	//����ʯ��������������ָ��������
	bool trade(Immortal& other, const Monster& monster);
	
	//��ָ��������,��ȡ���������ߵ�����
	bool trade(const Monster& monsterSource, Immortal& other, const Monster& monsterDest);
	
	//����������ָ��������
	bool trade(const Monster& monster, Immortal& other);
	
	//ս��������
	int getPower()const;
	
	//��������
	void fight(const Monster& monster);

	friend ostream& operator<<(ostream& os, const Immortal& immortal);
	
	void dead();//��������������
private:
	string name;
	string menpai;//����
	ImmortalLevel level;
	vector<SpriteStone>stones;//��ʯ
	vector<Monster>monsters;  //����
	bool alive; //����״̬

	bool hadMonster(const Monster& monster);//�ж��Ƿ���ָ��������
	bool removeMonster(const Monster& monster);//�Ƴ�ָ��������
};
ostream& operator<<(ostream& os, const Immortal& immortal);
ostream& operator<<(ostream& os, const ImmortalLevel level);
