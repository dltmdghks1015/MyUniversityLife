#include<stdio.h>

int main(void) {

	int day_of_week;
	int fee;

	scanf_s("%d", &day_of_week);

	if (day_of_week == 1) {
		fee = 5000;
	}
	else if (day_of_week == 6 or day_of_week == 0) {
		fee = 10000;
	}
	else {
		fee = 8000;
	}
	printf("fee = %d\n", fee);
	//switch (day_of_week) {
	//case 1://mon
		//fee = 5000;
		//break;
	//case 6://sat
	//case 0://sun
		//fee = 10000;
		//break;
	//default:
		//fee = 8000;
		//break;
	//}
	//printf("fee = %d\n", fee);

	return 0;
}