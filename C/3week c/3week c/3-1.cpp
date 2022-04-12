#include<stdio.h>
// #define PI 3.14 매크로 상수

int main(void) {
	//2개의 정수를 저장할 변수2개를 선언하시오.
	int a;
	int b;
	//키보드로부터 2개의 정수를 입력하시오
	printf("2개의 정수를 입력하세요 : ");
	scanf_s("%d %d", &a, &b);
	//입력받은 2개의 정수를 더하고, 그 결과를 출력하시오.
	printf("%d + %d = %d\n",a,b, (a + b));
	printf("%d - %d = %d\n", a, b, (a - b));
	printf("%d / %d = %.2f\n", a, b, ((float)a / b));
	printf("%d * %d = %d", a, b, (a * b));
	return 0;
}