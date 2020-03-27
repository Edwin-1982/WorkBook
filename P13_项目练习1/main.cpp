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
	Monster monster(5, "����");
	cout << monster << "\n" << endl;
}
void testImmortal() {
	Immortal rock("Rock", "��ţ", ImmortalLevel::LIAN_QI);
	cout << rock << "\n" << endl;

	for (int i = 0; i < 50; i++) {
		rock.mining();
	}
	cout << rock << "\n" << endl;

	Monster monster(1, "����");
	rock.fight(monster);
	cout << "����" << monster << "֮��:\n" << endl;
	cout << rock << "\n" << endl;

	Monster monster2(1, "֩��");
	rock.fight(monster2);
	Monster monster3(1, "�ڻ�");
	rock.fight(monster3);
	cout << "����" << monster2 <<"��" <<monster3<<"֮��:\n" << endl;
	cout << rock << "\n" << endl;
	
	rock.trade(monster2);
	cout << "����" << monster2 << "֮��:\n" << endl;
	cout << rock <<"\n" <<endl;
	
	rock.trade(monster3);
	cout << "����" << monster3 << "֮��:\n" << endl;
	cout << rock << "\n" << endl;
	
	rock.trade();
	cout << "������������֮��\n" << endl;
	cout << rock << "\n" << endl;

	Immortal hanli("����", "�Ʒ��", ImmortalLevel::JIE_DAN);
	cout << hanli <<"\n"<< endl;

	Monster monster4(2, "����");
	hanli.fight(monster4);
	cout << hanli << "\n" << endl;

	rock.trade(hanli, monster4);
	cout << "����֮��" << "\n" << endl;
	cout << rock << "\n" << endl;
	cout << hanli << "\n" << endl;

	string line(25,'-');
	cout << line << "����" << line << "\n" << endl;
	
	Monster monster5(1,"���");
	hanli.fight(monster5);
	cout << "����" << "����" << monster5 << "\n" << endl;
	cout << hanli << "\n" << endl;

	cout << "ROCKʹ��" << monster4 << "�ͺ�������" << monster5 << "\n" << endl;
	rock.trade(monster4,hanli,monster5);
	cout<<rock<< "\n" << endl;
	cout << hanli << "\n" << endl;

	hanli.trade(monster4, rock);
	cout << "������" << monster4 << "��Rock" << "\n" << endl;
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