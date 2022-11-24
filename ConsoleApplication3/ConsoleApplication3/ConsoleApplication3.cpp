// ConsoleApplication3.cpp : 定义控制台应用程序的入口点。
//

#include "stdafx.h"
#include <stdio.h>

union my_union  // 共用体
{
	unsigned int     i;
	float            f;
};

unsigned int float_to_uint(float f);
float uint_to_float(unsigned int i);

int main(void)
{

	union my_union u1;
	float x;
	unsigned int y;

	printf("请输入一个浮点数\n");
	scanf("%f", &x);

	u1.f = x;
	y = float_to_uint(x);

	printf("共用体   u1.i=%x,u1.f=%f;\n", u1.i, u1.f);
	printf("指针转换 y   =%x,x   =%f;\n", y, x);


	printf("请输入一个四字节十六进制数\n");
	scanf("%x", &y);

	u1.i = y;
	x = uint_to_float(y);

	printf("共用体   u1.i=%x,u1.f=%f;\n", u1.i, u1.f);
	printf("指针转换 y   =%x,x   =%f;\n", y, x);

	return 0;
}

unsigned int float_to_uint(float f) // 浮点型小数转换成四字节十六进制数
{

	return (*(unsigned int *)&f);

}

float uint_to_float(unsigned int i) // 四字节十六进制数转换成浮点型小数
{

	return (*(float *)&i);

}
