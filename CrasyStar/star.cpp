#include<graphics.h>
#include<conio.h>
#include<stdio.h>
#include<string>

using namespace std;

#define MAX_STAR 100
#define SCREEN_WIDTH 640
#define SCRENN_HEIGHT 480
#define MAX_STEP 5
#define MAX_RADIUS 3
#define BOTTOM_MARGIN 100

//����״̬
enum STATUS {
	STOP = 0,
	UP,
	DOWN,
	LEFT,
	RIGHT,
	RANDOM,
	ALL_STATUS
};

/************************************
*����:��ʼ������
*�������:
*i=������ȫ�������е��±�
*����ֵ:��
************************************/
void initStar(int i) {
	int rgb = 0;

	if (i<0 || i>MAX_STAR) {
		fprintf(stderr, "��˾��,�㴫��ֵi[%d]���ܲ�����!", i); //log��־
		return;
	}

}