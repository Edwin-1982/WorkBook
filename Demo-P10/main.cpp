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
	int count = 0;//一共喝了多少酒
};

int main(void) {
	Man zhangFei, guanYu, liuBei;
	vector<Man>men;

	//push_back是把参数的值,拷贝给vector
	//men[0]的值和liuBei是相同的,但是,是两个不同对象
	men.push_back(liuBei);
	men.push_back(guanYu);
	men.push_back(zhangFei);

	men[0].play();
	cout << men[0].getDrinkCount() << endl;
	cout << liuBei.getDrinkCount() << endl;

	system("pause");
	return 0;
}