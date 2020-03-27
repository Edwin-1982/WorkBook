#pragma once
#include<iostream>
#include<string>

using namespace std;

class SpriteStone;

//������
class Monster{
public:
	Monster(int level = 1, const string& category = "δ֪");
	
	SpriteStone getValue()const; 
	int getPower()const;//��ȡ�����޵�ս����
	friend ostream& operator<<(ostream& os, const Monster& monster);
	friend bool  operator==(const Monster& one, const Monster& other);

private:
	string category;//��������
	int level;//1-9��
};

//�ǳ�Ա����ʵ�����������
ostream& operator<<(ostream& os, const Monster& monster);
//��Ա����ʵ�����������
bool operator==(const Monster& one, const Monster& other);