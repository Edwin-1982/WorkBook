#include<iostream>
#include<vector>

using  namespace std;

class Man{
public:
	Man() {
	}
	void play(){
		count += 10;
		cout << " I am playing......" << endl;
	}
	int getDrinkCount()const {
		return count;
	}
private:
	int count = 0;//һ�����˶��پ�
};

int main(void) {
	Man zhangFei, guanYu, liuBei;
	vector<Man>men;

	//push_back�ǰѲ�����ֵ,������vector
	//men[0]��ֵ��liuBei����ͬ��,����,��������ͬ����
	men.push_back(liuBei);
	men.push_back(guanYu);
	men.push_back(zhangFei);

	men[0].play();
	cout << men[0].getDrinkCount() << endl;
	cout << liuBei.getDrinkCount() << endl;

	system("pause");
	return 0;
}