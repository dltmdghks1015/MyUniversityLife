#include<stdio.h>
// #define PI 3.14 ��ũ�� ���

int main(void) {
	//2���� ������ ������ ����2���� �����Ͻÿ�.
	int a;
	int b;
	//Ű����κ��� 2���� ������ �Է��Ͻÿ�
	printf("2���� ������ �Է��ϼ��� : ");
	scanf_s("%d %d", &a, &b);
	//�Է¹��� 2���� ������ ���ϰ�, �� ����� ����Ͻÿ�.
	printf("%d + %d = %d\n",a,b, (a + b));
	printf("%d - %d = %d\n", a, b, (a - b));
	printf("%d / %d = %.2f\n", a, b, ((float)a / b));
	printf("%d * %d = %d", a, b, (a * b));
	return 0;
}