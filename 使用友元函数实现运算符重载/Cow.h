#pragma once
class Pork;
class Horse;
class Cow{
public:
	Cow(int weight = 0);

	//ʹ�����������ʵ��:һͷţ+һƥ��=?
	//Pork operator+(const Horse &horse);  //һͷţ+һƥ��
	//Pork operator+(const Cow& cow);      //һͷţ+һͷţ
	
	friend Pork operator+(const Cow& cow1,const Cow &cow2);
	friend Pork operator+(const Cow& cow, const Horse& horse);
	friend Pork operator+(const Horse& horse, const Cow& cow);
private:
	int weight;//ţ������

};

