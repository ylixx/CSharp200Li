// ConsoleApplication3.cpp : �������̨Ӧ�ó������ڵ㡣
//

#include "stdafx.h"
#include <stdio.h>

union my_union  // ������
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

	printf("������һ��������\n");
	scanf("%f", &x);

	u1.f = x;
	y = float_to_uint(x);

	printf("������   u1.i=%x,u1.f=%f;\n", u1.i, u1.f);
	printf("ָ��ת�� y   =%x,x   =%f;\n", y, x);


	printf("������һ�����ֽ�ʮ��������\n");
	scanf("%x", &y);

	u1.i = y;
	x = uint_to_float(y);

	printf("������   u1.i=%x,u1.f=%f;\n", u1.i, u1.f);
	printf("ָ��ת�� y   =%x,x   =%f;\n", y, x);

	return 0;
}

unsigned int float_to_uint(float f) // ������С��ת�������ֽ�ʮ��������
{

	return (*(unsigned int *)&f);

}

float uint_to_float(unsigned int i) // ���ֽ�ʮ��������ת���ɸ�����С��
{

	return (*(float *)&i);

}
