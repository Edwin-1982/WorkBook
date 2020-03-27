#pragma once
#include<iostream>
#include <string>
using namespace std;
enum class SpriteStoneLevel{
	PRIMARY_LEVEL,
	MIDDLE_LEVEL,
	ADVANCE_LEVEL,
	SPRITE_STONE_LEVEL_COUNT
};
class SpriteStone{
public:
	SpriteStone(int count = 0, SpriteStoneLevel level = SpriteStoneLevel::PRIMARY_LEVEL);
	string str()const;
	friend ostream& operator<<(ostream& os, const SpriteStone& stone);
	SpriteStone operator+(const SpriteStone& stone);
	SpriteStone operator-(const SpriteStone& stone);
	bool operator>=(const SpriteStone& stone);
	int getCount();
private:
	int count;//灵石的数量:xxx块
	SpriteStoneLevel level;//灵石等级

};

ostream& operator<<(ostream& os, const SpriteStone& stone);
