#include <stdio.h>

int main (){
	int i=0;
	float x[4], y[4], z[4];
	printf("digitar valores do vetor x \n");
	for (i=0; i<4; i++)
	scanf("%f", &x);
	x[i] = i++;
	printf("digitar valores do vetor y \n");
	for (i=0; i<4; i++)
	scanf("%f", &y);
	y[i] = i++;
	z[i] = x[i] + y[i];	
	printf("soma dos vetores [%f] \n", z[i]);
	return 0;
}
