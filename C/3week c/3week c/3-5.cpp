#include<stdio.h>
int main(void) {
	int kor = 0;
	int eng = 0;
	int math = 0;
	int total = 0;
	float avg = 0.0;

	printf("국어,영어,수학 점수를 입력하시오. : ");
	scanf_s("%d %d %d", &kor, &eng, &math);
	//총점 계산
	total = kor + eng + math;
	//평균 계산
	avg = total / 3;
	//국어 영어 수학 총점 평균 출력
	printf("국어 =%d\t", kor);
	printf("영어 =%d\t", eng);
	printf("수학 =%d\t", math);
	printf("총점 =%d\t", total);
	printf("평균 =%.2f\t", avg);

	return 0;
}