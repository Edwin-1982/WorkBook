#include<iostream>
#include<Windows.h>
#include"SpriteStone.h"
#include"Monster.h"
#include"Immortal.h"

using namespace std;

void testSpriteStone() {
	SpriteStone stone(100, SpriteStoneLevel::MIDDLE_LEVEL);
	cout << stone << "\n" << endl;
}

void testMonster() {
	Monster monster(5, "蛟龙");
	cout << monster << "\n" << endl;
}
void testImmortal() {
	Immortal rock("Rock", "奇牛", ImmortalLevel::LIAN_QI);
	cout << rock << "\n" << endl;

	for (int i = 0; i < 50; i++) {
		rock.mining();
	}
	cout << rock << "\n" << endl;

	Monster monster(1, "蛟龙");
	rock.fight(monster);
	cout << "捕获" << monster << "之后:\n" << endl;
	cout << rock << "\n" << endl;

	Monster monster2(1, "蜘蛛");
	rock.fight(monster2);
	Monster monster3(1, "壁虎");
	rock.fight(monster3);
	cout << "捕获" << monster2 <<"和" <<monster3<<"之后:\n" << endl;
	cout << rock << "\n" << endl;
	
	rock.trade(monster2);
	cout << "售卖" << monster2 << "之后:\n" << endl;
	cout << rock <<"\n" <<endl;
	
	rock.trade(monster3);
	cout << "售卖" << monster3 << "之后:\n" << endl;
	cout << rock << "\n" << endl;
	
	rock.trade();
	cout << "售卖所有妖兽之后\n" << endl;
	cout << rock << "\n" << endl;

	Immortal hanli("韩立", "黄枫谷", ImmortalLevel::JIE_DAN);
	cout << hanli <<"\n"<< endl;

	Monster monster4(2, "蛟龙");
	hanli.fight(monster4);
	cout << hanli << "\n" << endl;

	rock.trade(hanli, monster4);
	cout << "交易之后" << "\n" << endl;
	cout << rock << "\n" << endl;
	cout << hanli << "\n" << endl;

	string line(25,'-');
	cout << line << "测试" << line << "\n" << endl;
	
	Monster monster5(1,"天蚕");
	hanli.fight(monster5);
	cout << "韩立" << "捕获" << monster5 << "\n" << endl;
	cout << hanli << "\n" << endl;

	cout << "ROCK使用" << monster4 << "和韩立交换" << monster5 << "\n" << endl;
	rock.trade(monster4,hanli,monster5);
	cout<<rock<< "\n" << endl;
	cout << hanli << "\n" << endl;

	hanli.trade(monster4, rock);
	cout << "韩立卖" << monster4 << "给Rock" << "\n" << endl;
	cout << rock << "\n" << endl;
	cout << hanli << "\n" << endl;
}

int main(void) {
	testSpriteStone();
	testMonster();
	testImmortal();
	system("pause");
	return 0;
}