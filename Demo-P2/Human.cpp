#include "Human.h"
#include<string>
#include<sstream>

using namespace std;
Human::Human(){

}

Human::Human(const string& nick, gender_t gender, int age){
	
	this->nick = nick;
	this->gender = gender;
	this->age = age;
}

Human::~Human(){

}

string Human::getNick() const{
	
	return nick;
}

int Human::getAge() const{
	
	return age;
}

gender_t Human::getGender() const{
	
	return gender;
}

Human* Human::getSpouse() const{
	
	return spouse;
}

vector<Human*> Human::getFriends() const{
	
	return friends;
}

string Human::description() const{
	
	stringstream des;
	des << nick << "-age:" << age << (gender == Male ? "��" : "Ů");
	return des.str();
}

void Human::marry(Human& other){
	if (gender == other.gender) {
		return;
	}
	this->spouse = &other;
	other.spouse = this;
}

void Human::divorce(){
	if (this->spouse == NULL) {
		return;
	}
	spouse->spouse = NULL;
	spouse = NULL;
}

void Human::addFriend(Human& other){
	friends.push_back(&other);
}

void Human::delFriend(Human& other){
	//frineds.begin()����һ�������ָ��!!! "������"
	//���� &friends[0]
	//friends.end() ����һ��������,ָ�����һ��Ԫ�ص���һ��λ��
	
	for (auto it = friends.begin(); it != friends.end();) {
		if (*it == &other) {
			it=friends.erase(it); //erase����,����ֵҲ��һ��������,ָ����һ����Ա
		}
		else {
			it++;
		}
	}
}