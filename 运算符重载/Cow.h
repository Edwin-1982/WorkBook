#pragma once
class Pork;
class Horse;
class Cow{
public:
	Cow(int weight = 0);

	//ʹ�����������ʵ��:һͷţ+һƥ��=?
	Pork operator+(const Horse &horse);  //һͷţ+һƥ��
	Pork operator+(const Cow& cow);      //һͷţ+һͷţ
private:
	int weight;//ţ������

};

