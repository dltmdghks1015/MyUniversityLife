#include<stdio.h>

int main(void) {
	
	int num;
	unsigned int abs_value;

	scanf_s("%d", &num);
	if (num > 0) {
		abs_value = num;
	}
	else {
		num = -num;
		abs_value = num;
	}
	//abs_value = num > 0 ? num : -num;
	printf("%d\n", abs_value);

	return 0;
}