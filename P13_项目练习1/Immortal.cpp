#include "Immortal.h"
#include"Monster.h"
#include"SpriteStone.h"

#define IMMORTAL_LEVEL_FACTOR 1000
#define SPRITESTONE_FACTOR    0.1
#define MONSTER_FACTOR        0.1

Immortal::Immortal(const char* name, const char* menpai, ImmortalLevel level){
	this->name = name;
	this->menpai = menpai;
	this->level = level;
	this->alive = true;
}

void Immortal::mining(){
	stones.push_back(SpriteStone(100, SpriteStoneLevel::PRIMARY_LEVEL));
}

bool Immortal::trade(){
	if (!alive) {
		return false;
	}
	SpriteStone stone;
	for (int i = 0; i < monsters.size(); i++) {
		//����ʹ��+=,��Ϊֻ������+
		stone = stone+monsters[i].getValue();
	}
	stones.push_back(stone);
	monsters.erase(monsters.begin(), monsters.end());
	return false;
}

bool Immortal::trade(const Monster& monster){
	if (!alive) {
		return false;
	}
	//�ж��Ƿ���ָ��������
	if (!hadMonster(monster)) {
		cout << name << "û��" << monster << endl;
		return false;
	}
	SpriteStone stone = monster.getValue();
	stones.push_back(stone);
	removeMonster(monster);
	return false;
}

bool Immortal::trade(Immortal& other, const Monster& monster){
	if (alive == false || other.alive == false) {
		return false;
	}
	if (!other.hadMonster(monster)) {
		cout << other.name << "û��" << monster <<"\n"<< endl;
		return false;
	}

	//���㵱ǰ������ʯ���ܼ�
	SpriteStone stone;
	for (int i = 0; i < stones.size(); i++) {
		stone = stone + stones[i];
	}
	if (stone >= monster.getValue()) {
		//����
		SpriteStone valueStone = monster.getValue();
		stone = stone - valueStone;
		stones.clear();
		stones.push_back(stone);

		monsters.push_back(monster);
		other.removeMonster(monster);
		other.stones.push_back(valueStone);
		return true;
	}
	else {
		cout << "��Ǹ!" << name << "����ʯ������" << monster << endl;
		return false;
	}
}

bool Immortal::trade(const Monster& monsterSource, Immortal& other, const Monster& monsterDest) {
	if (alive == false || other.alive == false) {
		return false;
	}
	if (monsterSource == monsterDest || 
		!hadMonster(monsterSource) || 
		!other.hadMonster(monsterDest)||
		!(monsterSource.getValue()>=monsterDest.getValue())){
		return false;
	}
	removeMonster(monsterSource);
	other.removeMonster(monsterDest);
	monsters.push_back(monsterDest);
	other.monsters.push_back(monsterSource);

	return false;
}

bool Immortal::trade(const Monster& monster, Immortal& other){
	if (alive == false || other.alive == false) {
		return false;
	}
	if (!hadMonster(monster)) {
		cout << name << "û��" << monster << "\n" << endl;
	}
	SpriteStone otherStone;
	for (int i = 0; i < other.stones.size(); i++) {
		otherStone = otherStone + other.stones[i];
	}
	if (!(otherStone >= monster.getValue())) {
		return false;
	}
	//�Է������߸�Ǯ
	otherStone = otherStone - monster.getValue();
	other.stones.clear();
	other.stones.push_back(otherStone);

	//�Է�������������
	other.monsters.push_back(monster);

	//�����Ƴ�����
	this->removeMonster(monster);
	//������ȡ��ʯ
	this->stones.push_back(monster.getValue());
	return false;
}

int Immortal::getPower() const{
	//���������߼����ս����
	int ret = ((int)level + 1) * IMMORTAL_LEVEL_FACTOR;

	//������ʯ������ս����
	SpriteStone stone;
	for (int i = 0; i < stones.size(); i++) {
		stone = stone + stones[i];
	}
	ret += stone.getCount()*SPRITESTONE_FACTOR;

	//�����������޵�����ս����
	for (int i = 0; i < monsters.size(); i++) {
		ret+=monsters[i].getPower()*MONSTER_FACTOR;
	}
	return ret;
}

void Immortal::fight(const Monster& monster){
	int selfPower = getPower();
	int monsterPower = monster.getPower();
	if (selfPower > monsterPower) {
		monsters.push_back(monster);
	}
	else if (selfPower < monsterPower) {
		dead();
	}
}

void Immortal::dead(){
	alive = false;
	stones.erase(stones.begin(), stones.end());
	monsters.erase(monsters.begin(), monsters.end());
}

bool Immortal::hadMonster(const Monster& monster){
	for (int i = 0; i < monsters.size(); i++) {
		if (monster == monsters[i]) {
			return true;
		}
	}
	return false;
}

bool Immortal::removeMonster(const Monster& monster){
	//����һ��������(��һ�������ָ��,ָ��monsters�еĵ�һ����Ա)
	vector<Monster>::iterator it = monsters.begin();
	while (it != monsters.end()) {
		if (*it == monster) {
			it=monsters.erase(it);
			return true;
		}
		else {
			it++;
		}
	}
	return false;
}

ostream& operator<<(ostream& os, const Immortal& immortal){
	os << "[������]" << immortal.name
		<< (immortal.alive ? "[����]":"[����]")
		<< "\t����:" << immortal.menpai
		<< "\t����:" << immortal.level;
	SpriteStone stone;
	for (int i = 0; i < immortal.stones.size(); i++) {
		stone = stone + immortal.stones[i];
	}
	os << "\t��ʯ:�ۺ�" << stone ;
	os << "\t����:";
	if (immortal.monsters.size() == 0) {
		os << "��";
	}
	else {
		for (int i = 0; i < immortal.monsters.size(); i++) {
			os << immortal.monsters[i] << "";
		}
	}
	return os;
}

ostream& operator<<(ostream& os, const ImmortalLevel level){
	switch (level){
	case ImmortalLevel::LIAN_QI:
		os << "������";
		break;
	case ImmortalLevel::ZHU_JI:
		os << "������";
		break;
	case ImmortalLevel::JIE_DAN:
		os << "�ᵤ��";
		break;
	case ImmortalLevel::YUAN_YING:
		os << "ԪӤ��";
		break;
	case ImmortalLevel::HUA_SHEN:
		os << "������";
		break;
	case ImmortalLevel::LIAN_XU:
		os << "������";
		break;
	case ImmortalLevel::HE_TI:
		os << "������";
		break;
	case ImmortalLevel::DA_CHENG:
		os << "�����";
		break;
	case ImmortalLevel::DU_JIE:
		os << "�ɽ���";
		break;
	default:
		break;
	}
	return os;
}
