#include<windows.h>
#include"Son.h"

int main(void) {

	Son wsc("��", "˼��", "����", "�Լ���Ϸ");
	cout << endl;
	wsc.playBasketball();

	//������ؼ̳еĶ����Եķ���1:
	//ʹ��"����::"�����ƶ�,ָ�����ô��ĸ�����̳еķ���!
	
	/*
	wsc.Father::dance();
	wsc.Mother::dance();
	*/

	//������ؼ̳еĶ����Եķ���2:
	//������������ʵ�����ͬ������,������������ڲ�,ʹ�û����������޶�,�����ö�Ӧ�Ļ��෽��
	cout << endl;
	wsc.playGame();
	cout << endl;
	wsc.dance();

	system("pause");
	return 0;
}