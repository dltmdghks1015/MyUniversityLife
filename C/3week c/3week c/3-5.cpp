#include<stdio.h>
int main(void) {
	int kor = 0;
	int eng = 0;
	int math = 0;
	int total = 0;
	float avg = 0.0;

	printf("����,����,���� ������ �Է��Ͻÿ�. : ");
	scanf_s("%d %d %d", &kor, &eng, &math);
	//���� ���
	total = kor + eng + math;
	//��� ���
	avg = total / 3;
	//���� ���� ���� ���� ��� ���
	printf("���� =%d\t", kor);
	printf("���� =%d\t", eng);
	printf("���� =%d\t", math);
	printf("���� =%d\t", total);
	printf("��� =%.2f\t", avg);

	return 0;
}