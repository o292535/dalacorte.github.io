#include<stdio.h>

int main(void)
{
	int vet[40],x,i=0;
	
	for(i=0; i<40; i++){
	printf("Digite os dados do vetor:", i+1);
	scanf("%d", &vet);
	}
	
	for (int i=0;i<40;i++)
	{
	if (vet%2=0) {
	x = x +1;
	}
	}
	
	printf("Existem %d numeros pares no vetor",x);
	
	return 0;

}
