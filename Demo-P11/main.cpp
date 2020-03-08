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
		
		//类的static方法内,不能调用这个类的菲static方法(实例方法)
		//play(); 

		//类的static方法内,不能访问非static数据成员
		//cout << age << endl;

		return count;
	}
private:
	static int count;//表示总的人数
	int age;//年龄
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