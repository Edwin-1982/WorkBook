#include<iostream>
#include<vector>

using namespace std;

class Man {
public:
	Man() {
		count++;
	}
	void play()const {
		cout << "I am playing......" << endl;
	}

	static int getCount() {
		
		//���static������,���ܵ��������ķ�static����(ʵ������)
		//play(); 

		//���static������,���ܷ��ʷ�static���ݳ�Ա
		//cout << age << endl;

		return count;
	}
private:
	static int count;//��ʾ�ܵ�����
	int age;//����
};
void test(const Man& man) {//Man &man=man1;
	 man.play();
}

int Man::count = 0;

int main(void) {
	/*const Man man1;
	test(man1);

	Man man2;
	test(man2);*/

	Man man1;
	Man man2;
	cout << Man::getCount() << endl;

	system("pause");
	return 0;
}