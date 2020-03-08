#pragma once
#include<string>
#include<vector>

using namespace std;

typedef enum gender {
	Male,
	Female
}gender_t;

class Human
{
public:
	Human();
	Human(const string&nick, gender_t gender, int age);
	~Human();

	string getNick()const;
	int getAge()const;
	gender_t getGender()const;
	Human* getSpouse()const;
	vector<Human*>getFriends()const;
	string description()const;

	void marry(Human& other);
	void divorce();           //¿ÎªÈ
	void addFriend(Human& other);
	void delFriend(Human& other);
private:
	string  nick;   //Í«≥∆
	int age;
	gender_t gender;//–‘±
	Human *spouse=NULL;  //≈‰≈º
	vector<Human*>friends;
};

