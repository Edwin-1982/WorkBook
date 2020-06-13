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

//星星状态
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
*功能:初始化星星
*输入参数:
*i=星星在全局数组中的下标
*返回值:无
************************************/
void initStar(int i) {
	int rgb = 0;

	if (i<0 || i>MAX_STAR) {
		fprintf(stderr, "老司机,你传的值i[%d]我受不了了!", i); //log日志
		return;
	}

}