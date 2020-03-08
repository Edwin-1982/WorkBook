#include<iostream>
#include"Human.h"

using namespace std;

int main(void) {
	Human lhc("¡Ó∫¸≥Â", Male, 25);
	Human ryy("»Œ”Ø”Ø", Female, 18);
	Human tbg("ÃÔ≤Æπ‚", Male, 30);
	Human yls("‘¿¡È…∫", Female, 20);
	Human cx("≥Â–Èµ¿≥§", Male, 55);

	lhc.marry(yls);
	Human* who = lhc.getSpouse();
	cout << lhc.getNick() << "µƒ≈‰≈º «: " << who->description() << endl;
	cout << who->getNick() << "µƒ≈‰≈º «: " << who->getSpouse()->description() << endl;
	cout << endl;
	cout << lhc.getNick() << "¿ÎªÈ" << endl << endl;
	lhc.divorce();
	if (lhc.getSpouse() == NULL) {
		cout << lhc.getNick()<<"µ•…Ì" << endl;
	}
	else {
		cout << lhc.getNick() << "¿ÎªÈ ß∞‹" << endl;
	}
	cout << endl;

	lhc.addFriend(tbg);
	lhc.addFriend(cx);
	
	vector<Human*>friends = lhc.getFriends();
	cout << "¡Ó∫¸≥Âµƒ∫√”—–≈œ¢:" << endl;
	for (int i = 0; i < friends.size(); i++) {
		
		cout<<friends[i]->description() << endl;
	}
	cout << endl;

	lhc.delFriend(tbg);
	cout << lhc.getNick() << "…æ≥˝∫√”—: " << tbg.getNick() << endl;

	friends = lhc.getFriends();
	cout << endl;
	for (int i = 0; i < friends.size(); i++) {
		cout << "¡Ó∫¸≥Â £”‡∫√”—:\n"<<friends[i]->description() << endl;
	}
	system("pause");
	return 0;
}