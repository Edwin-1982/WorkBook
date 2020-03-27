#pragma once
#include<iostream>
#include<string>
#include<vector>

using namespace std;

class SpriteStone;
class Monster;

//修炼级别(练气期,筑基期,结丹期,元婴期,化神期,炼虚期,合体期,大成期,渡劫期
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
//修仙者类
class Immortal{
public:
	Immortal(const char* name, const char* menpai, ImmortalLevel level);
	
	//挖矿
	void mining();

	//市场售卖妖兽
	bool trade();

	//市场售卖指定的妖兽
	bool trade(const Monster& monster);

	//用灵石购买其他修仙者指定的妖兽
	bool trade(Immortal& other, const Monster& monster);
	
	//用指定的妖兽,换取其他修仙者的妖兽
	bool trade(const Monster& monsterSource, Immortal& other, const Monster& monsterDest);
	
	//把妖兽卖给指定修仙者
	bool trade(const Monster& monster, Immortal& other);
	
	//战斗力计算
	int getPower()const;
	
	//捕获妖兽
	void fight(const Monster& monster);

	friend ostream& operator<<(ostream& os, const Immortal& immortal);
	
	void dead();//修仙者死亡后处理
private:
	string name;
	string menpai;//门派
	ImmortalLevel level;
	vector<SpriteStone>stones;//灵石
	vector<Monster>monsters;  //妖兽
	bool alive; //生死状态

	bool hadMonster(const Monster& monster);//判断是否有指定的妖兽
	bool removeMonster(const Monster& monster);//移除指定的妖兽
};
ostream& operator<<(ostream& os, const Immortal& immortal);
ostream& operator<<(ostream& os, const ImmortalLevel level);
